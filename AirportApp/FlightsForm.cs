using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportApp
{
    public partial class FlightsForm : Form
    {
        AirportModel airport;
        User user;
        public FlightsForm(AirportModel airport, int UserID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
            buttonFlights.BackColor = Color.Gold;
        }

        private void buttonNavHome_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm(airport, user.ID);
            mainForm.Show();
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            Hide();
            StaffForm staffForm = new StaffForm(airport, user.ID);
            staffForm.Show();
        }

        private void buttonPlanes_Click(object sender, EventArgs e)
        {
            Hide();
            PlanesForm planesForm = new PlanesForm(airport, user.ID);
            planesForm.Show();
        }

        private void buttonRaces_Click(object sender, EventArgs e)
        {
            Hide();
            RacesForm racesForm = new RacesForm(airport, user.ID);
            racesForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            ProfileForm profileForm = new ProfileForm(airport, user.ID);
            profileForm.Show();
        }

        private void buttonFlights_Click(object sender, EventArgs e)
        {
            Hide();
            FlightsForm flightsForm = new FlightsForm(airport, user.ID);
            flightsForm.Show();
        }

        private void pictureBoxLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void FlightsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userFlightsView.FlightsView' table. You can move, or remove it, as needed.
            this.flightsViewTableAdapter.Fill(this.userFlightsView.FlightsView);

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            flightsViewBindingSource.Filter = "";
            string departure = textBoxDeparture.Text.Trim();
            string destination = textBoxDestination.Text.Trim();
            if (departure != "")
                SetLikeFilter("DeparturePoint", departure);
            if (destination != "")
                SetLikeFilter("DestinationPoint", destination);
        }
        private void SetLikeFilter(string str, string value)
        {
            if (flightsViewBindingSource.Filter.Length > 0)
                flightsViewBindingSource.Filter += string.Format(" AND {0} LIKE '%{1}%'", str, value);
            else
                flightsViewBindingSource.Filter += string.Format("{0} LIKE '%{1}%'", str, value);
        }
    }
}
