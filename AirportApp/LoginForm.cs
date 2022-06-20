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
    public partial class LoginForm : Form
    {
        AirportModel airport;
        public LoginForm()
        {
            InitializeComponent();
            airport = new AirportModel();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            byte[] password = Encryption.CalculateSHA256(textBoxPassword.Text.Trim());
            var user = new User();
            try
            {
                user = airport.Users.Where(u => u.Email == email).First() as User;
                for (int i = 0; i < user.Password.Length; i++)
                {
                    if (user.Password[i] != password[i])
                        throw new ArgumentException();
                }
                this.Hide();
                if (user.Admin)
                {
                    AdminMainForm admin = new AdminMainForm(airport, user.ID);
                    admin.Show();
                }
                else
                {
                    MainForm mainForm = new MainForm(airport, user.ID);
                    mainForm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Entered email or password is wrong!");
                textBoxPassword.Text = "";
            }
        }

        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }
    }
}
