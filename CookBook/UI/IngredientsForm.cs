using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel.Models;
using DataAcceessLayer.Repositories;
using DataAcceessLayer.Contracts;
using Newtonsoft.Json.Linq;
using CookBook.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CookBook.UI
{
    public partial class IngredientsForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        readonly IIngredientsRepository _ingredientsRepository;
        StyleWatcher _styleWatcher;
        private int _IngredientToEditId;
        public IngredientsForm(IIngredientsRepository ingredientsRepository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _ingredientsRepository = ingredientsRepository;
            _ingredientsRepository.OnError += (message) => MessageBox.Show(message);

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
        private async void AddToFridgeBtn_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;

            Ingredient ingredient = new Ingredient(NameTxt.Text, TypeTxt.Text, WeightNum.Value, KcalPer100gNum.Value, PricePer100gNum.Value);
            AddToFridgeBtn.Enabled = false;
            await _ingredientsRepository.AddIngredient(ingredient);
            AddToFridgeBtn.Enabled = true;
            ClearAllFields();
            RefreshGridData();
        }
        private void ClearAllFields()
        {
            NameTxt.Text = default;
            TypeTxt.Text = default;
            WeightNum.Value = 1;
            PricePer100gNum.Value = 0;
            KcalPer100gNum.Value = 0;
            AddToFridgeBtn.Visible = true;
            EditIngredientBtn.Visible = false;
            _IngredientToEditId = 0;
        }
        private void IngredientsForm_Load(object sender, EventArgs e)
        {
            RefreshGridData();
            CustomizeGridAppearance();

            AddToFridgeBtn.Visible = true;
            EditIngredientBtn.Visible = false;
        }
        private async void RefreshGridData()
        {
            IngredientsGrid.DataSource = await _ingredientsRepository.GetIngredients(SearchTxt.Text);
        }
        private void CustomizeGridAppearance()
        {
            IngredientsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            IngredientsGrid.AutoGenerateColumns = false;

            DataGridViewColumn[] columns = new DataGridViewColumn[8];
            columns[0] = new DataGridViewTextBoxColumn() { DataPropertyName = "Id", Visible = false };
            columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name", SortMode = DataGridViewColumnSortMode.Automatic };
            columns[2] = new DataGridViewTextBoxColumn() { DataPropertyName = "Type", HeaderText = "Type", SortMode = DataGridViewColumnSortMode.Automatic };
            columns[3] = new DataGridViewTextBoxColumn() { DataPropertyName = "Weight", HeaderText = "Weight", SortMode = DataGridViewColumnSortMode.Automatic };
            columns[4] = new DataGridViewTextBoxColumn() { DataPropertyName = "PricePer100g", HeaderText = "Price(100g)", SortMode = DataGridViewColumnSortMode.Automatic };
            columns[5] = new DataGridViewTextBoxColumn() { DataPropertyName = "KCalPer100g", HeaderText = "Kcal(100g)", SortMode = DataGridViewColumnSortMode.Automatic };
            columns[6] = new DataGridViewButtonColumn()
            {
                Text = "Delete",
                Name = "DeleteBtn",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            };
            columns[7] = new DataGridViewButtonColumn()
            {
                Text = "Edit",
                Name = "EditBtn",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            };

            IngredientsGrid.Columns.Clear();
            IngredientsGrid.Columns.AddRange(columns);
        }
        private void ClearFieldsBtn_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
        private async void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            int lengthBeforePause = SearchTxt.Text.Length;

            await Task.Delay(500);

            int lengthAfterPause = SearchTxt.Text.Length;
            if (lengthBeforePause == lengthAfterPause)
                RefreshGridData();
        }
        private bool IsValid()
        {
            bool isValid = true;

            string message = string.Empty;

            if (string.IsNullOrEmpty(NameTxt.Text))
            {
                isValid = false;
                message += "Please enter name. \n\n";
            }
            if (string.IsNullOrEmpty(TypeTxt.Text))
            {
                isValid = false;
                message += "Please enter type. \n\n";
            }

            if (WeightNum.Value <= 0)
            {
                isValid = false;
                message += "Weigt must be greater than 0. \n\n";
            }
            if (KcalPer100gNum.Value < 0)
            {
                isValid = false;
                message += "Kcal must be greater than or equal to 0. \n\n";
            }
            if (PricePer100gNum.Value <= 0)
            {
                isValid = false;
                message += "Price must be greater than 0. \n\n";
            }

            if (!isValid)
                MessageBox.Show(message, "Form not valid!");

            return isValid;
        }
        private async void IngredientsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && IngredientsGrid.CurrentCell is DataGridViewButtonCell)
            {

                Ingredient clickedIngredient = (Ingredient)IngredientsGrid.Rows[e.RowIndex].DataBoundItem;

                if (IngredientsGrid.CurrentCell.OwningColumn.Name == "DeleteBtn")
                {
                    await _ingredientsRepository.DeleteIngredient(clickedIngredient);

                    RefreshGridData();
                    ClearAllFields();
                }
                else if (IngredientsGrid.CurrentCell.OwningColumn.Name == "EditBtn")
                {
                    FillFormForEdit(clickedIngredient);
                }
            }
        }
        private void FillFormForEdit(Ingredient clickedIngredient)
        {
            _IngredientToEditId = clickedIngredient.Id;

            NameTxt.Text = clickedIngredient.Name;
            TypeTxt.Text = clickedIngredient.Type;
            if (clickedIngredient.Weight != 0)
                WeightNum.Value = clickedIngredient.Weight;
            if (clickedIngredient.PricePer100g != 0)
                PricePer100gNum.Value = clickedIngredient.PricePer100g;
            if (clickedIngredient.KcalPer100g != 0)
                KcalPer100gNum.Value = clickedIngredient.KcalPer100g;

            AddToFridgeBtn.Visible = false;
            EditIngredientBtn.Visible = true;
        }
        private async void EditIngredientBtn_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;

            Ingredient ingredient = new Ingredient(NameTxt.Text, TypeTxt.Text, WeightNum.Value, KcalPer100gNum.Value, PricePer100gNum.Value, _IngredientToEditId);

            await _ingredientsRepository.EditIngredient(ingredient);

            ClearAllFields();
            RefreshGridData();
            AddToFridgeBtn.Visible = true;
            EditIngredientBtn.Visible = false;
            _IngredientToEditId = 0;
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
            WeightLbl.BackColor = ColorTranslator.FromHtml(secondaryBgr);
            KcalLbl.BackColor = ColorTranslator.FromHtml(secondaryBgr);
            PriceLbl.BackColor = ColorTranslator.FromHtml(secondaryBgr);

            NameLbl.ForeColor = ColorTranslator.FromHtml(primaryFgr);
            TypeLbl.ForeColor = ColorTranslator.FromHtml(primaryFgr);
            WeightLbl.ForeColor = ColorTranslator.FromHtml(primaryFgr);
            KcalLbl.ForeColor = ColorTranslator.FromHtml(primaryFgr);
            PriceLbl.ForeColor = ColorTranslator.FromHtml(primaryFgr); ;

            EditIngredientBtn.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnBgr"]);
            AddToFridgeBtn.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnBgr"]);
            ClearFieldsBtn.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBtnBgr"]);

            EditIngredientBtn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);
            AddToFridgeBtn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBtnFgr"]);
            ClearFieldsBtn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["tertiaryBtnFgr"]);
        }
        private void IngredientsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _styleWatcher.onStyleChanged -= OnStyleChanged;
        }
    }
}