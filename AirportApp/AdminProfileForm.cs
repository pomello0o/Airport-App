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
    public partial class AdminProfileForm : Form
    {
        AirportModel airport;
        User user;
        public AdminProfileForm(AirportModel airport, int UserID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
            pictureBoxProfile.BackColor = Color.Gold;
        }

        private void AdminProfileForm_Load(object sender, EventArgs e)
        {
            textBoxName.Text = user.Name;
            textBoxSurname.Text = user.Surname;
            textBoxEmail.Text = user.Email;
            SetGender();
            if (user.Birthday != null)
                dateTimePickerBirtday.Value = Convert.ToDateTime(user.Birthday);
        }
                private void SetGender()
        {
            if (user.Gender == "Male")
                radioButtonMale.Checked = true;
            else if (user.Gender == "Female")
                radioButtonFemale.Checked = true;
        }
        private string UpdateGender()
        {
            if (radioButtonMale.Checked)
                return "Male";
            else if (radioButtonFemale.Checked)
                return "Female";
            else
                return "";

        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            Hide();
            AdminProfileForm adminProfileForm = new AdminProfileForm(airport, user.ID);
            adminProfileForm.Show();
        }

        private void pictureBoxLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void buttonNavHome_Click(object sender, EventArgs e)
        {
            Hide();
            AdminMainForm adminMainForm = new AdminMainForm(airport, user.ID);
            adminMainForm.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string email = textBoxEmail.Text;
            string gender = UpdateGender();
            DateTime birthday = dateTimePickerBirtday.Value;

            try
            {
                if (!email.Contains("@") || !email.Contains(".") || email.Length < 5)
                {
                    labelInvalidEmail.Visible = true;
                    return;
                }
                else
                    labelInvalidEmail.Visible = false;

                if (airport.Users.Where(u => u.Email == email).Count() > 0 && user.Email != email)
                {
                    labelDuplicateEmail.Visible = true;
                    return;
                }
                else
                    labelDuplicateEmail.Visible = false;

                user.Update(name, surname, email, gender, birthday);
                airport.SaveChanges();
                MessageBox.Show("Profile updated successfully!");
            }
            catch
            {
                MessageBox.Show("Invalid data");
            }
        }

        private void linkLabelPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            AdminChangePasswordForm adminChangePasswordForm = new AdminChangePasswordForm(airport, user.ID);
            adminChangePasswordForm.Show();
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
