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
    public partial class GenerateBaptismalCert : Form
    {
        public GenerateBaptismalCert()
        {
            InitializeComponent();
        }

        private void GenerateBaptismalCert_Load(object sender, EventArgs e)
        {
          
        }

        private void btnInputSponsors_Click(object sender, EventArgs e)
        {
            new InputSponsors().Show();
            this.Hide();
        }

        private void tbDayBaptismal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateCert_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
