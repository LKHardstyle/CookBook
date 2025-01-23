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
            NameLbl = new Label();
            TypeLbl = new Label();
            DescriptionLbl = new Label();
            ImageLbl = new Label();
            RecipeFilterCbx = new ComboBox();
            RecipeTypesCbx = new ComboBox();
            NameTxt = new TextBox();
            AddRecipeTypeBtn = new Button();
            AddRecipeBtn = new Button();
            ClearAllFieldsBtn = new Button();
            DescriptionTxt = new RichTextBox();
            RecipePictureBox = new PictureBox();
            EditRecipeBtn = new Button();
            LeftPanel = new Panel();
            RightPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)RecipesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).BeginInit();
            RightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RecipesGrid
            // 
            RecipesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RecipesGrid.Location = new Point(29, 99);
            RecipesGrid.Name = "RecipesGrid";
            RecipesGrid.Size = new Size(915, 560);
            RecipesGrid.TabIndex = 1;
            RecipesGrid.CellClick += RecipesGrid_CellClick;
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.BackColor = Color.FromArgb(32, 45, 64);
            NameLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            NameLbl.ForeColor = Color.White;
            NameLbl.Location = new Point(962, 46);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(77, 30);
            NameLbl.TabIndex = 2;
            NameLbl.Text = "Name:";
            // 
            // TypeLbl
            // 
            TypeLbl.AutoSize = true;
            TypeLbl.BackColor = Color.FromArgb(32, 45, 64);
            TypeLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            TypeLbl.ForeColor = Color.White;
            TypeLbl.Location = new Point(962, 118);
            TypeLbl.Name = "TypeLbl";
            TypeLbl.Size = new Size(65, 30);
            TypeLbl.TabIndex = 3;
            TypeLbl.Text = "Type:";
            // 
            // DescriptionLbl
            // 
            DescriptionLbl.AutoSize = true;
            DescriptionLbl.BackColor = Color.FromArgb(32, 45, 64);
            DescriptionLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            DescriptionLbl.ForeColor = Color.White;
            DescriptionLbl.Location = new Point(962, 231);
            DescriptionLbl.Name = "DescriptionLbl";
            DescriptionLbl.Size = new Size(131, 30);
            DescriptionLbl.TabIndex = 4;
            DescriptionLbl.Text = "Description:";
            // 
            // ImageLbl
            // 
            ImageLbl.AutoSize = true;
            ImageLbl.BackColor = Color.FromArgb(32, 45, 64);
            ImageLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            ImageLbl.ForeColor = Color.White;
            ImageLbl.Location = new Point(962, 437);
            ImageLbl.Name = "ImageLbl";
            ImageLbl.Size = new Size(80, 30);
            ImageLbl.TabIndex = 5;
            ImageLbl.Text = "Image:";
            // 
            // RecipeFilterCbx
            // 
            RecipeFilterCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            RecipeFilterCbx.FormattingEnabled = true;
            RecipeFilterCbx.Location = new Point(29, 40);
            RecipeFilterCbx.Name = "RecipeFilterCbx";
            RecipeFilterCbx.Size = new Size(580, 38);
            RecipeFilterCbx.TabIndex = 7;
            RecipeFilterCbx.SelectedIndexChanged += RecipeFilterCbx_SelectedIndexChanged;
            // 
            // RecipeTypesCbx
            // 
            RecipeTypesCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            RecipeTypesCbx.FormattingEnabled = true;
            RecipeTypesCbx.Location = new Point(1098, 115);
            RecipeTypesCbx.Name = "RecipeTypesCbx";
            RecipeTypesCbx.Size = new Size(197, 38);
            RecipeTypesCbx.TabIndex = 8;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(1098, 43);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(335, 35);
            NameTxt.TabIndex = 9;
            // 
            // AddRecipeTypeBtn
            // 
            AddRecipeTypeBtn.FlatAppearance.BorderSize = 0;
            AddRecipeTypeBtn.FlatStyle = FlatStyle.Flat;
            AddRecipeTypeBtn.Location = new Point(1345, 117);
            AddRecipeTypeBtn.Name = "AddRecipeTypeBtn";
            AddRecipeTypeBtn.Size = new Size(115, 39);
            AddRecipeTypeBtn.TabIndex = 10;
            AddRecipeTypeBtn.Text = "Add";
            AddRecipeTypeBtn.UseVisualStyleBackColor = true;
            AddRecipeTypeBtn.Click += AddRecipeTypeBtn_Click;
            // 
            // AddRecipeBtn
            // 
            AddRecipeBtn.FlatAppearance.BorderSize = 0;
            AddRecipeBtn.FlatStyle = FlatStyle.Flat;
            AddRecipeBtn.Location = new Point(6, 564);
            AddRecipeBtn.Name = "AddRecipeBtn";
            AddRecipeBtn.Size = new Size(507, 50);
            AddRecipeBtn.TabIndex = 11;
            AddRecipeBtn.Text = "Add recipe";
            AddRecipeBtn.UseVisualStyleBackColor = true;
            AddRecipeBtn.Click += AddRecipeBtn_Click;
            // 
            // ClearAllFieldsBtn
            // 
            ClearAllFieldsBtn.FlatAppearance.BorderSize = 0;
            ClearAllFieldsBtn.FlatStyle = FlatStyle.Flat;
            ClearAllFieldsBtn.Location = new Point(6, 622);
            ClearAllFieldsBtn.Name = "ClearAllFieldsBtn";
            ClearAllFieldsBtn.Size = new Size(507, 50);
            ClearAllFieldsBtn.TabIndex = 13;
            ClearAllFieldsBtn.Text = "Clear all fields";
            ClearAllFieldsBtn.UseVisualStyleBackColor = true;
            ClearAllFieldsBtn.Click += ClearAllFieldsBtn_Click;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.Location = new Point(1098, 181);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(371, 136);
            DescriptionTxt.TabIndex = 14;
            DescriptionTxt.Text = "";
            // 
            // RecipePictureBox
            // 
            RecipePictureBox.InitialImage = null;
            RecipePictureBox.Location = new Point(1098, 346);
            RecipePictureBox.Name = "RecipePictureBox";
            RecipePictureBox.Size = new Size(371, 208);
            RecipePictureBox.TabIndex = 15;
            RecipePictureBox.TabStop = false;
            RecipePictureBox.Click += RecipePictureBox_Click;
            // 
            // EditRecipeBtn
            // 
            EditRecipeBtn.FlatAppearance.BorderSize = 0;
            EditRecipeBtn.FlatStyle = FlatStyle.Flat;
            EditRecipeBtn.Location = new Point(6, 564);
            EditRecipeBtn.Name = "EditRecipeBtn";
            EditRecipeBtn.Size = new Size(507, 50);
            EditRecipeBtn.TabIndex = 16;
            EditRecipeBtn.Text = "Edit recipe";
            EditRecipeBtn.UseVisualStyleBackColor = true;
            EditRecipeBtn.Click += EditRecipeBtn_Click;
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.FromArgb(45, 66, 91);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(956, 672);
            LeftPanel.TabIndex = 17;
            // 
            // RightPanel
            // 
            RightPanel.BackColor = Color.FromArgb(32, 45, 64);
            RightPanel.Controls.Add(EditRecipeBtn);
            RightPanel.Controls.Add(AddRecipeBtn);
            RightPanel.Controls.Add(ClearAllFieldsBtn);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(956, 0);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(538, 672);
            RightPanel.TabIndex = 18;
            // 
            // RecipesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 672);
            Controls.Add(RecipePictureBox);
            Controls.Add(DescriptionTxt);
            Controls.Add(AddRecipeTypeBtn);
            Controls.Add(NameTxt);
            Controls.Add(RecipeTypesCbx);
            Controls.Add(RecipeFilterCbx);
            Controls.Add(ImageLbl);
            Controls.Add(DescriptionLbl);
            Controls.Add(TypeLbl);
            Controls.Add(NameLbl);
            Controls.Add(RecipesGrid);
            Controls.Add(RightPanel);
            Controls.Add(LeftPanel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RecipesForm";
            Text = "RecipesForm";
            FormClosing += RecipesForm_FormClosing;
            Load += RecipesForm_Load;
            ((System.ComponentModel.ISupportInitialize)RecipesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).EndInit();
            RightPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView RecipesGrid;
        private Label NameLbl;
        private Label TypeLbl;
        private Label DescriptionLbl;
        private Label ImageLbl;
        private ComboBox RecipeFilterCbx;
        private ComboBox RecipeTypesCbx;
        private TextBox NameTxt;
        private Button AddRecipeTypeBtn;
        private Button AddRecipeBtn;
        private Button ClearAllFieldsBtn;
        private RichTextBox DescriptionTxt;
        private PictureBox RecipePictureBox;
        private Button EditRecipeBtn;
        private Panel LeftPanel;
        private Panel RightPanel;
    }
}