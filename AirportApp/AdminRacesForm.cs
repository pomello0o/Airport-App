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
    public partial class AdminRacesForm : Form
    {
        AirportModel airport;
        User user;
        public AdminRacesForm(AirportModel airport, int UserID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
            buttonRaces.BackColor = Color.Gold;
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

        private void raceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.raceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airportDataSet);

        }

        private void AdminRacesForm_Load(object sender, EventArgs e)
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

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Hide();
            AdminRacesCreateForm adminRacesCreateForm = new AdminRacesCreateForm(airport, user.ID);
            adminRacesCreateForm.Show();
        }

        private void buttonFlights_Click(object sender, EventArgs e)
        {
            Hide();
            AdminFlightsForm adminFlightsForm = new AdminFlightsForm(airport, user.ID);
            adminFlightsForm.Show();
        }
    }
}
