using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolyCrossParishDesktopApplication
{
    public partial class inputChildren : Form
    {
        public inputChildren()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LbChildren.Items.Add(tbInput.Text);
            tbInput.Text = "";
            tbInput.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (LbChildren.SelectedIndex != -1)
            {
                LbChildren.Items.RemoveAt(LbChildren.SelectedIndex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LbChildren.Items.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new AddingNewFaithful().Show();
            this.Hide();
        }
    }
}
