namespace CookBook.UI
{
    partial class IngredientsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameLbl = new Label();
            TypeLbl = new Label();
            WeightLbl = new Label();
            KcalLbl = new Label();
            PriceLbl = new Label();
            PricePer100gNum = new NumericUpDown();
            WeightNum = new NumericUpDown();
            KcalPer100gNum = new NumericUpDown();
            TypeTxt = new TextBox();
            NameTxt = new TextBox();
            AddToFridgeBtn = new Button();
            IngredientsGrid = new DataGridView();
            SearchTxt = new TextBox();
            ClearFieldsBtn = new Button();
            EditIngredientBtn = new Button();
            RightPanel = new Panel();
            LeftPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)PricePer100gNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WeightNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KcalPer100gNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IngredientsGrid).BeginInit();
            SuspendLayout();
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(720, 89);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(52, 21);
            NameLbl.TabIndex = 0;
            NameLbl.Text = "Name";
            // 
            // TypeLbl
            // 
            TypeLbl.AutoSize = true;
            TypeLbl.Location = new Point(720, 150);
            TypeLbl.Name = "TypeLbl";
            TypeLbl.Size = new Size(42, 21);
            TypeLbl.TabIndex = 1;
            TypeLbl.Text = "Type";
            // 
            // WeightLbl
            // 
            WeightLbl.AutoSize = true;
            WeightLbl.Location = new Point(720, 209);
            WeightLbl.Name = "WeightLbl";
            WeightLbl.Size = new Size(82, 21);
            WeightLbl.TabIndex = 2;
            WeightLbl.Text = "Weight (g)";
            // 
            // KcalLbl
            // 
            KcalLbl.AutoSize = true;
            KcalLbl.Location = new Point(720, 265);
            KcalLbl.Name = "KcalLbl";
            KcalLbl.Size = new Size(88, 21);
            KcalLbl.TabIndex = 3;
            KcalLbl.Text = "Kcal (100g)";
            // 
            // PriceLbl
            // 
            PriceLbl.AutoSize = true;
            PriceLbl.Location = new Point(720, 317);
            PriceLbl.Name = "PriceLbl";
            PriceLbl.Size = new Size(94, 21);
            PriceLbl.TabIndex = 4;
            PriceLbl.Text = "Price (100g)";
            // 
            // PricePer100gNum
            // 
            PricePer100gNum.DecimalPlaces = 2;
            PricePer100gNum.Location = new Point(875, 315);
            PricePer100gNum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            PricePer100gNum.Name = "PricePer100gNum";
            PricePer100gNum.Size = new Size(248, 29);
            PricePer100gNum.TabIndex = 13;
            PricePer100gNum.ThousandsSeparator = true;
            // 
            // WeightNum
            // 
            WeightNum.DecimalPlaces = 2;
            WeightNum.Location = new Point(875, 207);
            WeightNum.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            WeightNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            WeightNum.Name = "WeightNum";
            WeightNum.Size = new Size(248, 29);
            WeightNum.TabIndex = 11;
            WeightNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // KcalPer100gNum
            // 
            KcalPer100gNum.DecimalPlaces = 2;
            KcalPer100gNum.Location = new Point(875, 263);
            KcalPer100gNum.Maximum = new decimal(new int[] { 900, 0, 0, 0 });
            KcalPer100gNum.Name = "KcalPer100gNum";
            KcalPer100gNum.Size = new Size(248, 29);
            KcalPer100gNum.TabIndex = 12;
            // 
            // TypeTxt
            // 
            TypeTxt.Location = new Point(875, 147);
            TypeTxt.Name = "TypeTxt";
            TypeTxt.Size = new Size(248, 29);
            TypeTxt.TabIndex = 10;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(875, 86);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(248, 29);
            NameTxt.TabIndex = 9;
            // 
            // AddToFridgeBtn
            // 
            AddToFridgeBtn.FlatAppearance.BorderSize = 0;
            AddToFridgeBtn.FlatStyle = FlatStyle.Flat;
            AddToFridgeBtn.Location = new Point(720, 403);
            AddToFridgeBtn.Name = "AddToFridgeBtn";
            AddToFridgeBtn.Size = new Size(403, 39);
            AddToFridgeBtn.TabIndex = 14;
            AddToFridgeBtn.Text = "Add to fridge";
            AddToFridgeBtn.UseVisualStyleBackColor = true;
            AddToFridgeBtn.Click += AddToFridgeBtn_Click;
            // 
            // IngredientsGrid
            // 
            IngredientsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IngredientsGrid.Location = new Point(24, 86);
            IngredientsGrid.Name = "IngredientsGrid";
            IngredientsGrid.Size = new Size(645, 401);
            IngredientsGrid.TabIndex = 15;
            IngredientsGrid.CellClick += IngredientsGrid_CellClick;
            // 
            // SearchTxt
            // 
            SearchTxt.Location = new Point(24, 48);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.PlaceholderText = "Type ingredient name";
            SearchTxt.Size = new Size(645, 29);
            SearchTxt.TabIndex = 17;
            SearchTxt.TextChanged += SearchTxt_TextChanged;
            // 
            // ClearFieldsBtn
            // 
            ClearFieldsBtn.FlatAppearance.BorderSize = 0;
            ClearFieldsBtn.FlatStyle = FlatStyle.Flat;
            ClearFieldsBtn.Location = new Point(720, 448);
            ClearFieldsBtn.Name = "ClearFieldsBtn";
            ClearFieldsBtn.Size = new Size(403, 39);
            ClearFieldsBtn.TabIndex = 18;
            ClearFieldsBtn.Text = "Clear all Fields";
            ClearFieldsBtn.UseVisualStyleBackColor = true;
            ClearFieldsBtn.Click += ClearFieldsBtn_Click;
            // 
            // EditIngredientBtn
            // 
            EditIngredientBtn.FlatAppearance.BorderSize = 0;
            EditIngredientBtn.FlatStyle = FlatStyle.Flat;
            EditIngredientBtn.Location = new Point(720, 403);
            EditIngredientBtn.Name = "EditIngredientBtn";
            EditIngredientBtn.Size = new Size(403, 39);
            EditIngredientBtn.TabIndex = 19;
            EditIngredientBtn.Text = "Edit Ingredient";
            EditIngredientBtn.UseVisualStyleBackColor = true;
            EditIngredientBtn.Visible = false;
            EditIngredientBtn.Click += EditIngredientBtn_Click;
            // 
            // RightPanel
            // 
            RightPanel.Location = new Point(675, 0);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(497, 527);
            RightPanel.TabIndex = 0;
            // 
            // LeftPanel
            // 
            LeftPanel.Location = new Point(-2, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(678, 527);
            LeftPanel.TabIndex = 0;
            // 
            // IngredientsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 527);
            Controls.Add(EditIngredientBtn);
            Controls.Add(ClearFieldsBtn);
            Controls.Add(SearchTxt);
            Controls.Add(IngredientsGrid);
            Controls.Add(AddToFridgeBtn);
            Controls.Add(NameTxt);
            Controls.Add(TypeTxt);
            Controls.Add(KcalPer100gNum);
            Controls.Add(WeightNum);
            Controls.Add(PricePer100gNum);
            Controls.Add(PriceLbl);
            Controls.Add(KcalLbl);
            Controls.Add(WeightLbl);
            Controls.Add(TypeLbl);
            Controls.Add(NameLbl);
            Controls.Add(LeftPanel);
            Controls.Add(RightPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "IngredientsForm";
            Text = "My fridge";
            FormClosing += IngredientsForm_FormClosing;
            Load += IngredientsForm_Load;
            ((System.ComponentModel.ISupportInitialize)PricePer100gNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)WeightNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)KcalPer100gNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)IngredientsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLbl;
        private Label TypeLbl;
        private Label WeightLbl;
        private Label KcalLbl;
        private Label PriceLbl;
        private NumericUpDown PricePer100gNum;
        private NumericUpDown WeightNum;
        private NumericUpDown KcalPer100gNum;
        private TextBox TypeTxt;
        private TextBox NameTxt;
        private Button AddToFridgeBtn;
        private DataGridView IngredientsGrid;
        private TextBox SearchTxt;
        private Button ClearFieldsBtn;
        private Button EditIngredientBtn;
        private Panel RightPanel;
        private Panel LeftPanel;
    }
}