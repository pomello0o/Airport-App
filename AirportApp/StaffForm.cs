using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportApp
{
    public partial class StaffForm : Form
    {
        AirportModel airport;
        User user;
        public StaffForm(AirportModel airport, int UserID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
            buttonStaff.BackColor = Color.Gold;
        }

        private void buttonNavHome_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm(airport, user.ID);
            mainForm.Show();
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            Hide();
            StaffForm staffForm = new StaffForm(airport, user.ID);
            staffForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            ProfileForm profileForm = new ProfileForm(airport, user.ID);
            profileForm.Show();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDataSet.CrewMember' table. You can move, or remove it, as needed.
            this.crewMemberTableAdapter.Fill(this.airportDataSet.CrewMember);
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
