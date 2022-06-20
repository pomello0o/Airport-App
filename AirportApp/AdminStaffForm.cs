﻿using System;
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
    public partial class AdminStaffForm : Form
    {
        AirportModel airport;
        User user;
        public AdminStaffForm(AirportModel airport, int UserID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
            buttonStaff.BackColor = Color.Gold;
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

        private void AdminStaffForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDataSet.CrewMember' table. You can move, or remove it, as needed.
            this.crewMemberTableAdapter.Fill(this.airportDataSet.CrewMember);

        }

        private void crewMemberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.crewMemberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airportDataSet);
        }
        private void SetRoleFilter(string role)
        {
            if (crewMemberBindingSource.Filter.Length > 0)
                crewMemberBindingSource.Filter += $" OR Role = '{role}'";
            else
                crewMemberBindingSource.Filter += $"Role = '{role}'";
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            try
            {
                crewMemberBindingSource.Filter = "";
                Boolean isCom = checkBoxCommander.Checked;
                Boolean isPil = checkBoxPilot.Checked;
                Boolean isStew = checkBoxStewardess.Checked;
                if (isCom)
                    SetRoleFilter("Commander");
                if (isPil)
                    SetRoleFilter("Pilot");
                if (isStew)
                    SetRoleFilter("Stewardess");
                crewMemberBindingSource.Sort = "Role Desc";
            }
            catch
            {
                MessageBox.Show("Invalid operation!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            AdminCreateStaffForm adminCreateStaffForm = new AdminCreateStaffForm(airport, user.ID);
            adminCreateStaffForm.ShowDialog();
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
