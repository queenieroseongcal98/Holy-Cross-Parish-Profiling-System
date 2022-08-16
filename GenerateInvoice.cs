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
    public partial class GenerateInvoice : Form
    {
        public GenerateInvoice()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "P73pJ6lo9RSbjz1PjG1NLzBe8s8wV24het0fnAxJ",
            BasePath = "https://parishprofiling-7aeef-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void GenerateInvoive_Load(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbtCandidate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGEnerateCert_Click(object sender, EventArgs e)
        {
            invoice baptismal = new invoice();
            baptismal.Candidate = tbtCandidate.Text;
            baptismal.FatherCandidate = tbtFather.Text;
            baptismal.MotherCandidate = tbtMother.Text;
            baptismal.DBirth = cbDB.Text;
            if (cbMB.SelectedIndex == -1)
                baptismal.MBirth = "";
            else
                baptismal.MBirth = cbMB.SelectedItem.ToString();

            baptismal.YBirth = cbYB.Text;

            if (cbDB1.SelectedIndex == -1)
                baptismal.DBapt = "";
            else
                baptismal.DBapt = cbDB1.SelectedItem.ToString();
            if (cbMB1.SelectedIndex == -1)
                baptismal.MBapt = "";
            else
                baptismal.MBapt = cbMB1.SelectedItem.ToString();

            baptismal.YBapt = cbYB1.Text;
            baptismal.OPriest = tbOP.Text;
            baptismal.Sponsors1 = tbSponsor1.Text;
            baptismal.Sponsors2 = tbSponsor2.Text;
            baptismal.Date = dateboxPresentDate.Text;
            baptismal.PPriest = tbPP.Text;
            baptismal.ShowDialog();
        }

        private void tbPP_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateboxPresentDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbSponsor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSponsor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOP_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbYB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbMB1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDB1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbYB_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbtMother_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbtFather_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Certificateinfo std = new Certificateinfo()
            {
                Candidate = tbtCandidate.Text,
                FatherName = tbtFather.Text,
                MotherName = tbtMother.Text,
                DayBirth = cbDB.Text,
                MonthBirth = cbMB.Text,
                YearBirth = cbYB.Text,
                DayBaptismal = cbDB1.Text,
                MonthBaptismal = cbMB1.Text,
                YearBaptismal = cbYB1.Text,
                OfficiatingPriest = tbOP.Text,
                Sponsors1 = tbSponsor1.Text,
                Sponsors2 = tbSponsor2.Text,
                PresentDate = dateboxPresentDate.Text,
                ParishPriest = tbPP.Text
            };
            var setter = client.Set("Baptismal Cerificate/" + tbtCandidate.Text, std);
            MessageBox.Show("Data inserted successfully.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
