﻿namespace CookBook.UI
{
    partial class SecretForm
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
            PreparedRecipesLbl = new Label();
            SuspendLayout();
            // 
            // PreparedRecipesLbl
            // 
            PreparedRecipesLbl.AutoSize = true;
            PreparedRecipesLbl.Location = new Point(21, 46);
            PreparedRecipesLbl.Margin = new Padding(5, 0, 5, 0);
            PreparedRecipesLbl.Name = "PreparedRecipesLbl";
            PreparedRecipesLbl.Size = new Size(71, 30);
            PreparedRecipesLbl.TabIndex = 18;
            PreparedRecipesLbl.Text = "label5";
            // 
            // SecretForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 690);
            Controls.Add(PreparedRecipesLbl);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "SecretForm";
            Text = "SecretForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PreparedRecipesLbl;
    }
}