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
    public partial class AdminUsersChooseActionForm : Form
    {
        AirportModel airport;
        User user;
        public AdminUsersChooseActionForm(AirportModel airport, int UserID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
            buttonUsers.BackColor = Color.Gold;
        }

        private void pictureBoxLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            Hide();
            AdminProfileForm adminProfileForm = new AdminProfileForm(airport, user.ID);
            adminProfileForm.Show();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            Hide();
            AdminUsersChooseActionForm adminUsersChooseActionForm = new AdminUsersChooseActionForm(airport, user.ID);
            adminUsersChooseActionForm.Show();
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

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Hide();
            AdminUsersManage adminUsersManage = new AdminUsersManage(airport, user.ID, false);
            adminUsersManage.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int userToManageID = Convert.ToInt32(numericUpDownID.Value);
                if (airport.Users.Where(u => u.ID == userToManageID).Count() > 0)
                {
                    Hide();
                    AdminUsersManage adminUsersManage = new AdminUsersManage(airport, user.ID, userToManageID, true);
                    adminUsersManage.Show();
                }
                else
                    MessageBox.Show($"User with ID = {userToManageID} doesn't exist!");
            }
            catch
            {
                MessageBox.Show("Invalid user ID!");
            }
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
