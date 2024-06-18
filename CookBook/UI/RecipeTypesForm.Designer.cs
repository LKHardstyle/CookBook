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
            RecipeTypesLbx = new ListBox();
            label1 = new Label();
            AddRecipeTypeBtn = new Button();
            SuspendLayout();
            // 
            // NewTypeTxt
            // 
            NewTypeTxt.Location = new Point(87, 21);
            NewTypeTxt.Name = "NewTypeTxt";
            NewTypeTxt.Size = new Size(321, 35);
            NewTypeTxt.TabIndex = 0;
            // 
            // RecipeTypesLbx
            // 
            RecipeTypesLbx.FormattingEnabled = true;
            RecipeTypesLbx.ItemHeight = 30;
            RecipeTypesLbx.Location = new Point(13, 73);
            RecipeTypesLbx.Name = "RecipeTypesLbx";
            RecipeTypesLbx.Size = new Size(395, 394);
            RecipeTypesLbx.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 24);
            label1.Name = "label1";
            label1.Size = new Size(61, 30);
            label1.TabIndex = 2;
            label1.Text = "Type:";
            // 
            // AddRecipeTypeBtn
            // 
            AddRecipeTypeBtn.Location = new Point(12, 509);
            AddRecipeTypeBtn.Name = "AddRecipeTypeBtn";
            AddRecipeTypeBtn.Size = new Size(396, 41);
            AddRecipeTypeBtn.TabIndex = 3;
            AddRecipeTypeBtn.Text = "Add";
            AddRecipeTypeBtn.UseVisualStyleBackColor = true;
            AddRecipeTypeBtn.Click += AddRecipeTypeBtn_Click;
            // 
            // RecipeTypesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 589);
            Controls.Add(AddRecipeTypeBtn);
            Controls.Add(label1);
            Controls.Add(RecipeTypesLbx);
            Controls.Add(NewTypeTxt);
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
        private ListBox RecipeTypesLbx;
        private Label label1;
        private Button AddRecipeTypeBtn;
    }
}