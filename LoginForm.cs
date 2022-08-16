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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "admin")
            {
                if(txtPassword.Text == "admin123")
                {
                    new MainForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error: Please enter correct information");
                }
            }
            else
            {
                MessageBox.Show("Error: Please enter the correct information");
            }
        }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
