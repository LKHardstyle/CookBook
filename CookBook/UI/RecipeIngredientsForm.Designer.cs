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
            AllIngredientsLbx = new ListBox();
            RecipeIngredientsLbx = new ListBox();
            AddIngredientBtn = new Button();
            RemoveIngredientsBtn = new Button();
            AllIngredientsCustomLbx = new Assets.CustomUserControls.CustomListBox();
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
            // AllIngredientsLbx
            // 
            AllIngredientsLbx.FormattingEnabled = true;
            AllIngredientsLbx.ItemHeight = 30;
            AllIngredientsLbx.Location = new Point(30, 73);
            AllIngredientsLbx.Name = "AllIngredientsLbx";
            AllIngredientsLbx.Size = new Size(288, 454);
            AllIngredientsLbx.TabIndex = 2;
            // 
            // RecipeIngredientsLbx
            // 
            RecipeIngredientsLbx.FormattingEnabled = true;
            RecipeIngredientsLbx.ItemHeight = 30;
            RecipeIngredientsLbx.Location = new Point(373, 73);
            RecipeIngredientsLbx.Name = "RecipeIngredientsLbx";
            RecipeIngredientsLbx.Size = new Size(288, 454);
            RecipeIngredientsLbx.TabIndex = 3;
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
            AllIngredientsCustomLbx.Location = new Point(30, 607);
            AllIngredientsCustomLbx.Name = "AllIngredientsCustomLbx";
            AllIngredientsCustomLbx.Size = new Size(255, 401);
            AllIngredientsCustomLbx.TabIndex = 6;        
            // 
            // RecipeIngredientsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 1042);
            Controls.Add(AllIngredientsCustomLbx);
            Controls.Add(RemoveIngredientsBtn);
            Controls.Add(AddIngredientBtn);
            Controls.Add(RecipeIngredientsLbx);
            Controls.Add(AllIngredientsLbx);
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
        private ListBox AllIngredientsLbx;
        private ListBox RecipeIngredientsLbx;
        private Button AddIngredientBtn;
        private Button RemoveIngredientsBtn;
        private Assets.CustomUserControls.CustomListBox AllIngredientsCustomLbx;
    }
}