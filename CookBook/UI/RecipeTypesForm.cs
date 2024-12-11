using CookBook.ViewModels;
using DataAcceessLayer.Contracts;
using DataAcceessLayer.Repositories;
using DomainModel.Models;
using Newtonsoft.Json.Linq;
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
    public partial class RecipeTypesForm : Form
    {
        private readonly IRecipeTypesRepository _recipeTypesRepository;
        public RecipeTypesForm(IRecipeTypesRepository recipeTypesRepository)
        {
            InitializeComponent();
            _recipeTypesRepository = recipeTypesRepository;
            _recipeTypesRepository.OnError += (message)=> MessageBox.Show(message);

            ApplyStyles();
        }
        private void RecipeTypesForm_Load(object sender, EventArgs e)
        {
            RefreshRecipeTypesList();
        }
        private async Task RefreshRecipeTypesList()
        {
            List<RecipeType> recipeTypes = await _recipeTypesRepository.GetRecipeTypes();

            List<ListBoxItemVM> customLbxItems = new List<ListBoxItemVM>();

            foreach(var rt in recipeTypes)
            {
                customLbxItems.Add(new ListBoxItemVM(rt, rt.Name));
            }

            RecipeTypesCustomLbx.setDataSource(customLbxItems);            
        }
        private async void AddRecipeTypeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NewTypeTxt.Text))
                return;

            RecipeType newRecipeType = new RecipeType(NewTypeTxt.Text);  

            await _recipeTypesRepository.AddRecipetype(newRecipeType);

            RefreshRecipeTypesList();
            NewTypeTxt.Text = string.Empty;
        }
        private void ApplyStyles()
        {
            JObject themeConfig = ConfigurationManager.LoadThemeConfig();

            string secondaryBgr = (string)themeConfig["secondaryBgr"];            
            string primaryFgr = (string)themeConfig["primaryFgr"];

            Panel.BackColor = ColorTranslator.FromHtml(secondaryBgr);

            TypeLbl.BackColor = ColorTranslator.FromHtml(secondaryBgr);
            TypeLbl.ForeColor = ColorTranslator.FromHtml(primaryFgr);
            
            AddRecipeTypeBtn.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnBgr"]);
            AddRecipeTypeBtn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);
        }
    }
}
