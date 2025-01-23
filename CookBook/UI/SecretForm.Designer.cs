namespace CookBook.UI
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
            Theme1Btn = new Button();
            Theme2Btn = new Button();
            Theme3Btn = new Button();
            Theme4Btn = new Button();
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
            // Theme1Btn
            // 
            Theme1Btn.Location = new Point(21, 136);
            Theme1Btn.Name = "Theme1Btn";
            Theme1Btn.Size = new Size(150, 38);
            Theme1Btn.TabIndex = 20;
            Theme1Btn.Text = "Theme 1";
            Theme1Btn.UseVisualStyleBackColor = true;
            Theme1Btn.Click += Theme1Btn_Click;
            // 
            // Theme2Btn
            // 
            Theme2Btn.Location = new Point(21, 204);
            Theme2Btn.Name = "Theme2Btn";
            Theme2Btn.Size = new Size(150, 38);
            Theme2Btn.TabIndex = 21;
            Theme2Btn.Text = "Theme 2";
            Theme2Btn.UseVisualStyleBackColor = true;
            Theme2Btn.Click += Theme2Btn_Click;
            // 
            // Theme3Btn
            // 
            Theme3Btn.Location = new Point(21, 270);
            Theme3Btn.Name = "Theme3Btn";
            Theme3Btn.Size = new Size(150, 38);
            Theme3Btn.TabIndex = 22;
            Theme3Btn.Text = "Theme 3";
            Theme3Btn.UseVisualStyleBackColor = true;
            Theme3Btn.Click += Theme3Btn_Click;
            // 
            // Theme4Btn
            // 
            Theme4Btn.Location = new Point(21, 335);
            Theme4Btn.Name = "Theme4Btn";
            Theme4Btn.Size = new Size(150, 38);
            Theme4Btn.TabIndex = 23;
            Theme4Btn.Text = "Theme 4";
            Theme4Btn.UseVisualStyleBackColor = true;
            Theme4Btn.Click += Theme4Btn_Click;
            // 
            // SecretForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 690);
            Controls.Add(Theme4Btn);
            Controls.Add(Theme3Btn);
            Controls.Add(Theme2Btn);
            Controls.Add(Theme1Btn);
            Controls.Add(PreparedRecipesLbl);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "SecretForm";
            Text = "SecretForm";
            FormClosing += SecretForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PreparedRecipesLbl;
        private Button Theme1Btn;
        private Button Theme2Btn;
        private Button Theme3Btn;
        private Button Theme4Btn;
    }
}