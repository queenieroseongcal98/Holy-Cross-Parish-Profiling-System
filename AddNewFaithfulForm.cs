using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace HolyCrossParishDesktopApplication
{
    public partial class AddNewFaithfulForm : Form
    {
        public AddNewFaithfulForm()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "P73pJ6lo9RSbjz1PjG1NLzBe8s8wV24het0fnAxJ",
            BasePath = "https://parishprofiling-7aeef-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button2next_Click(object sender, EventArgs e)
        {
           
        }

        private void AddNewFaithfulForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("There was a problem in the internet.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
           // this.Dispose();
        }

        private void btnRegisterNF_Click(object sender, EventArgs e)
        {
            Newfaith std = new Newfaith()
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                CivilStatus = tetStatus.Text,
                DateofBirth = txtDatebirth.Text,
                Age = txtAge.Text,
                ContactNumb = txtContact.Text,
                FatherName = txtFname.Text,
                MotherName = txtMname.Text,
                HouseholdHead = txtHH.Text,
                SpouseName = txtboxSpouse.Text,
                NoOffspring = txtOffspring.Text,
                ChapterClusterNumber = txtCcn.Text
            };
            var setter = client.Set("NewFaithMember/" + txtName.Text, std);
            MessageBox.Show("Data inserted successfully.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = client.Delete("NewFaithMember/" + txtName.Text);
            MessageBox.Show("Data deleted successfully.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Newfaith std = new Newfaith()
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                CivilStatus = tetStatus.Text,
                DateofBirth = txtDatebirth.Text,
                Age = txtAge.Text,
                ContactNumb = txtContact.Text,
                FatherName = txtFname.Text,
                MotherName = txtMname.Text,
                HouseholdHead = txtHH.Text,
                SpouseName = txtboxSpouse.Text,
                NoOffspring = txtOffspring.Text,
                ChapterClusterNumber = txtCcn.Text
            };
            var setter = client.Update("NewFaithMember/" + txtName.Text, std);
            MessageBox.Show("Data updated successfully.");
        }

        private void txtDbirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDatebirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
