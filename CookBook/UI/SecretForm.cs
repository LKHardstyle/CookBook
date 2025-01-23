using CookBook.Services;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
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
    public partial class SecretForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        StyleWatcher _styleWatcher;
        public SecretForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            PreparedRecipesLbl.Text = "Prepared recipes: " + TotalRecipesCounter.Instance.PreparedRecipesCounter.ToString();

            _styleWatcher = _serviceProvider.GetRequiredService<StyleWatcher>();
            _styleWatcher.onStyleChanged += OnStyleChanged;

            ApplyStyles(StyleWatcher.CurrentStyle);
        }

        public void ApplyStyles(int? theme = 1)
        {
            JObject themeConfig = ConfigurationManager.LoadThemeConfig(theme);

            this.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBgr"]);

            PreparedRecipesLbl.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBgr"]);
            PreparedRecipesLbl.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);

            Theme1Btn.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnBgr"]);
            Theme2Btn.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnBgr"]);
            Theme3Btn.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnBgr"]);
            Theme4Btn.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnBgr"]);

            Theme1Btn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);
            Theme2Btn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);
            Theme3Btn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);
            Theme4Btn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);
        }

        private void Theme1Btn_Click(object sender, EventArgs e)
        {
            StyleWatcher.CurrentStyle = 1;
        }

        private void Theme2Btn_Click(object sender, EventArgs e)
        {
            StyleWatcher.CurrentStyle = 2;
        }

        private void Theme3Btn_Click(object sender, EventArgs e)
        {
            StyleWatcher.CurrentStyle = 3;
        }

        private void Theme4Btn_Click(object sender, EventArgs e)
        {
            StyleWatcher.CurrentStyle = 4;
        }
        private void OnStyleChanged(int style)
        {
            Invoke(new Action(() =>
            {
                ApplyStyles(style);
            }));
        }

        private void SecretForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _styleWatcher.onStyleChanged -= OnStyleChanged;
        }
    }
}