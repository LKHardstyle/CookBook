using CookBook.Helpers;
using CookBook.Services;
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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.UI
{
    public partial class RecipesForm : Form
    {
        private readonly IRecipeTypesRepository _recipeTypesRepository;
        private readonly IServiceProvider _serviceProvider;
        private readonly IRecipesRepository _recipesRepository;
        private bool _isUserImageAdded = false;
        private int _RecipeToEditId;
        private List<RecipeWithType> _recipesCache;
        StyleWatcher _styleWatcher;

        public RecipesForm(IRecipeTypesRepository recipeTypesRepository, IServiceProvider serviceProvider, IRecipesRepository recipesRepository)
        {
            InitializeComponent();
            _recipeTypesRepository = recipeTypesRepository;
            _serviceProvider = serviceProvider;
            _recipesRepository = recipesRepository;
            _recipesRepository.OnError += (message) => MessageBox.Show(message);

            _styleWatcher = serviceProvider.GetRequiredService<StyleWatcher>();
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
        private async Task RefreshRecipeTypes()
        {
            RecipeType previouslySelectedFilter = (RecipeType)RecipeFilterCbx.SelectedItem;
            RecipeType previouslySelectedRecipeType = (RecipeType)RecipeTypesCbx.SelectedItem;

            List<RecipeType> recipetypes = await _recipeTypesRepository.GetRecipeTypes();

            RecipeTypesCbx.DataSource = recipetypes;
            RecipeTypesCbx.DisplayMember = "Name";

            List<RecipeType> filterlist = new List<RecipeType>();
            filterlist.Add(new RecipeType("All recipe Types", 0));
            filterlist.AddRange(recipetypes);

            RecipeFilterCbx.DataSource = filterlist;
            RecipeFilterCbx.DisplayMember = "Name";

            if (previouslySelectedFilter != null && previouslySelectedFilter.Id != 0)
            {
                int indexToSelect = FindRecipeTypeIndex(previouslySelectedFilter.Id);

                RecipeFilterCbx.SelectedIndex = indexToSelect + 1;
            }

            if (previouslySelectedRecipeType != null && previouslySelectedRecipeType.Id != 0)
            {
                int indexToSelect = FindRecipeTypeIndex(previouslySelectedRecipeType.Id);

                RecipeTypesCbx.SelectedIndex = indexToSelect;
            }
        }
        private async void RefreshRecipesCache()
        {
            _recipesCache = await _recipesRepository.GetRecipe();
            FilterGridData();
        }
        private void FilterGridData()
        {
            RecipeType selectedType = (RecipeType)RecipeFilterCbx.SelectedItem;

            if (selectedType.Id == 0)
                RecipesGrid.DataSource = _recipesCache;
            else
            {
                RecipesGrid.DataSource = _recipesCache.Where(r => r.RecipeTypeId == selectedType.Id).ToList();
            }
        }
        private async void RecipesForm_Load(object sender, EventArgs e)
        {
            await RefreshRecipeTypes();
            RefreshRecipesCache();
            CustomizeGridAppearance();
            RecipePictureBox.Image = ImageHelper.PlaceholderImage;
            RecipePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            EditRecipeBtn.Visible = false;
        }
        private void CustomizeGridAppearance()
        {
            RecipesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RecipesGrid.AutoGenerateColumns = false;

            DataGridViewColumn[] columns = new DataGridViewColumn[7];
            columns[0] = new DataGridViewTextBoxColumn() { DataPropertyName = "Id", Visible = false };
            columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name", SortMode = DataGridViewColumnSortMode.Automatic };
            columns[2] = new DataGridViewTextBoxColumn() { DataPropertyName = "Description", HeaderText = "Description", SortMode = DataGridViewColumnSortMode.Automatic };
            columns[3] = new DataGridViewTextBoxColumn() { DataPropertyName = "Type", HeaderText = "Type", SortMode = DataGridViewColumnSortMode.Automatic };

            columns[4] = new DataGridViewButtonColumn()
            {
                Text = "Edit",
                Name = "EditBtn",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            };
            columns[5] = new DataGridViewButtonColumn()
            {

                Text = "Delete",
                Name = "DeleteBtn",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            };
            columns[6] = new DataGridViewButtonColumn()
            {

                Text = "Ingredients",
                Name = "IngredientsBtn",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            };
            RecipesGrid.RowHeadersVisible = false;
            RecipesGrid.Columns.Clear();
            RecipesGrid.Columns.AddRange(columns);
        }
        private void AddRecipeTypeBtn_Click(object sender, EventArgs e)
        {
            RecipeTypesForm Form = _serviceProvider.GetRequiredService<RecipeTypesForm>();
            Form.FormClosed += (sender, e) => RefreshRecipeTypes();
            Form.ShowDialog();
        }
        public void ClearAllFields()
        {
            NameTxt.Text = string.Empty;
            DescriptionTxt.Text = string.Empty;
            RecipePictureBox.Image = ImageHelper.PlaceholderImage;
            RefreshRecipeTypes();
            _isUserImageAdded = false;
            AddRecipeBtn.Visible = true;
            EditRecipeBtn.Visible = false;
        }
        public bool IsValid()
        {
            bool isValid = true;

            string message = string.Empty;

            if (string.IsNullOrEmpty(NameTxt.Text))
            {
                isValid = false;
                message += "Please enter Name\n";
            }

            if (string.IsNullOrEmpty(DescriptionTxt.Text))
            {
                isValid = false;
                message += "Please enter Description\n";
            }

            if (!isValid)
                MessageBox.Show(message, "Form not Valid");

            return isValid;
        }
        private async void AddRecipeBtn_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;

            byte[] image = null;
            if (_isUserImageAdded)
                image = ImageHelper.ConvertToDbImage(RecipePictureBox.ImageLocation);

            int recipeTypeId = ((RecipeType)RecipeTypesCbx.SelectedItem).Id;
            Recipe newRecipe = new Recipe(NameTxt.Text, DescriptionTxt.Text, image, recipeTypeId);

            await _recipesRepository.AddRecipe(newRecipe);

            ClearAllFields();
            RefreshRecipesCache();
        }
        private void RecipePictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Please Select an Image",
                Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg",
                Multiselect = false
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    RecipePictureBox.ImageLocation = openFileDialog.FileName;
                    _isUserImageAdded = true;
                }
            }
        }
        private void ClearAllFieldsBtn_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
        private async void RecipesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && RecipesGrid.CurrentCell is DataGridViewButtonCell)
            {
                RecipeWithType clickedRecipe = (RecipeWithType)RecipesGrid.Rows[e.RowIndex].DataBoundItem;
                if (RecipesGrid.CurrentCell.OwningColumn.Name == "EditBtn")
                {
                    FillFormEdit(clickedRecipe);
                }
                else if (RecipesGrid.CurrentCell.OwningColumn.Name == "DeleteBtn")
                {
                    await _recipesRepository.DeleteRecipe(clickedRecipe.Id);

                    RefreshRecipesCache();
                }
                else if (RecipesGrid.CurrentCell.OwningColumn.Name == "IngredientsBtn")
                {
                    RecipeIngredientsForm form = _serviceProvider.GetRequiredService<RecipeIngredientsForm>();
                    form.RecipeId = clickedRecipe.Id;
                    form.ShowDialog();
                }
            }
        }
        private void FillFormEdit(RecipeWithType clickedRecipe)
        {
            _RecipeToEditId = clickedRecipe.Id;

            NameTxt.Text = clickedRecipe.Name;
            DescriptionTxt.Text = clickedRecipe.Description;

            if (clickedRecipe.Image != null)
                RecipePictureBox.Image = ImageHelper.ConvertFromDbImage(clickedRecipe.Image);
            else
            {
                RecipePictureBox.Image = ImageHelper.PlaceholderImage;
            }

            RecipeTypesCbx.SelectedIndex = FindRecipeTypeIndex(clickedRecipe.RecipeTypeId);
            AddRecipeBtn.Visible = false;
            EditRecipeBtn.Visible = true;
        }
        private int FindRecipeTypeIndex(int recipeTypeId)
        {
            List<RecipeType> allRecipeTypes = (List<RecipeType>)RecipeTypesCbx.DataSource;

            //Different ways to write foreach loop

            //First way:
            //RecipeType matchingRecipetype = null;
            //foreach(RecipeType rt in allRecipeTypes)
            //  if(rt.Id = recipeTypeId)
            //      matchingRecipeType = rt;

            //2nd way:
            //RecipeType matchingRecipetype = allRecipeTypes.Where(rt => rt.Id == recipeTypeId).SingleOrDefault();

            //3rd way:
            RecipeType matchingRecipetype = allRecipeTypes.FirstOrDefault(rt => rt.Id == recipeTypeId);

            int index = RecipeTypesCbx.Items.IndexOf(matchingRecipetype);

            return index;
        }
        private async void EditRecipeBtn_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;
            byte[] image = null;
            if (_isUserImageAdded)
                image = ImageHelper.ConvertToDbImage(RecipePictureBox.ImageLocation);

            int recipeTypeId = ((RecipeType)RecipeTypesCbx.SelectedItem).Id;

            Recipe recipe = new Recipe(NameTxt.Text, DescriptionTxt.Text, image, recipeTypeId, _RecipeToEditId);

            await _recipesRepository.EditRecipe(recipe);

            ClearAllFields();
            RefreshRecipesCache();
            _RecipeToEditId = 0;
        }
        private void RecipeFilterCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGridData();
        }
        private void ApplyStyles(int? theme = 1)
        {
            JObject themeConfig = ConfigurationManager.LoadThemeConfig(theme);

            string primaryBgr = (string)themeConfig["primaryBgr"];
            string secondaryBgr = (string)themeConfig["secondaryBgr"];
            string primaryFgr = (string)themeConfig["primaryFgr"];


            LeftPanel.BackColor = ColorTranslator.FromHtml(primaryBgr);
            RightPanel.BackColor = ColorTranslator.FromHtml(secondaryBgr);

            NameLbl.BackColor = ColorTranslator.FromHtml(secondaryBgr);
            TypeLbl.BackColor = ColorTranslator.FromHtml(secondaryBgr);
            DescriptionLbl.BackColor = ColorTranslator.FromHtml(secondaryBgr);
            ImageLbl.BackColor = ColorTranslator.FromHtml(secondaryBgr);

            NameLbl.ForeColor = ColorTranslator.FromHtml(primaryFgr);
            TypeLbl.ForeColor = ColorTranslator.FromHtml(primaryFgr);
            DescriptionLbl.ForeColor = ColorTranslator.FromHtml(primaryFgr);
            ImageLbl.ForeColor = ColorTranslator.FromHtml(primaryFgr);

            EditRecipeBtn.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnBgr"]);
            AddRecipeBtn.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnBgr"]);
            ClearAllFieldsBtn.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBtnBgr"]);
            AddRecipeTypeBtn.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnBgr"]);

            EditRecipeBtn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);
            AddRecipeBtn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBtnFgr"]);
            ClearAllFieldsBtn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["tertiaryBtnFgr"]);
            AddRecipeTypeBtn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);
        }

        private void RecipesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _styleWatcher.onStyleChanged -= OnStyleChanged;
        }
    }
}
