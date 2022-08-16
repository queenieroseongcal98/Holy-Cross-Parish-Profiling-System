using System;
using System.Collections.Generic;
using Newtonsoft.Json;
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
    public partial class searchform : Form
    {
        public searchform()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "P73pJ6lo9RSbjz1PjG1NLzBe8s8wV24het0fnAxJ",
            BasePath = "https://parishprofiling-7aeef-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void dgvFaithful_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDispose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDispose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get(@"NewFaithMember");
            Dictionary<string, Newfaith> data = JsonConvert.DeserializeObject<Dictionary<string, Newfaith>>(res.Body.ToString());
            PopulateDat(data);
        }

        void PopulateDat(Dictionary<string, Newfaith> record)
        {
            datagvFaithful.Rows.Clear();
            datagvFaithful.Columns.Clear();

            datagvFaithful.Columns.Add("name", "Name");
            datagvFaithful.Columns.Add("address", "Address");
            datagvFaithful.Columns.Add("civil status", "Civil Status");
            datagvFaithful.Columns.Add("date of birth", "Date of Birth");
            datagvFaithful.Columns.Add("age", "Age");
            datagvFaithful.Columns.Add("contact no", "Contact No");
            datagvFaithful.Columns.Add("father name", "Father Name");
            datagvFaithful.Columns.Add("mother name", "Mother Name");
            datagvFaithful.Columns.Add("household head", "Household Head");
            datagvFaithful.Columns.Add("spouse name", "Spouse Name");
            datagvFaithful.Columns.Add("no offspring", "No Offspring");
            datagvFaithful.Columns.Add("chapel and cluster number", "Chapel and Cluster Number");

            foreach (var item in record)
            {
                datagvFaithful.Rows.Add(item.Value.Name, item.Value.Address, item.Value.CivilStatus, item.Value.DateofBirth, item.Value.Age, item.Value.ContactNumb, item.Value.FatherName, item.Value.MotherName, item.Value.HouseholdHead, item.Value.SpouseName, item.Value.NoOffspring, item.Value.ChapterClusterNumber);
            }
        }

        private void dgvFaithful_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchform_Load(object sender, EventArgs e)
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

        private void dgvFaithful_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagvFaithful_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
