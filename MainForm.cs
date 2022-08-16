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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard f = new dashboard();
            f.TopLevel = false;
            panelChile.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btnAdminTools_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSmartSearch_Click(object sender, EventArgs e)
        {
            new FaithfulMembers().Show();
            this.Hide();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {

        }

        private void btnBookedEvents_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            new LoginForm().Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnAddF_Click(object sender, EventArgs e)
        {
            new AddingNewFaithful().Show();
            this.Hide();
        }

        private void btnBookAnEvents_Click(object sender, EventArgs e)
        {
            ConfirmBooking f = new ConfirmBooking();
            f.TopLevel = false;
            panelChile.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btnCert_Click(object sender, EventArgs e)
        {
            CertificateForm f = new CertificateForm();
            f.TopLevel = false;
            panelChile.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void panelChile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBookedEvent_Click(object sender, EventArgs e)
        {
            BookedEvents f = new BookedEvents();
            f.TopLevel = false;
            panelChile.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }
    }
}
