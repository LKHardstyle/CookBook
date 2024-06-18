﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookBook.ViewModels;

namespace CookBook.Assets.CustomUserControls
{
    public partial class CustomListBox : UserControl
    {
        public event Action<ListBoxItemVM> OnSelectedItemChanged;
        public ListBoxItemVM SelectedItem { get; set; }
        public CustomListBox()
        {
            InitializeComponent();
            CustomLbx.DrawMode = DrawMode.OwnerDrawVariable;           
        }

        public void setDataSource(List<ListBoxItemVM> dataSource)
        {
            CustomLbx.DataSource = dataSource;
        }

        private void CustomLbx_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                ListBox listBox = (ListBox)sender;
                var listBoxItem = ((ListBoxItemVM)listBox.Items[e.Index]);
                Font font = new Font("Century Gothic", 16, FontStyle.Regular);
                SolidBrush brush = new SolidBrush(Color.Black);
                e.DrawBackground();
                e.Graphics.DrawString(listBoxItem.Displaytext, font, brush, e.Bounds.Location);
                e.DrawFocusRectangle();
            }
        }

        private void CustomLbx_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 32;
        }

        private void CustomLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CustomLbx.SelectedIndex != -1)
            {
                SelectedItem = (ListBoxItemVM) CustomLbx.SelectedItem;
                SelectedItemChanged(SelectedItem);
            }
        }
        private void SelectedItemChanged(ListBoxItemVM? selecteditem)
        {
            //OnSelectedItemChanged?.Invoke(SelectedItem);
            if (OnSelectedItemChanged != null && selecteditem != null)
                OnSelectedItemChanged.Invoke(selecteditem);
        }
    }
}