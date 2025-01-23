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
    public partial class AmountForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        StyleWatcher _styleWatcher;
        public decimal Amount { get; set; }
        public AmountForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

            AmountNum.Value = 0;

            _styleWatcher = _serviceProvider.GetRequiredService<StyleWatcher>();
            _styleWatcher.onStyleChanged += OnStyleChanged;

            ApplyStyles(StyleWatcher.CurrentStyle);
        }
        private void OnStyleChanged(int style)
        {
            Invoke(new Action(() =>
            {
                ApplyStyles(style);
            }));
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Amount = Math.Abs(AmountNum.Value);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplyStyles(int? theme = 1)
        {
            JObject themeConfig = ConfigurationManager.LoadThemeConfig(theme);

            Panel.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBgr"]);

            EnterAmountLbl.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBgr"]);
            EnterAmountLbl.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryFgr"]);

            OkBtn.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnBgr"]);
            CancelBtn.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBtnBgr"]);

            OkBtn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);
            CancelBtn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);
        }

        private void AmountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _styleWatcher.onStyleChanged -= OnStyleChanged;
        }
    }
}
