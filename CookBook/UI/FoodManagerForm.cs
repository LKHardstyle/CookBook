using CookBook.Helpers;
using CookBook.Services;
using CookBook.ViewModels;
using DataAcceessLayer.Contracts;
using DomainModel.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public enum RecipeAvailability { Available, Unavailable };
        public FoodManagerForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _serviceProvider = serviceProvider;

            _foodManagerCache = _serviceProvider.GetRequiredService<FoodManagerCache>();
            RecipesLbx.OnSelectedItemChanged += OnSelectedRecipeChanged;            
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

        }
        private void CreateShoppingListBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
