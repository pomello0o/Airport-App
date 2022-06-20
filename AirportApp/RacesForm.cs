using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AirportApp
{
    public partial class RacesForm : Form
    {
        AirportModel airport;
        User user;
        public RacesForm(AirportModel airport, int UserID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
            buttonRaces.BackColor = Color.Gold;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            ProfileForm profileForm = new ProfileForm(airport, user.ID);
            profileForm.Show();
        }

        private void RacesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDataSet.Race' table. You can move, or remove it, as needed.
            this.raceTableAdapter.Fill(this.airportDataSet.Race);

        }

        private void buttonAllowedModels_Click(object sender, EventArgs e)
        {
            int raceNumber = Convert.ToInt32(numericUpDownNumber.Value);
            if (airport.Races.Where(r => r.RaceNumber == raceNumber).Count() > 0)
            {
                string models = "";
                SqlParameter sqlParameter = new SqlParameter("@RaceNumber", raceNumber);
                var result = airport.Database.SqlQuery<string>("exec AllowedRaceModels @RaceNumber", sqlParameter).ToList();
                foreach (var r in result)
                    models += $"\n\t{r}";
                MessageBox.Show($"For race number {raceNumber} allowed plane models are:\n{models}");
            }
            else
                MessageBox.Show("Thers is no race with such number!");
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            raceBindingSource.Filter = "";
            string raceNumber = numericUpDownNumber.Value.ToString();
            string departure = textBoxDeparute.Text.Trim();
            string destination = textBoxDestination.Text.Trim();
            if (raceNumber != "0" && raceNumber != "")
                raceBindingSource.Filter += string.Format("RaceNumber = {0}", raceNumber);
            if (departure != "")
                SetLikeFilter("DeparturePoint", departure);
            if (destination != "")
                SetLikeFilter("DestinationPoint", destination);
        }
        private void SetLikeFilter(string str, string value)
        {
            if (raceBindingSource.Filter.Length > 0)
                raceBindingSource.Filter += string.Format(" AND {0} LIKE '%{1}%'", str, value);
            else
                raceBindingSource.Filter += string.Format("{0} LIKE '%{1}%'", str, value);
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
