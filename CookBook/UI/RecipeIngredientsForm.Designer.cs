namespace CookBook.UI
{
    partial class RecipeIngredientsForm
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
            AllIngredientsLbl = new Label();
            RecipeIngredientsLbl = new Label();
            AddIngredientBtn = new Button();
            RemoveIngredientsBtn = new Button();
            AllIngredientsCustomLbx = new Assets.CustomUserControls.CustomListBox();
            RecipeIngredientsCustomLbx = new Assets.CustomUserControls.CustomListBox();
            Panel = new Panel();
            SuspendLayout();
            // 
            // AllIngredientsLbl
            // 
            AllIngredientsLbl.AutoSize = true;
            AllIngredientsLbl.Location = new Point(92, 24);
            AllIngredientsLbl.Margin = new Padding(5, 0, 5, 0);
            AllIngredientsLbl.Name = "AllIngredientsLbl";
            AllIngredientsLbl.Size = new Size(147, 30);
            AllIngredientsLbl.TabIndex = 0;
            AllIngredientsLbl.Text = "All Ingredients";
            // 
            // RecipeIngredientsLbl
            // 
            RecipeIngredientsLbl.AutoSize = true;
            RecipeIngredientsLbl.Location = new Point(435, 24);
            RecipeIngredientsLbl.Margin = new Padding(5, 0, 5, 0);
            RecipeIngredientsLbl.Name = "RecipeIngredientsLbl";
            RecipeIngredientsLbl.Size = new Size(184, 30);
            RecipeIngredientsLbl.TabIndex = 1;
            RecipeIngredientsLbl.Text = "Recipe Ingredients";
            // 
            // AddIngredientBtn
            // 
            AddIngredientBtn.FlatAppearance.BorderSize = 0;
            AddIngredientBtn.FlatStyle = FlatStyle.Flat;
            AddIngredientBtn.Location = new Point(30, 555);
            AddIngredientBtn.Name = "AddIngredientBtn";
            AddIngredientBtn.Size = new Size(288, 46);
            AddIngredientBtn.TabIndex = 4;
            AddIngredientBtn.Text = "Add Ingredient";
            AddIngredientBtn.UseVisualStyleBackColor = true;
            AddIngredientBtn.Click += AddIngredientBtn_Click;
            // 
            // RemoveIngredientsBtn
            // 
            RemoveIngredientsBtn.FlatAppearance.BorderSize = 0;
            RemoveIngredientsBtn.FlatStyle = FlatStyle.Flat;
            RemoveIngredientsBtn.Location = new Point(373, 555);
            RemoveIngredientsBtn.Name = "RemoveIngredientsBtn";
            RemoveIngredientsBtn.Size = new Size(288, 46);
            RemoveIngredientsBtn.TabIndex = 5;
            RemoveIngredientsBtn.Text = "Remove Ingredient";
            RemoveIngredientsBtn.UseVisualStyleBackColor = true;
            RemoveIngredientsBtn.Click += RemoveIngredientsBtn_Click;
            // 
            // AllIngredientsCustomLbx
            // 
            AllIngredientsCustomLbx.Location = new Point(30, 73);
            AllIngredientsCustomLbx.Name = "AllIngredientsCustomLbx";
            AllIngredientsCustomLbx.SelectedItem = null;
            AllIngredientsCustomLbx.Size = new Size(288, 454);
            AllIngredientsCustomLbx.TabIndex = 6;
            // 
            // RecipeIngredientsCustomLbx
            // 
            RecipeIngredientsCustomLbx.Location = new Point(373, 73);
            RecipeIngredientsCustomLbx.Name = "RecipeIngredientsCustomLbx";
            RecipeIngredientsCustomLbx.SelectedItem = null;
            RecipeIngredientsCustomLbx.Size = new Size(288, 454);
            RecipeIngredientsCustomLbx.TabIndex = 7;
            // 
            // Panel
            // 
            Panel.BackColor = Color.FromArgb(45, 66, 91);
            Panel.Location = new Point(2, 1);
            Panel.Name = "Panel";
            Panel.Size = new Size(707, 635);
            Panel.TabIndex = 8;
            // 
            // RecipeIngredientsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 634);
            Controls.Add(RecipeIngredientsCustomLbx);
            Controls.Add(AllIngredientsCustomLbx);
            Controls.Add(RemoveIngredientsBtn);
            Controls.Add(AddIngredientBtn);
            Controls.Add(RecipeIngredientsLbl);
            Controls.Add(AllIngredientsLbl);
            Controls.Add(Panel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RecipeIngredientsForm";
            Text = "RecipeIngredientsForm";
            Load += RecipeIngredientsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AllIngredientsLbl;
        private Label RecipeIngredientsLbl;
        private Button AddIngredientBtn;
        private Button RemoveIngredientsBtn;
        private Assets.CustomUserControls.CustomListBox AllIngredientsCustomLbx;
        private Assets.CustomUserControls.CustomListBox RecipeIngredientsCustomLbx;
        private Panel Panel;
    }
}