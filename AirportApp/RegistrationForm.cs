using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace AirportApp
{
    public partial class RegistrationForm : Form
    {
        AirportModel airport;
        public RegistrationForm()
        {
            InitializeComponent();
            airport = new AirportModel();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            try
            {
                int errorCount = 0;
                if (!email.Contains("@") || !email.Contains(".") || email.Length < 5)
                {
                    labelInvalidEmail.Visible = true;
                    errorCount++;
                } else
                    labelInvalidEmail.Visible = false;

                if (airport.Users.Where(u => u.Email == email).Count() > 0)
                {
                    labelDuplicateEmail.Visible = true;
                    errorCount++;
                } else
                    labelDuplicateEmail.Visible = false;

                if (password.Length < 8)
                {
                    labelInvalidPassword.Visible = true;
                    textBoxPassword.Text = "";
                    errorCount++;
                } else
                    labelInvalidPassword.Visible = false;
                if (errorCount > 0) return;
                byte[] encryptedPassword = Encryption.CalculateSHA256(password);
                User user = new User(name, surname, email, encryptedPassword);
                airport.Users.Add(user);
                airport.SaveChanges();
                this.Hide();
                MainForm mainForm = new MainForm(airport, user.ID);
                mainForm.Show();
            }
            catch
            {
                MessageBox.Show("Invalid data");
            }
        }

        private void linkLabelLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
