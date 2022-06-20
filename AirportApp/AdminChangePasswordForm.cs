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
    public partial class AdminChangePasswordForm : Form
    {
        AirportModel airport;
        User user;
        public AdminChangePasswordForm(AirportModel airport, int UserID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
        }

        private void linkLabelProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            AdminProfileForm adminProfileForm = new AdminProfileForm(airport, user.ID);
            adminProfileForm.Show();
        }

        private void pictureBoxOld_MouseEnter(object sender, EventArgs e)
        {
            textBoxOldPass.UseSystemPasswordChar = false;
            pictureBoxOld.Image = AirportApp.Properties.Resources.eye;
        }
        private void pictureBoxOld_MouseLeave(object sender, EventArgs e)
        {
            textBoxOldPass.UseSystemPasswordChar = true;
            pictureBoxOld.Image = AirportApp.Properties.Resources.hidden;
        }

        private void pictureBoxNew_MouseEnter(object sender, EventArgs e)
        {
            textBoxNewPass.UseSystemPasswordChar = false;
            pictureBoxNew.Image = AirportApp.Properties.Resources.eye;
        }

        private void pictureBoxNew_MouseLeave(object sender, EventArgs e)
        {
            textBoxNewPass.UseSystemPasswordChar = true;
            pictureBoxNew.Image = AirportApp.Properties.Resources.hidden;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            textBoxConfirmPass.UseSystemPasswordChar = false;
            pictureBoxConfirm.Image = AirportApp.Properties.Resources.eye;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            textBoxConfirmPass.UseSystemPasswordChar = true;
            pictureBoxConfirm.Image = AirportApp.Properties.Resources.hidden;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string oldPass = textBoxOldPass.Text;
            string newPass = textBoxNewPass.Text;
            string confirmPass = textBoxConfirmPass.Text;
            try
            {
                int errorCount = 0;

                for (int i = 0; i < user.Password.Length; i++)
                {
                    if (user.Password[i] != Encryption.CalculateSHA256(oldPass)[i])
                    {
                        errorCount++;
                        labelInvalidOld.Visible = true;
                        break;
                    }
                    else
                        labelInvalidOld.Visible = false;
                }

                if (newPass.Length < 8)
                {
                    errorCount++;
                    labelInvalidNew.Visible = true;
                }
                else
                    labelInvalidNew.Visible = false;

                if (confirmPass != newPass)
                {
                    errorCount++;
                    labelInvalidConfirm.Visible = true;
                }
                else
                    labelInvalidConfirm.Visible = false;

                if (errorCount > 0) return;

                user.Password = Encryption.CalculateSHA256(newPass);
                airport.SaveChanges();
                MessageBox.Show("Password changed successfully!");
            }
            catch
            {
                MessageBox.Show("Invalid data");
            }
        }
    }
}
