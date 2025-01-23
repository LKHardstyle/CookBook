using CookBook.Helpers;
using CookBook.Services;
using CookBook.ViewModels;
using DataAcceessLayer.Contracts;
using DomainModel.Models;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.UI
{
    public partial class FoodManagerForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private FoodManagerCache _foodManagerCache;
        DesktopFileWatcher _desktopFileWatcher;
        StyleWatcher _styleWatcher;
        private bool _isUserImageAdded = false;
        public enum RecipeAvailability { Available, Unavailable };
        public FoodManagerForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _serviceProvider = serviceProvider;

            _foodManagerCache = _serviceProvider.GetRequiredService<FoodManagerCache>();
            _desktopFileWatcher = _serviceProvider.GetRequiredService<DesktopFileWatcher>();
            RecipesLbx.OnSelectedItemChanged += OnSelectedRecipeChanged;
            _desktopFileWatcher.onFileStatusChange += OnFileStatusChanged;

            NotificationIcon.Visible = DesktopFileWatcher.CurrentFileStatus;

            _styleWatcher = _serviceProvider.GetRequiredService<StyleWatcher>();
            _styleWatcher.onStyleChanged += OnStyleChanged;

            ApplyStyles(StyleWatcher.CurrentStyle);
        }

        private void OnStyleChanged(int style)
        {
            Invoke(new Action(() =>
            {
                ApplyStyles(style);
            }));
        }

        private void OnFileStatusChanged(bool fileExists)
        {
            if (this.IsHandleCreated)
            {
                Invoke(new Action(() =>
                {
                    NotificationIcon.Visible = fileExists;
                }));
            }
        }
        private void OnSelectedRecipeChanged(ListBoxItemVM selectedItem)
        {

            Recipe selectedRecipe = (Recipe)selectedItem.Item;

            var ingredients = _foodManagerCache.GetIngredients(selectedRecipe.Id);

            List<ListBoxItemVM> datasource = new List<ListBoxItemVM>();
            decimal totalKcal = 0;
            decimal totalPrice = 0;

            foreach (var ingredient in ingredients)
            {
                ListBoxItemVM item = new ListBoxItemVM(ingredient, ingredient.NameWithMissingAmount);
                datasource.Add(item);

                totalKcal += (ingredient.KcalPer100g / 100) * ingredient.Amount;
                totalPrice += (ingredient.PricePer100g / 100) * ingredient.Amount;
            }
            IngredientsLbx.setDataSource(datasource);
            totalKcal = Math.Round(totalKcal, 2);
            totalPrice = Math.Round(totalPrice, 2);
            TotalCaloriesLbl.Text = totalKcal.ToString();
            TotalPriceLbl.Text = totalPrice.ToString() + "€";

            DescriptionTxt.Text = selectedRecipe.Description;
            if (selectedRecipe.Image != null)
                RecipePicture.Image = ImageHelper.ConvertFromDbImage(selectedRecipe.Image);
            else
                RecipePicture.Image = ImageHelper.PlaceholderImage;
        }
        private void AvailableBtn_Click(object sender, EventArgs e)
        {
            RefreshRecipesLbx(RecipeAvailability.Available);
        }
        private void UnavailableBtn_Click(object sender, EventArgs e)
        {
            RefreshRecipesLbx(RecipeAvailability.Unavailable);
        }
        private void RefreshRecipesLbx(RecipeAvailability recipeAvailability)
        {
            List<ListBoxItemVM> datasource = new List<ListBoxItemVM>();
            List<Recipe> recipes = new List<Recipe>();

            if (recipeAvailability == RecipeAvailability.Available)
            {
                recipes = _foodManagerCache.AvailableRecipes;
                CreateShoppingListBtn.Visible = false;
                PrepareFoodBtn.Visible = true;
            }
            else if (recipeAvailability == RecipeAvailability.Unavailable)
            {
                recipes = _foodManagerCache.UnavailableRecipes;
                CreateShoppingListBtn.Visible = true;
                PrepareFoodBtn.Visible = false;
            }

            foreach (Recipe r in recipes)
            {
                datasource.Add(new ListBoxItemVM(r, r.Name));
            }

            RecipesLbx.setDataSource(datasource);
        }
        private async void FoodManagerForm_Load(object sender, EventArgs e)
        {
            RecipePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            await _foodManagerCache.RefreshData();

            RefreshRecipesLbx(RecipeAvailability.Available);
        }
        private async void PrepareFoodBtn_Click(object sender, EventArgs e)
        {
            if (RecipesLbx.SelectedItem == null)
                return;
            Recipe selectedRecipe = RecipesLbx.SelectedItem.Item as Recipe;

            await _foodManagerCache.PrepareFood(selectedRecipe);
            await _foodManagerCache.RefreshData();
            RefreshRecipesLbx(RecipeAvailability.Available);

            TotalRecipesCounter.Instance.PreparedRecipesCounter++;

        }
        private void CreateShoppingListBtn_Click(object sender, EventArgs e)
        {
            if (_foodManagerCache.UnavailableRecipes.Count == 0)
            {
                MessageBox.Show("There are no Unavailable Recipes");
                return;
            }
            string shoppingList = "";

            foreach (Recipe recipe in _foodManagerCache.UnavailableRecipes)
            {
                shoppingList += $"Missing Ingredients for {recipe.Name} \n";

                var recipeIngredients = _foodManagerCache.GetIngredients(recipe.Id);

                foreach (var ingredient in recipeIngredients)
                {
                    if (ingredient.MissingAmount != 0)
                        shoppingList += $"{ingredient.Name} {ingredient.MissingAmount}g \n";
                }
                shoppingList += "\n";
            }
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                string filePath = Path.Combine(desktopPath, "ShoppingList.txt");

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.Write(shoppingList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while creating Shopping List!");
            }
        }
        private void NotificationIcon_MouseEnter(object sender, EventArgs e)
        {
            notifcationTooltip.Show("You need to shop for ingredients", NotificationIcon, 0, 0);
        }
        private void NotificationIcon_MouseLeave(object sender, EventArgs e)
        {
            notifcationTooltip.Hide(NotificationIcon);
        }
        private void ApplyStyles(int ?theme = 1 )
        {
            JObject themeConfig = ConfigurationManager.LoadThemeConfig(theme);

            string primaryBgr = (string)themeConfig["primaryBgr"];
            string secondaryBgr = (string)themeConfig["secondaryBgr"];
            string primaryFgr = (string)themeConfig["primaryFgr"];


            LeftPanel.BackColor = ColorTranslator.FromHtml(primaryBgr);
            RightPanel.BackColor = ColorTranslator.FromHtml(secondaryBgr);

            IngredientsLbl.BackColor = ColorTranslator.FromHtml(secondaryBgr);
            TotalCaloriesLbl.BackColor = ColorTranslator.FromHtml(secondaryBgr);
            TotalPriceLbl.BackColor = ColorTranslator.FromHtml(secondaryBgr);
            CaloriesLbl.BackColor = ColorTranslator.FromHtml(secondaryBgr);
            PriceLbl.BackColor = ColorTranslator.FromHtml(secondaryBgr);

            IngredientsLbl.ForeColor = ColorTranslator.FromHtml(primaryFgr);
            TotalCaloriesLbl.ForeColor = ColorTranslator.FromHtml(primaryFgr);
            TotalPriceLbl.ForeColor = ColorTranslator.FromHtml(primaryFgr);
            CaloriesLbl.ForeColor = ColorTranslator.FromHtml(primaryFgr);
            PriceLbl.ForeColor = ColorTranslator.FromHtml(primaryFgr);

            AvailableBtn.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnBgr"]);
            UnavailableBtn.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBtnBgr"]);
            PrepareFoodBtn.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnBgr"]);
            CreateShoppingListBtn.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnBgr"]);

            AvailableBtn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);
            UnavailableBtn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);
            PrepareFoodBtn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);
            CreateShoppingListBtn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);
        }

        private void FoodManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _styleWatcher.onStyleChanged -= OnStyleChanged;
        }
    }
}
