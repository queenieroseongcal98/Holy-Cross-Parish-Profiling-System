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
    public partial class CertificateForm : Form
    {
        public CertificateForm()
        {
            InitializeComponent();
        }

        private void btnDispose_Click(object sender, EventArgs e)
        {

        }


        private void btnDispose_Click_2(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBaptismal_Click(object sender, EventArgs e)
        {
            new GenerateBaptismalCert().Show();
            this.Hide();
        }

        private void btnCommunion_Click(object sender, EventArgs e)
        {
            new GenerateCommunion().Show();
            this.Hide();
        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            new GenerateConfirmation().Show();
            this.Hide();
        }

        private void btnMarriage_Click(object sender, EventArgs e)
        {
            new generateMarriage().Show();
            this.Hide();
        }
    }
}
