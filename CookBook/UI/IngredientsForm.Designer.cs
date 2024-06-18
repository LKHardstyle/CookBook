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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)PricePer100gNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WeightNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KcalPer100gNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IngredientsGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(720, 89);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(720, 150);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(720, 209);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 2;
            label3.Text = "Weight (g)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(720, 265);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 3;
            label4.Text = "Kcal (100g)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(720, 317);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 4;
            label5.Text = "Price (100g)";
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
            EditIngredientBtn.Location = new Point(720, 403);
            EditIngredientBtn.Name = "EditIngredientBtn";
            EditIngredientBtn.Size = new Size(403, 39);
            EditIngredientBtn.TabIndex = 19;
            EditIngredientBtn.Text = "Edit Ingredient";
            EditIngredientBtn.UseVisualStyleBackColor = true;
            EditIngredientBtn.Visible = false;
            EditIngredientBtn.Click += EditIngredientBtn_Click;
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
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "IngredientsForm";
            Text = "My fridge";
            Load += IngredientsForm_Load;
            ((System.ComponentModel.ISupportInitialize)PricePer100gNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)WeightNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)KcalPer100gNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)IngredientsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
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
    }
}