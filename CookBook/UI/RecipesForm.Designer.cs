namespace CookBook.UI
{
    partial class RecipesForm
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
            RecipesGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            RecipeFilterCbx = new ComboBox();
            RecipeTypesCbx = new ComboBox();
            NameTxt = new TextBox();
            AddRecipeTypeBtn = new Button();
            AddRecipeBtn = new Button();
            ClearAllFieldsBtn = new Button();
            DescriptionTxt = new RichTextBox();
            RecipePictureBox = new PictureBox();
            EditRecipeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)RecipesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).BeginInit();
            SuspendLayout();
            // 
            // RecipesGrid
            // 
            RecipesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RecipesGrid.Location = new Point(29, 86);
            RecipesGrid.Name = "RecipesGrid";
            RecipesGrid.Size = new Size(915, 560);
            RecipesGrid.TabIndex = 1;
            RecipesGrid.CellClick += RecipesGrid_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(962, 33);
            label1.Name = "label1";
            label1.Size = new Size(74, 30);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(962, 105);
            label2.Name = "label2";
            label2.Size = new Size(61, 30);
            label2.TabIndex = 3;
            label2.Text = "Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(962, 218);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 4;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(962, 424);
            label4.Name = "label4";
            label4.Size = new Size(76, 30);
            label4.TabIndex = 5;
            label4.Text = "Image:";
            // 
            // RecipeFilterCbx
            // 
            RecipeFilterCbx.FormattingEnabled = true;
            RecipeFilterCbx.Location = new Point(29, 27);
            RecipeFilterCbx.Name = "RecipeFilterCbx";
            RecipeFilterCbx.Size = new Size(915, 38);
            RecipeFilterCbx.TabIndex = 7;
            RecipeFilterCbx.SelectedIndexChanged += RecipeFilterCbx_SelectedIndexChanged;
            // 
            // RecipeTypesCbx
            // 
            RecipeTypesCbx.FormattingEnabled = true;
            RecipeTypesCbx.Location = new Point(1098, 102);
            RecipeTypesCbx.Name = "RecipeTypesCbx";
            RecipeTypesCbx.Size = new Size(197, 38);
            RecipeTypesCbx.TabIndex = 8;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(1098, 30);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(335, 35);
            NameTxt.TabIndex = 9;
            // 
            // AddRecipeTypeBtn
            // 
            AddRecipeTypeBtn.Location = new Point(1345, 104);
            AddRecipeTypeBtn.Name = "AddRecipeTypeBtn";
            AddRecipeTypeBtn.Size = new Size(115, 39);
            AddRecipeTypeBtn.TabIndex = 10;
            AddRecipeTypeBtn.Text = "Add";
            AddRecipeTypeBtn.UseVisualStyleBackColor = true;
            AddRecipeTypeBtn.Click += AddRecipeTypeBtn_Click;
            // 
            // AddRecipeBtn
            // 
            AddRecipeBtn.Location = new Point(962, 562);
            AddRecipeBtn.Name = "AddRecipeBtn";
            AddRecipeBtn.Size = new Size(507, 39);
            AddRecipeBtn.TabIndex = 11;
            AddRecipeBtn.Text = "Add recipe";
            AddRecipeBtn.UseVisualStyleBackColor = true;
            AddRecipeBtn.Click += AddRecipeBtn_Click;
            // 
            // ClearAllFieldsBtn
            // 
            ClearAllFieldsBtn.Location = new Point(962, 607);
            ClearAllFieldsBtn.Name = "ClearAllFieldsBtn";
            ClearAllFieldsBtn.Size = new Size(507, 39);
            ClearAllFieldsBtn.TabIndex = 13;
            ClearAllFieldsBtn.Text = "Clear all fields";
            ClearAllFieldsBtn.UseVisualStyleBackColor = true;
            ClearAllFieldsBtn.Click += ClearAllFieldsBtn_Click;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.Location = new Point(1098, 168);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(371, 136);
            DescriptionTxt.TabIndex = 14;
            DescriptionTxt.Text = "";
            // 
            // RecipePictureBox
            // 
            RecipePictureBox.InitialImage = null;
            RecipePictureBox.Location = new Point(1098, 333);
            RecipePictureBox.Name = "RecipePictureBox";
            RecipePictureBox.Size = new Size(371, 208);
            RecipePictureBox.TabIndex = 15;
            RecipePictureBox.TabStop = false;
            RecipePictureBox.Click += RecipePictureBox_Click;
            // 
            // EditRecipeBtn
            // 
            EditRecipeBtn.Location = new Point(962, 562);
            EditRecipeBtn.Name = "EditRecipeBtn";
            EditRecipeBtn.Size = new Size(507, 39);
            EditRecipeBtn.TabIndex = 16;
            EditRecipeBtn.Text = "Edit recipe";
            EditRecipeBtn.UseVisualStyleBackColor = true;
            EditRecipeBtn.Click += EditRecipeBtn_Click;
            // 
            // RecipesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 672);
            Controls.Add(EditRecipeBtn);
            Controls.Add(RecipePictureBox);
            Controls.Add(DescriptionTxt);
            Controls.Add(ClearAllFieldsBtn);
            Controls.Add(AddRecipeBtn);
            Controls.Add(AddRecipeTypeBtn);
            Controls.Add(NameTxt);
            Controls.Add(RecipeTypesCbx);
            Controls.Add(RecipeFilterCbx);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RecipesGrid);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RecipesForm";
            Text = "RecipesForm";
            Load += RecipesForm_Load;
            ((System.ComponentModel.ISupportInitialize)RecipesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView RecipesGrid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox RecipeFilterCbx;
        private ComboBox RecipeTypesCbx;
        private TextBox NameTxt;
        private Button AddRecipeTypeBtn;
        private Button AddRecipeBtn;
        private Button ClearAllFieldsBtn;
        private RichTextBox DescriptionTxt;
        private PictureBox RecipePictureBox;
        private Button EditRecipeBtn;
    }
}