﻿namespace CookBook.UI
{
    partial class HomeForm
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
            FridgeBtn = new Button();
            RecipesBtn = new Button();
            FoodManagerBtn = new Button();
            SuspendLayout();
            // 
            // FridgeBtn
            // 
            FridgeBtn.Location = new Point(60, 46);
            FridgeBtn.Name = "FridgeBtn";
            FridgeBtn.Size = new Size(248, 57);
            FridgeBtn.TabIndex = 0;
            FridgeBtn.Text = "Fridge";
            FridgeBtn.UseVisualStyleBackColor = true;
            FridgeBtn.Click += FridgeBtn_Click;
            // 
            // RecipesBtn
            // 
            RecipesBtn.Location = new Point(60, 142);
            RecipesBtn.Name = "RecipesBtn";
            RecipesBtn.Size = new Size(248, 57);
            RecipesBtn.TabIndex = 1;
            RecipesBtn.Text = "Recipes";
            RecipesBtn.UseVisualStyleBackColor = true;
            RecipesBtn.Click += RecipesBtn_Click;
            // 
            // FoodManagerBtn
            // 
            FoodManagerBtn.Location = new Point(60, 247);
            FoodManagerBtn.Name = "FoodManagerBtn";
            FoodManagerBtn.Size = new Size(248, 57);
            FoodManagerBtn.TabIndex = 2;
            FoodManagerBtn.Text = "Food Manager";
            FoodManagerBtn.UseVisualStyleBackColor = true;
            FoodManagerBtn.Click += FoodManagerBtn_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 435);
            Controls.Add(FoodManagerBtn);
            Controls.Add(RecipesBtn);
            Controls.Add(FridgeBtn);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "HomeForm";
            Text = "HomeForm";
            ResumeLayout(false);
        }

        #endregion

        private Button FridgeBtn;
        private Button RecipesBtn;
        private Button FoodManagerBtn;
    }
}