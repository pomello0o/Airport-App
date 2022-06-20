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
    public partial class MainForm : Form
    {
        AirportModel airport;
        User user;
        public MainForm(AirportModel airport, int UserID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (user.Name != "")
                labelWelcome.Text = $"Welcome, {user.Name} {user.Surname}!";
            else
                labelWelcome.Text = "Welcome!";
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

        private void buttonRace_Click(object sender, EventArgs e)
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
