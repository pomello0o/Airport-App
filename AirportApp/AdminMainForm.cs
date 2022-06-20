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
    public partial class AdminMainForm : Form
    {
        AirportModel airport;
        User user;
        public AdminMainForm(AirportModel airport, int UserID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
        }

        private void pictureBoxLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void labelProfile_Click(object sender, EventArgs e)
        {
            Hide();
            AdminProfileForm adminProfileForm = new AdminProfileForm(airport, user.ID);
            adminProfileForm.Show();
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
    }
}
