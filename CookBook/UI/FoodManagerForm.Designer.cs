namespace CookBook.UI
{
    partial class FoodManagerForm
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
            components = new System.ComponentModel.Container();
            LeftPanel = new Panel();
            PrepareFoodBtn = new Button();
            CreateShoppingListBtn = new Button();
            RecipesLbx = new Assets.CustomUserControls.CustomListBox();
            UnavailableBtn = new Button();
            AvailableBtn = new Button();
            RightPanel = new Panel();
            NotificationIcon = new PictureBox();
            IngredientsLbx = new Assets.CustomUserControls.CustomListBox();
            DescriptionTxt = new RichTextBox();
            RecipePicture = new PictureBox();
            TotalPriceLbl = new Label();
            TotalCaloriesLbl = new Label();
            PriceLbl = new Label();
            CaloriesLbl = new Label();
            IngredientsLbl = new Label();
            notifcationTooltip = new ToolTip(components);
            LeftPanel.SuspendLayout();
            RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NotificationIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecipePicture).BeginInit();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.Controls.Add(PrepareFoodBtn);
            LeftPanel.Controls.Add(CreateShoppingListBtn);
            LeftPanel.Controls.Add(RecipesLbx);
            LeftPanel.Controls.Add(UnavailableBtn);
            LeftPanel.Controls.Add(AvailableBtn);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(435, 908);
            LeftPanel.TabIndex = 0;
            // 
            // PrepareFoodBtn
            // 
            PrepareFoodBtn.FlatAppearance.BorderSize = 0;
            PrepareFoodBtn.FlatStyle = FlatStyle.Flat;
            PrepareFoodBtn.Location = new Point(12, 787);
            PrepareFoodBtn.Name = "PrepareFoodBtn";
            PrepareFoodBtn.Size = new Size(417, 53);
            PrepareFoodBtn.TabIndex = 4;
            PrepareFoodBtn.Text = "Prepare Food";
            PrepareFoodBtn.UseVisualStyleBackColor = true;
            PrepareFoodBtn.Click += PrepareFoodBtn_Click;
            // 
            // CreateShoppingListBtn
            // 
            CreateShoppingListBtn.FlatAppearance.BorderSize = 0;
            CreateShoppingListBtn.FlatStyle = FlatStyle.Flat;
            CreateShoppingListBtn.Location = new Point(12, 787);
            CreateShoppingListBtn.Name = "CreateShoppingListBtn";
            CreateShoppingListBtn.Size = new Size(417, 53);
            CreateShoppingListBtn.TabIndex = 3;
            CreateShoppingListBtn.Text = "Create shopping list";
            CreateShoppingListBtn.UseVisualStyleBackColor = true;
            CreateShoppingListBtn.Click += CreateShoppingListBtn_Click;
            // 
            // RecipesLbx
            // 
            RecipesLbx.Location = new Point(12, 99);
            RecipesLbx.Name = "RecipesLbx";
            RecipesLbx.SelectedItem = null;
            RecipesLbx.Size = new Size(417, 643);
            RecipesLbx.TabIndex = 2;
            // 
            // UnavailableBtn
            // 
            UnavailableBtn.FlatAppearance.BorderSize = 0;
            UnavailableBtn.FlatStyle = FlatStyle.Flat;
            UnavailableBtn.Location = new Point(228, 17);
            UnavailableBtn.Name = "UnavailableBtn";
            UnavailableBtn.Size = new Size(201, 53);
            UnavailableBtn.TabIndex = 1;
            UnavailableBtn.Text = "Unavailable";
            UnavailableBtn.UseVisualStyleBackColor = true;
            UnavailableBtn.Click += UnavailableBtn_Click;
            // 
            // AvailableBtn
            // 
            AvailableBtn.FlatAppearance.BorderSize = 0;
            AvailableBtn.FlatStyle = FlatStyle.Flat;
            AvailableBtn.Location = new Point(12, 17);
            AvailableBtn.Name = "AvailableBtn";
            AvailableBtn.Size = new Size(201, 53);
            AvailableBtn.TabIndex = 0;
            AvailableBtn.Text = "Available";
            AvailableBtn.UseVisualStyleBackColor = true;
            AvailableBtn.Click += AvailableBtn_Click;
            // 
            // RightPanel
            // 
            RightPanel.Controls.Add(NotificationIcon);
            RightPanel.Controls.Add(IngredientsLbx);
            RightPanel.Controls.Add(DescriptionTxt);
            RightPanel.Controls.Add(RecipePicture);
            RightPanel.Controls.Add(TotalPriceLbl);
            RightPanel.Controls.Add(TotalCaloriesLbl);
            RightPanel.Controls.Add(PriceLbl);
            RightPanel.Controls.Add(CaloriesLbl);
            RightPanel.Controls.Add(IngredientsLbl);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(435, 0);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(936, 908);
            RightPanel.TabIndex = 1;
            // 
            // NotificationIcon
            // 
            NotificationIcon.Image = Properties.Resources.notification;
            NotificationIcon.Location = new Point(446, 33);
            NotificationIcon.Name = "NotificationIcon";
            NotificationIcon.Size = new Size(60, 60);
            NotificationIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            NotificationIcon.TabIndex = 8;
            NotificationIcon.TabStop = false;
            NotificationIcon.MouseEnter += NotificationIcon_MouseEnter;
            NotificationIcon.MouseLeave += NotificationIcon_MouseLeave;
            // 
            // IngredientsLbx
            // 
            IngredientsLbx.Location = new Point(17, 99);
            IngredientsLbx.Name = "IngredientsLbx";
            IngredientsLbx.SelectedItem = null;
            IngredientsLbx.Size = new Size(489, 498);
            IngredientsLbx.TabIndex = 7;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.Location = new Point(17, 622);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(489, 270);
            DescriptionTxt.TabIndex = 6;
            DescriptionTxt.Text = "";
            // 
            // RecipePicture
            // 
            RecipePicture.Location = new Point(527, 622);
            RecipePicture.Name = "RecipePicture";
            RecipePicture.Size = new Size(401, 270);
            RecipePicture.TabIndex = 5;
            RecipePicture.TabStop = false;
            // 
            // TotalPriceLbl
            // 
            TotalPriceLbl.AutoSize = true;
            TotalPriceLbl.Location = new Point(687, 98);
            TotalPriceLbl.Name = "TotalPriceLbl";
            TotalPriceLbl.Size = new Size(21, 30);
            TotalPriceLbl.TabIndex = 4;
            TotalPriceLbl.Text = "/";
            // 
            // TotalCaloriesLbl
            // 
            TotalCaloriesLbl.AutoSize = true;
            TotalCaloriesLbl.Location = new Point(687, 40);
            TotalCaloriesLbl.Name = "TotalCaloriesLbl";
            TotalCaloriesLbl.Size = new Size(21, 30);
            TotalCaloriesLbl.TabIndex = 3;
            TotalCaloriesLbl.Text = "/";
            // 
            // PriceLbl
            // 
            PriceLbl.AutoSize = true;
            PriceLbl.Location = new Point(527, 98);
            PriceLbl.Name = "PriceLbl";
            PriceLbl.Size = new Size(113, 30);
            PriceLbl.TabIndex = 2;
            PriceLbl.Text = "Total price:";
            // 
            // CaloriesLbl
            // 
            CaloriesLbl.AutoSize = true;
            CaloriesLbl.Location = new Point(527, 40);
            CaloriesLbl.Name = "CaloriesLbl";
            CaloriesLbl.Size = new Size(138, 30);
            CaloriesLbl.TabIndex = 1;
            CaloriesLbl.Text = "Total calories:";
            // 
            // IngredientsLbl
            // 
            IngredientsLbl.AutoSize = true;
            IngredientsLbl.Location = new Point(17, 40);
            IngredientsLbl.Name = "IngredientsLbl";
            IngredientsLbl.Size = new Size(117, 30);
            IngredientsLbl.TabIndex = 0;
            IngredientsLbl.Text = "Ingredients";
            // 
            // FoodManagerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 908);
            Controls.Add(RightPanel);
            Controls.Add(LeftPanel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FoodManagerForm";
            Text = "FoodManagerForm";
            FormClosing += FoodManagerForm_FormClosing;
            Load += FoodManagerForm_Load;
            LeftPanel.ResumeLayout(false);
            RightPanel.ResumeLayout(false);
            RightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NotificationIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecipePicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftPanel;
        private Assets.CustomUserControls.CustomListBox RecipesLbx;
        private Button UnavailableBtn;
        private Button AvailableBtn;
        private Panel RightPanel;
        private Button PrepareFoodBtn;
        private Button CreateShoppingListBtn;
        private RichTextBox DescriptionTxt;
        private PictureBox RecipePicture;
        private Label TotalPriceLbl;
        private Label TotalCaloriesLbl;
        private Label PriceLbl;
        private Label CaloriesLbl;
        private Label IngredientsLbl;
        private Assets.CustomUserControls.CustomListBox IngredientsLbx;
        private PictureBox NotificationIcon;
        private ToolTip notifcationTooltip;
    }
}