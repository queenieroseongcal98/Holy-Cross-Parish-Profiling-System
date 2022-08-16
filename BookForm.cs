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
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "P73pJ6lo9RSbjz1PjG1NLzBe8s8wV24het0fnAxJ",
            BasePath = "https://parishprofiling-7aeef-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void BookForm_Load(object sender, EventArgs e)
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

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fnameTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnameTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void eventBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void placementBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void noteBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBooktheEvent_Click(object sender, EventArgs e)
        {
            Bookevent std = new Bookevent()
            {
                FirstName = fnameTbox.Text,
                LasttName = lnameTbox.Text,
                Email = contactTbox.Text,
                Event = eventBox.Text,
                NumberofGuest = guna2TextBox6.Text,
                DateandTime = dateTimePicker1.Text,
                Note = noteBox.Text
            };
            var setter = client.Set("BookEvent/" + guna2TextBox6.Text, std);
            MessageBox.Show("Data inserted successfully.");
        }

        private void contactTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timeTbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timeTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guestTbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
