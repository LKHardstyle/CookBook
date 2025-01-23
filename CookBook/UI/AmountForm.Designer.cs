namespace CookBook.UI
{
    partial class AmountForm
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
            EnterAmountLbl = new Label();
            OkBtn = new Button();
            CancelBtn = new Button();
            AmountNum = new NumericUpDown();
            Panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            Panel.SuspendLayout();
            SuspendLayout();
            // 
            // EnterAmountLbl
            // 
            EnterAmountLbl.AutoSize = true;
            EnterAmountLbl.Location = new Point(10, 18);
            EnterAmountLbl.Margin = new Padding(5, 0, 5, 0);
            EnterAmountLbl.Name = "EnterAmountLbl";
            EnterAmountLbl.Size = new Size(147, 30);
            EnterAmountLbl.TabIndex = 0;
            EnterAmountLbl.Text = "Enter Amount:";
            // 
            // OkBtn
            // 
            OkBtn.FlatAppearance.BorderSize = 0;
            OkBtn.FlatStyle = FlatStyle.Flat;
            OkBtn.Location = new Point(8, 136);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(132, 40);
            OkBtn.TabIndex = 1;
            OkBtn.Text = "Ok";
            OkBtn.UseVisualStyleBackColor = true;
            OkBtn.Click += OkBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.Location = new Point(269, 136);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(132, 40);
            CancelBtn.TabIndex = 2;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(8, 66);
            AmountNum.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(393, 35);
            AmountNum.TabIndex = 3;
            // 
            // Panel
            // 
            Panel.Controls.Add(AmountNum);
            Panel.Controls.Add(CancelBtn);
            Panel.Controls.Add(OkBtn);
            Panel.Controls.Add(EnterAmountLbl);
            Panel.Location = new Point(0, 2);
            Panel.Name = "Panel";
            Panel.Size = new Size(443, 187);
            Panel.TabIndex = 4;
            // 
            // AmountForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 190);
            Controls.Add(Panel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AmountForm";
            Text = "AmountForm";
            FormClosing += AmountForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label EnterAmountLbl;
        private Button OkBtn;
        private Button CancelBtn;
        private NumericUpDown AmountNum;
        private Panel Panel;
    }
}