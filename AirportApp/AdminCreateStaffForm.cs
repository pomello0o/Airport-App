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
    public partial class AdminCreateStaffForm : Form
    {
        AirportModel airport;
        User user;
        public AdminCreateStaffForm(AirportModel airport, int UserID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
        }

        private void linkLabelBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            AdminStaffForm adminStaffForm = new AdminStaffForm(airport, user.ID);
            adminStaffForm.Show();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
                string surname = textBoxSurname.Text;
                string role = comboBoxRole.Text;
                string address = textBoxAddress.Text;
                DateTime birthday = dateTimePickerBirthday.Value;
                CrewMember last = airport.CrewMembers.OrderByDescending(c => c.ID).FirstOrDefault();
                CrewMember crewMember = new CrewMember(last.ID + 1, name, surname, role, address, birthday);
                airport.CrewMembers.Add(crewMember);
                airport.SaveChanges();
                MessageBox.Show("New Crew member created!");
            }
            catch
            {
                MessageBox.Show("Invalid data!");
            }
        }
    }
}
