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
using System.Windows;
using System.Windows.Input;


namespace HolyCrossParishDesktopApplication
{
    public partial class BookedEvents : Form
    {
        public BookedEvents()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "P73pJ6lo9RSbjz1PjG1NLzBe8s8wV24het0fnAxJ",
            BasePath = "https://parishprofiling-7aeef-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        //public List<Confirmbook> Confirm { get; set; } = new List<Confirmbook>();
        //public List<Confirmbook> ConfirmDisplay { get; set; } = new List<Confirmbook>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BookedEvents_Load(object sender, EventArgs e)
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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get(@"ConfirmBooking");
            Dictionary<string, Confirmbook> data = JsonConvert.DeserializeObject<Dictionary<string, Confirmbook>>(res.Body.ToString());
            PopulateData(data);
        }

        void PopulateData(Dictionary<string, Confirmbook> record)
        {
            datagvFaithful.Rows.Clear();
            datagvFaithful.Columns.Clear();

            datagvFaithful.Columns.Add("first name", "First Name");
            datagvFaithful.Columns.Add("last name", "Last Name");
            datagvFaithful.Columns.Add("contact number", "Contact Number");
            datagvFaithful.Columns.Add("event", "Event");
            datagvFaithful.Columns.Add("number of guest", "Number of Guest");
            datagvFaithful.Columns.Add("placement", "Placement");
            datagvFaithful.Columns.Add("date", "Date");
            datagvFaithful.Columns.Add("time", "Time");
            datagvFaithful.Columns.Add("note", "Note");

            foreach (var item in record)
            {
                datagvFaithful.Rows.Add(item.Value.FirstName, item.Value.LastName, item.Value.ContactNumber, item.Value.Event, item.Value.NumberofGuest, item.Value.Placement, item.Value.Date, item.Value.Time, item.Value.Note);
            }
        }

        private  void btnSearchBox_Click(object sender, EventArgs e)
        {

        }

        /*private async void btnSearchBox_Click(object sender, EventArgs e)
        {
            btnSearchBox.Enabled = false;
            FirebaseResponse response = client.GetAsync(@"ConfirmBooking");
            //Dictionary<string, TravelHistoryData>> result = response.ResultAs<Dictionary<string, Dictionary<string, TravelHistoryData>>>();
            Dictionary<string, Confirmbook> data = JsonConvert.DeserializeObject<Dictionary<string, Confirmbook>>(response.Body.ToString());
            Confirm = new List<Confirmbook>();
            foreach (Dictionary<string, TravelHistoryData> Confirmbook in data.Values)
            {
                for (int i = 0; i < travelInfo.Count; i++)
                {
                    UserInfo user = userList.Find(x => x.UID.Equals(travelInfo.ElementAt(i).Value.UID)) ?? new UserInfo();
                    string name = user.FirstName + " " + user.MI + ". " + user.LastName + ", " + user.Suffix;
                    travelList.Add(new TravelInfo
                    {
                        DateTime = travelInfo.ElementAt(i).Value.DateTime,
                        UID = travelInfo.ElementAt(i).Value.UID,
                        Origin = travelInfo.ElementAt(i).Value.Origin,
                        Destination = travelInfo.ElementAt(i).Value.Destination,
                        Fare = travelInfo.ElementAt(i).Value.Fare,
                        Name = name
                    });
                }
            }
            travelListDisplay = travelList;
            string filter = txtSearch.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(filter))
            {
                travelListDisplay = travelList.FindAll(x => (!string.IsNullOrEmpty(x.UID) && x.UID.Contains(filter))
                || (!string.IsNullOrEmpty(x.Name) && x.Name.ToLower().Contains(filter)) || (!string.IsNullOrEmpty(x.DateTime) && x.DateTime.ToLower().Contains(filter)));
            }
            travelListDataGrid.ItemsSource = travelListDisplay;
            btnSearchBox.Enabled = true;
        }*/



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
