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
    public partial class ConfirmBooking : Form
    {
        public ConfirmBooking()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "P73pJ6lo9RSbjz1PjG1NLzBe8s8wV24het0fnAxJ",
            BasePath = "https://parishprofiling-7aeef-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void ConfirmBooking_Load(object sender, EventArgs e)
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

        private void txtbocFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxContactN_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboboxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datepickerConfirmEvent_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtboxTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void richtxtboxNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConfirmationofEvent_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Confirmbook std = new Confirmbook()
            {
                FirstName = txtbocFName.Text,
                LastName = txtboxLName.Text,
                ContactNumber = txtboxContactN.Text,
                Event = comboboxEvent.Text,
                NumberofGuest = numberGuestbox.Text,
                Placement = placementBox.Text,
                Date = txtDate.Text,
                Time = txtboxTime.Text,
                Note = richtxtboxNote.Text
            };
            var setter = client.Set("ConfirmBooking/" + txtbocFName.Text, std);
            MessageBox.Show("Data inserted successfully.");
        }

        private void numberGuestbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void placementBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Confirmbook std = new Confirmbook()
            {
                FirstName = txtbocFName.Text,
                LastName = txtboxLName.Text,
                ContactNumber = txtboxContactN.Text,
                Event = comboboxEvent.Text,
                NumberofGuest = numberGuestbox.Text,
                Placement = placementBox.Text,
                Date = txtDate.Text,
                Time = txtboxTime.Text,
                Note = richtxtboxNote.Text
            };
            var setter = client.Update("ConfirmBooking/" + txtbocFName.Text, std);
            MessageBox.Show("Data updated successfully.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = client.Delete("ConfirmBooking/" + txtbocFName.Text);
            MessageBox.Show("Data deleted successfully.");
        }

        private void btnDispose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
