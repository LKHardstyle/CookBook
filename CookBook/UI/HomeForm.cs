using CookBook.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.UI
{
    public partial class HomeForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        DesktopFileWatcher _desktopFileWatcher;
        public HomeForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

            _desktopFileWatcher = _serviceProvider.GetRequiredService<DesktopFileWatcher>();
            _desktopFileWatcher.onFileStatusChange += OnFileStatusChanged;

            NotificationIcon.Visible = DesktopFileWatcher.CurrentFileStatus;
           
        }
        private void OnFileStatusChanged(bool fileExists)
        {
            Invoke(new Action(() =>
            {
                NotificationIcon.Visible = fileExists;
            }));
        }

        private void FridgeBtn_Click(object sender, EventArgs e)
        {
            //IngredientsForm form = _serviceProvider.GetRequiredService<IngredientsForm>();
            ShowForm(_serviceProvider.GetRequiredService<IngredientsForm>());
        }

        private void RecipesBtn_Click(object sender, EventArgs e)
        {
            //RecipesForm form = _serviceProvider.GetRequiredService<RecipesForm>();
            ShowForm(_serviceProvider.GetRequiredService<RecipesForm>());
        }

        private void FoodManagerBtn_Click(object sender, EventArgs e)
        {
            //FoodManagerForm form = _serviceProvider.GetRequiredService<FoodManagerForm>();
            ShowForm(_serviceProvider.GetRequiredService<FoodManagerForm>());
        }
        
        private void ShowForm(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.ShowDialog();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.S)
            {
                SecretForm form = _serviceProvider.GetRequiredService<SecretForm>();
                ShowForm(form);

                return true;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
