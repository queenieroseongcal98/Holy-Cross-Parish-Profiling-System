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
    public partial class Splashform : Form
    {
        public Splashform()
        {
            InitializeComponent();
        }

        int startPoint = 0;


        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            guna2ProgressBar1.Value = startPoint;
            if (guna2ProgressBar1.Value ==100)
            {
                guna2ProgressBar1.Value = 0;
                timer1.Stop();

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide(); 
            }
        }

        private void Splashform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
