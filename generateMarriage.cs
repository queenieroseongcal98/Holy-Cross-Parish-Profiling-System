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
    public partial class generateMarriage : Form
    {
        public generateMarriage()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "P73pJ6lo9RSbjz1PjG1NLzBe8s8wV24het0fnAxJ",
            BasePath = "https://parishprofiling-7aeef-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            invoiceMarriage invMarriage = new invoiceMarriage();
            invMarriage.Groom = tbtGroom.Text;
            invMarriage.Bride = tbtBride.Text;
            invMarriage.MDay = cbtDMarriage.Text;
            if (cbtMMarriage.SelectedIndex == -1)
                invMarriage.MMonth = "";
            else
                invMarriage.MMonth = cbtMMarriage.SelectedItem.ToString();

            invMarriage.MYear = tbtYMarriage.Text;
            invMarriage.MPriest = tbtPriestMarriage.Text;
            invMarriage.MWitness1 = tbtWitness1.Text;
            invMarriage.MWitness2 = tbtWitness2.Text;
            invMarriage.ParMarriage = tbtParishMarriage.Text;
            invMarriage.GSignature = tbtGroom.Text;
            invMarriage.BSignature = tbtBride.Text;
            invMarriage.W1Signature = tbtWitness1.Text;
            invMarriage.PSignature = tbtPriestMarriage.Text;
            invMarriage.W2Signature = tbtWitness2.Text;
            invMarriage.ShowDialog();
        }

        private void generateMarriage_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Marriage std = new Marriage()
            {
                GroomName = tbtGroom.Text,
                BrideName = tbtBride.Text,
                MarriageDay = cbtDMarriage.Text,
                MarriageMonth = cbtMMarriage.Text,
                MarriageYear = tbtYMarriage.Text,
                MarriagePriest = tbtPriestMarriage.Text,
                MarriageParish = tbtParishMarriage.Text,
                Witness1 = tbtWitness1.Text,
                Witness2 = tbtWitness2.Text
            };
            var setter = client.Set("Marriage Cerificate/" + tbtGroom.Text, std);
            MessageBox.Show("Data inserted successfully.");
        }

        private void cbtDMarriage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
