﻿using Newtonsoft.Json.Linq;
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
        public decimal Amount { get; set; }
        public AmountForm()
        {            
            InitializeComponent();
            AmountNum.Value = 0;

            ApplyStyles();
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

        private void ApplyStyles()
        {
            JObject themeConfig = ConfigurationManager.LoadThemeConfig();

            Panel.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBgr"]);

            EnterAmountLbl.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBgr"]);
            EnterAmountLbl.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryFgr"]);

            OkBtn.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnBgr"]);
            CancelBtn.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBtnBgr"]);
            
            OkBtn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);
            CancelBtn.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]);
        }
    }
}
