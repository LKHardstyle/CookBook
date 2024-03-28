namespace CookBook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tb_firstname = new TextBox();
            tb_lastname = new TextBox();
            bt_greet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 50);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 30);
            label1.TabIndex = 0;
            label1.Text = "First name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 136);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 30);
            label2.TabIndex = 1;
            label2.Text = "Last name:";
            // 
            // tb_firstname
            // 
            tb_firstname.Location = new Point(227, 47);
            tb_firstname.Name = "tb_firstname";
            tb_firstname.Size = new Size(331, 35);
            tb_firstname.TabIndex = 2;
            // 
            // tb_lastname
            // 
            tb_lastname.Location = new Point(227, 136);
            tb_lastname.Name = "tb_lastname";
            tb_lastname.Size = new Size(331, 35);
            tb_lastname.TabIndex = 3;
            // 
            // bt_greet
            // 
            bt_greet.Location = new Point(227, 201);
            bt_greet.Name = "bt_greet";
            bt_greet.Size = new Size(331, 46);
            bt_greet.TabIndex = 4;
            bt_greet.Text = "Greet user";
            bt_greet.UseVisualStyleBackColor = true;
            bt_greet.Click += bt_greet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 297);
            Controls.Add(bt_greet);
            Controls.Add(tb_lastname);
            Controls.Add(tb_firstname);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_firstname;
        private TextBox tb_lastname;
        private Button bt_greet;
    }
}
