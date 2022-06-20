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
    public partial class AdminFlightsForm : Form
    {
        AirportModel airport;
        User user;
        public AdminFlightsForm(AirportModel airport, int UserID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
            buttonFlights.BackColor = Color.Gold;
        }

        private void pictureBoxLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginFrom = new LoginForm();
            loginFrom.Show();
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            Hide();
            AdminProfileForm adminProfileForm = new AdminProfileForm(airport, user.ID);
            adminProfileForm.Show();
        }

        private void buttonNavHome_Click(object sender, EventArgs e)
        {
            Hide();
            AdminMainForm adminMainForm = new AdminMainForm(airport, user.ID);
            adminMainForm.Show();
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            Hide();
            AdminStaffForm adminStaffForm = new AdminStaffForm(airport, user.ID);
            adminStaffForm.Show();
        }

        private void buttonPlanes_Click(object sender, EventArgs e)
        {
            Hide();
            AdminPlanesForm adminPlanesForm = new AdminPlanesForm(airport, user.ID);
            adminPlanesForm.Show();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            Hide();
            AdminUsersChooseActionForm adminUsersChooseActionForm = new AdminUsersChooseActionForm(airport, user.ID);
            adminUsersChooseActionForm.Show();
        }

        private void buttonRaces_Click(object sender, EventArgs e)
        {
            Hide();
            AdminRacesForm adminRacesForm = new AdminRacesForm(airport, user.ID);
            adminRacesForm.Show();
        }

        private void buttonFlights_Click(object sender, EventArgs e)
        {
            Hide();
            AdminFlightsForm adminFlightsForm = new AdminFlightsForm(airport, user.ID);
            adminFlightsForm.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            adminFlightsBindingSource.Filter = "";
            string departure = textBoxDeparture.Text.Trim();
            string destination = textBoxDestination.Text.Trim();
            if (departure != "")
                SetLikeFilter("DeparturePoint", departure);
            if (destination != "")
                SetLikeFilter("DestinationPoint", destination);
        }
        private void SetLikeFilter(string str, string value)
        {
            if (adminFlightsBindingSource.Filter.Length > 0)
                adminFlightsBindingSource.Filter += string.Format(" AND {0} LIKE '%{1}%'", str, value);
            else
                adminFlightsBindingSource.Filter += string.Format("{0} LIKE '%{1}%'", str, value);
        }

        private void AdminFlightsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flights.AdminFlights' table. You can move, or remove it, as needed.
            this.adminFlightsTableAdapter.Fill(this.flights.AdminFlights);
            adminFlightsBindingSource.Sort = "DeparturePoint asc";
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Hide();
            AdminsFlightsCreateForm adminsFlightsCreateForm = new AdminsFlightsCreateForm(airport, user.ID);
            adminsFlightsCreateForm.Show();
        }
    }
}
