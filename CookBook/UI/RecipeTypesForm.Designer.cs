namespace CookBook.UI
{
    partial class RecipeTypesForm
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
            NewTypeTxt = new TextBox();
            TypeLbl = new Label();
            AddRecipeTypeBtn = new Button();
            RecipeTypesCustomLbx = new Assets.CustomUserControls.CustomListBox();
            Panel = new Panel();
            SuspendLayout();
            // 
            // NewTypeTxt
            // 
            NewTypeTxt.Location = new Point(79, 26);
            NewTypeTxt.Name = "NewTypeTxt";
            NewTypeTxt.Size = new Size(321, 35);
            NewTypeTxt.TabIndex = 0;
            // 
            // TypeLbl
            // 
            TypeLbl.AutoSize = true;
            TypeLbl.Location = new Point(12, 26);
            TypeLbl.Name = "TypeLbl";
            TypeLbl.Size = new Size(61, 30);
            TypeLbl.TabIndex = 2;
            TypeLbl.Text = "Type:";
            // 
            // AddRecipeTypeBtn
            // 
            AddRecipeTypeBtn.FlatAppearance.BorderSize = 0;
            AddRecipeTypeBtn.FlatStyle = FlatStyle.Flat;
            AddRecipeTypeBtn.Location = new Point(12, 509);
            AddRecipeTypeBtn.Name = "AddRecipeTypeBtn";
            AddRecipeTypeBtn.Size = new Size(388, 41);
            AddRecipeTypeBtn.TabIndex = 3;
            AddRecipeTypeBtn.Text = "Add";
            AddRecipeTypeBtn.UseVisualStyleBackColor = true;
            AddRecipeTypeBtn.Click += AddRecipeTypeBtn_Click;
            // 
            // RecipeTypesCustomLbx
            // 
            RecipeTypesCustomLbx.Location = new Point(12, 79);
            RecipeTypesCustomLbx.Name = "RecipeTypesCustomLbx";
            RecipeTypesCustomLbx.SelectedItem = null;
            RecipeTypesCustomLbx.Size = new Size(388, 407);
            RecipeTypesCustomLbx.TabIndex = 4;
            // 
            // Panel
            // 
            Panel.Location = new Point(-2, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(431, 591);
            Panel.TabIndex = 5;
            // 
            // RecipeTypesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 589);
            Controls.Add(RecipeTypesCustomLbx);
            Controls.Add(AddRecipeTypeBtn);
            Controls.Add(TypeLbl);
            Controls.Add(NewTypeTxt);
            Controls.Add(Panel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RecipeTypesForm";
            Text = "RecipeTypesForm";
            Load += RecipeTypesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewTypeTxt;
        private Label TypeLbl;
        private Button AddRecipeTypeBtn;
        private Assets.CustomUserControls.CustomListBox RecipeTypesCustomLbx;
        private Panel Panel;
    }
}