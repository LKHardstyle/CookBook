using CookBook.Services;
using CookBook.ViewModels;
using DataAcceessLayer.Contracts;
using DataAcceessLayer.CustomQueryResults;
using DataAcceessLayer.Repositories;
using DomainModel.Models;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.UI
{
    public partial class RecipeIngredientsForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IRecipeIngriendtsRepository _recipeIngredientsRepository;
        private readonly IIngredientsRepository _ingredientsRepository;

        StyleWatcher _styleWatcher;
        public int RecipeId { get; set; }
        public RecipeIngredientsForm(IRecipeIngriendtsRepository recipeIngriendtsRepository, IIngredientsRepository ingredientsRepository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

            _recipeIngredientsRepository = recipeIngriendtsRepository;
            _ingredientsRepository = ingredientsRepository;

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

        private void RecipeIngredientsForm_Load(object sender, EventArgs e)
        {
            RefreshRecipeIngredients();
            RefreshAllIngredients();
        }
        private async void RefreshRecipeIngredients()
        {
            List<RecipeIngredientWithNameAndAmount> results = await _recipeIngredientsRepository.GetRecipeIngredients(RecipeId);

            List<RecipeIngredientVM> recipeIngredients = new List<RecipeIngredientVM>();

            foreach (var ingredient in results)
            {
                recipeIngredients.Add(new RecipeIngredientVM(ingredient.IngredientId, ingredient.Name, ingredient.Amount));
            }

            List<ListBoxItemVM> customLbxItems = new List<ListBoxItemVM>();

            foreach (var ri in recipeIngredients)
            {
                customLbxItems.Add(new ListBoxItemVM(ri, ri.NameWithAmount));
            }

            RecipeIngredientsCustomLbx.setDataSource(customLbxItems);
        }
        private async void RefreshAllIngredients()
        {
            //AllIngredientsLbx.DataSource = await _ingredientsRepository.GetIngredients();
            //AllIngredientsLbx.DisplayMember = "Name";

            List<Ingredient> allIngredients = await _ingredientsRepository.GetIngredients();

            List<ListBoxItemVM> itemsList = new List<ListBoxItemVM>();

            foreach (Ingredient i in allIngredients)
            {
                itemsList.Add(new ListBoxItemVM(i, i.Name));
            }

            AllIngredientsCustomLbx.setDataSource(itemsList);
        }
        private async void AddIngredientBtn_Click(object sender, EventArgs e)
        {
            if (AllIngredientsCustomLbx.SelectedItem != null && AllIngredientsCustomLbx.SelectedItem.Item != null)
            {
                AmountForm amountform = new AmountForm(_serviceProvider);
                if (amountform.ShowDialog() == DialogResult.OK)
                {
                    Ingredient selectedIngredient = (Ingredient)AllIngredientsCustomLbx.SelectedItem.Item;

                    RecipeIngredient newrecipeIngredient = new RecipeIngredient(RecipeId, selectedIngredient.Id, amountform.Amount);

                    bool isExistingIngredient = CheckIsExistingIngredient(selectedIngredient.Id, RecipeIngredientsCustomLbx.DataSource);
                    if (isExistingIngredient)
                        await _recipeIngredientsRepository.EditRecipeIngredientAmount(newrecipeIngredient);
                    else
                        await _recipeIngredientsRepository.AddRecipeIngredient(newrecipeIngredient);

                    RefreshRecipeIngredients();
                }
            }
        }
        private bool CheckIsExistingIngredient(int selectedIngredientId, List<ListBoxItemVM> dataSource)
        {
            foreach (ListBoxItemVM customLbxItem in dataSource)
            {
                RecipeIngredientVM ri = customLbxItem.Item as RecipeIngredientVM;
                if (ri.IngredientId == selectedIngredientId)
                    return true;
            }
            return false;
        }
        private async void RemoveIngredientsBtn_Click(object sender, EventArgs e)
        {
            if (RecipeIngredientsCustomLbx.SelectedItem != null)
            {
                RecipeIngredientVM ingredient = (RecipeIngredientVM)RecipeIngredientsCustomLbx.SelectedItem.Item;

                await _recipeIngredientsRepository.DeleteRecipeIngredient(ingredient.IngredientId, RecipeId);

                RefreshRecipeIngredients();
            }
        }

        private void ApplyStyles(int? theme = 1)
        {
            JObject themeConfig = ConfigurationManager.LoadThemeConfig(theme);

            Panel.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBgr"]);

            AllIngredientsLbl.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBgr"]);
            RecipeIngredientsLbl.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBgr"]);
            AllIngredientsLbl.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryFgr"]);
            RecipeIngredientsLbl.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryFgr"]);

            AddIngredientBtn.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnBgr"]);
            RemoveIngredientsBtn.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBtnBgr"]);
            AddIngredientBtn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);
            RemoveIngredientsBtn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);
        }

        private void RecipeIngredientsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _styleWatcher.onStyleChanged -= OnStyleChanged;
        }
    }
}
