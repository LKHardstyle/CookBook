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
            label1 = new Label();
            label2 = new Label();
            AddIngredientBtn = new Button();
            RemoveIngredientsBtn = new Button();
            AllIngredientsCustomLbx = new Assets.CustomUserControls.CustomListBox();
            RecipeIngredientsCustomLbx = new Assets.CustomUserControls.CustomListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 24);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 0;
            label1.Text = "All Ingredients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 24);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 30);
            label2.TabIndex = 1;
            label2.Text = "Recipe Ingredients";
            // 
            // AddIngredientBtn
            // 
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
            // RecipeIngredientsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 634);
            Controls.Add(RecipeIngredientsCustomLbx);
            Controls.Add(AllIngredientsCustomLbx);
            Controls.Add(RemoveIngredientsBtn);
            Controls.Add(AddIngredientBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RecipeIngredientsForm";
            Text = "RecipeIngredientsForm";
            Load += RecipeIngredientsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button AddIngredientBtn;
        private Button RemoveIngredientsBtn;
        private Assets.CustomUserControls.CustomListBox AllIngredientsCustomLbx;
        private Assets.CustomUserControls.CustomListBox RecipeIngredientsCustomLbx;
    }
}