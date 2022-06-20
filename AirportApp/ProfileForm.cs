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
    public partial class ProfileForm : Form
    {
        AirportModel airport;
        User user;
        public ProfileForm(AirportModel airport, int UserID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
            pictureBox1.BackColor = Color.Gold;
        }

        private void buttonNavHome_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm(airport, user.ID);
            mainForm.Show();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            textBoxName.Text = user.Name;
            textBoxSurname.Text = user.Surname;
            textBoxEmail.Text = user.Email;
            SetGender();
            if (user.Birthday != null)
                dateTimePickerBirtday.Value = Convert.ToDateTime(user.Birthday);
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

        private void linkLabelPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(airport, user.ID);
            changePasswordForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            ProfileForm profileForm = new ProfileForm(airport, user.ID);
            profileForm.Show();
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
    }
}
