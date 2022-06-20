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
    public partial class AdminUsersManage : Form
    {
        AirportModel airport;
        User user;
        User userToManage;
        Boolean action;
        public AdminUsersManage(AirportModel airport, int UserID, int userToManageID, Boolean action)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
            userToManage = airport.Users.Where(u => u.ID == userToManageID).FirstOrDefault();
            this.action = action;
        }
        public AdminUsersManage(AirportModel airport, int UserID, Boolean action)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
            this.action = action;
        }

        private void linkLabelBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            AdminUsersChooseActionForm adminUsersChooseActionForm = new AdminUsersChooseActionForm(airport, user.ID);
            adminUsersChooseActionForm.Show();
        }

        private void AdminUsersManage_Load(object sender, EventArgs e)
        {
            if(action)
            {
                this.Text = "   Manage user";
                buttonAction.Text = "Update";
                textBoxName.Text = userToManage.Name;
                textBoxSurname.Text = userToManage.Surname;
                textBoxEmail.Text = userToManage.Email;
                SetGender();
                if (userToManage.Birthday != null)
                    dateTimePickerBirtday.Value = Convert.ToDateTime(userToManage.Birthday);
            } else
            {
                this.Text = "   Create user";
                buttonAction.Text = "Create";
            }
        }
        private void SetGender()
        {
            if (userToManage.Gender == "Male")
                radioButtonMale.Checked = true;
            else if (userToManage.Gender == "Female")
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

        private void buttonAction_Click(object sender, EventArgs e)
        {
            if(action)
            {
                string name = textBoxName.Text;
                string surname = textBoxSurname.Text;
                string email = textBoxEmail.Text;
                string gender = UpdateGender();
                string password = textBoxPassword.Text;
                byte[] passwordHash = Encryption.CalculateSHA256(password);
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

                    if (airport.Users.Where(u => u.Email == email).Count() > 0 && userToManage.Email != email)
                    {
                        labelDuplicateEmail.Visible = true;
                        return;
                    }
                    else
                        labelDuplicateEmail.Visible = false;
                    if(password != "")
                        userToManage.Update(name, surname, email, gender, birthday, passwordHash);
                    else
                    userToManage.Update(name, surname, email, gender, birthday);
                    airport.SaveChanges();
                    MessageBox.Show("User updated successfully!");
                }
                catch
                { 
                    MessageBox.Show("Invalid data");
                }
            }
            else
            {
                try
                {
                    string name = textBoxName.Text;
                    string surname = textBoxSurname.Text;
                    string email = textBoxEmail.Text;
                    string password = textBoxPassword.Text;
                    byte[] passwordHash = Encryption.CalculateSHA256(password);
                    DateTime birthday = dateTimePickerBirtday.Value;
                    string gender = UpdateGender();
                    User newUser = new User(name, surname, email, passwordHash, birthday, gender);
                    airport.Users.Add(newUser);
                    airport.SaveChanges();
                    MessageBox.Show("New user created!");
                }
                catch
                {
                    MessageBox.Show("Invalid data!");
                }
            }
        }

        private void pictureBoxOld_MouseEnter(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxOld.Image = AirportApp.Properties.Resources.eye;
        }

        private void pictureBoxOld_MouseLeave(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxOld.Image = AirportApp.Properties.Resources.hidden;
        }
    }
}
