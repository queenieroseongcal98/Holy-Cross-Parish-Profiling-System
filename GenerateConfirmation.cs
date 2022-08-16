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
    public partial class GenerateConfirmation : Form
    {
        public GenerateConfirmation()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "P73pJ6lo9RSbjz1PjG1NLzBe8s8wV24het0fnAxJ",
            BasePath = "https://parishprofiling-7aeef-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void btnGenerateConfirmation_Click(object sender, EventArgs e)
        {
            invoiceConfirmation invConfirmation = new invoiceConfirmation();
            invConfirmation.Confirmand = tbtConfirmand.Text;
            invConfirmation.ConDay = cbConDay.Text;

            if (cbConMonth.SelectedIndex == -1)
                invConfirmation.ConMonth = "";
            else
                invConfirmation.ConMonth = cbConMonth.SelectedItem.ToString();

            invConfirmation.ConYear = cbConYear.Text;
            invConfirmation.ConParish = cbParish.Text;
            invConfirmation.ConPriest = cbParishPriest.Text;
            invConfirmation.ShowDialog();
        }

        private void GenerateConfirmation_Load(object sender, EventArgs e)
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

        private void btnUpdateConfirmation_Click(object sender, EventArgs e)
        {
            Confirmation std = new Confirmation()
            {
                ConfirmandName = tbtConfirmand.Text,
                ConfirmationDay = cbConDay.Text,
                ConfirmationMonth = cbConMonth.Text,
                ConfirmationYear = cbConYear.Text,
                ConfirmationParish = cbParish.Text,
                ConfirmationPriest = cbParishPriest.Text
            };
            var setter = client.Set("Confirmation Cerificate/" + tbtConfirmand.Text, std);
            MessageBox.Show("Data inserted successfully.");
        }

        private void cbConDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbtConfirmand_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbConMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbConYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbParish_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbParishPriest_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbConDay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
