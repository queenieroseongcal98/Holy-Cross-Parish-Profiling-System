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
    public partial class GenerateCommunion : Form
    {
        public GenerateCommunion()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "P73pJ6lo9RSbjz1PjG1NLzBe8s8wV24het0fnAxJ",
            BasePath = "https://parishprofiling-7aeef-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            invoiceCommunion invCommunion = new invoiceCommunion();
            invCommunion.Communicant = tbtCommunicant.Text;
            invCommunion.DCommunion = cbtDayCommunion.Text;
            if (cbtMCommunion.SelectedIndex == -1)
                invCommunion.MCommunion = "";
            else
                invCommunion.MCommunion = cbtMCommunion.SelectedItem.ToString();
            invCommunion.YCommunion = tbtYearCommunion.Text;
            invCommunion.CParish = tbtParishCommunion.Text;
            invCommunion.CPriest = tbtPriestCommunion.Text;
            invCommunion.CDirector = tbtDirector.Text;
            invCommunion.SPriest = tbtPriestCommunion.Text;
            invCommunion.ShowDialog();
        }

        private void tbtCommunicant_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerateCommunion_Load(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Communion std = new Communion()
            {
                CommunicantName = tbtCommunicant.Text,
                CommunionDay = cbtDayCommunion.Text,
                CommunionMonth = cbtMCommunion.Text,
                CommunionYear = tbtYearCommunion.Text,
                CommunionParish = tbtParishCommunion.Text,
                Director = tbtDirector.Text,
                CommunionPriest = tbtPriestCommunion.Text,
            };
            var setter = client.Set("Communion Cerificate/" + tbtCommunicant.Text, std);
            MessageBox.Show("Data inserted successfully.");
        }

        private void cbtDayCommunion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
