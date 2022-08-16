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
    public partial class InputSponsors : Form
    {
        public InputSponsors()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(lbSponsors.SelectedIndex != -1)
            {
                lbSponsors.Items.RemoveAt(lbSponsors.SelectedIndex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbSponsors.Items.Add(tbInput.Text);
            tbInput.Text = "";
            tbInput.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbSponsors.Items.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new GenerateBaptismalCert().Show();
            this.Hide();
        }
    }
}
