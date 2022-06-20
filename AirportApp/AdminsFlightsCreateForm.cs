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
    public partial class AdminsFlightsCreateForm : Form
    {
        AirportModel airport;
        User user;
        Flight flight;
        public AdminsFlightsCreateForm(AirportModel airport, int UserID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
            this.flight = null;
        }
        public AdminsFlightsCreateForm(AirportModel airport, int UserID, Flight flight)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
            this.flight = flight;
        }

        private void raceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.raceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airportDataSet);

        }

        private void AdminsFlightsCreateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDataSet.Race' table. You can move, or remove it, as needed.
            this.raceTableAdapter.Fill(this.airportDataSet.Race);
            if(flight != null)
            {
                raceComboBox.Text = flight.RaceID.ToString();
                textBoxDeparturePoint.Text = flight.Race.DeparturePoint;
                textBoxDestinationPoint.Text = flight.Race.DestinationPoint;
                numericUpDownDepartureHours.Value = flight.Race.DepartureTime.Value.Hours;
                numericUpDownDepartureMin.Value = flight.Race.DepartureTime.Value.Minutes;
                numericUpDownDepartureSec.Value = flight.Race.DepartureTime.Value.Seconds;
                numericUpDownLandingHours.Value = flight.Race.LandingTime.Value.Hours;
                numericUpDownLandingMin.Value = flight.Race.LandingTime.Value.Minutes;
                numericUpDownLandingSec.Value = flight.Race.LandingTime.Value.Seconds;
                modelComboBox.Text = flight.Plane.ModelID.ToString();
                numericUpDownPlaces.Value = flight.Plane.Model.PlacesNumber;
                numericUpDownLoad.Value = flight.Plane.Model.LoadCapacity;
                planeComboBox.Text = flight.PlaneID.ToString();
                textBoxBoard.Text = flight.Plane.BoardNumber;
                numericUpDownHours.Value = flight.Plane.HoursWorked;
                dateTimePickerDate.Value = flight.DepartureDate;
            }
        }

        private void raceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int raceNumber = Convert.ToInt32(raceComboBox.Text);
            Race race = airport.Races.Where(r => r.RaceNumber == raceNumber).FirstOrDefault();
            textBoxDeparturePoint.Text = race.DeparturePoint;
            textBoxDestinationPoint.Text = race.DestinationPoint;
            numericUpDownDepartureHours.Value = race.DepartureTime.Value.Hours;
            numericUpDownDepartureMin.Value = race.DepartureTime.Value.Minutes;
            numericUpDownDepartureSec.Value = race.DepartureTime.Value.Seconds;
            numericUpDownLandingHours.Value = race.LandingTime.Value.Hours;
            numericUpDownLandingMin.Value = race.LandingTime.Value.Minutes;
            numericUpDownLandingSec.Value = race.LandingTime.Value.Seconds;
            List<string> models = new List<string>();
            foreach (var model in race.AllowedRaceModels)
            {
                string name = airport.Models.Where(m => m.ID == model.ModelID).FirstOrDefault().Name;
                if (name != null)
                    models.Add(name);
                
            }
            modelComboBox.DataSource = models;

        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string modelName = modelComboBox.Text;
            Model model = airport.Models.Where(m => m.Name == modelName).FirstOrDefault();
            numericUpDownPlaces.Value = model.PlacesNumber;
            numericUpDownLoad.Value = model.LoadCapacity;
            List<int> planes = new List<int>();
            foreach (var plane in model.Planes)
            {
                planes.Add(plane.ID);

            }
            planeComboBox.DataSource = planes;
        }

        private void planeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int planeID = Convert.ToInt32(planeComboBox.Text);
            Plane plane = airport.Planes.Where(p => p.ID == planeID).FirstOrDefault();
            textBoxBoard.Text = plane.BoardNumber;
            numericUpDownHours.Value = plane.HoursWorked;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
            AdminFlightsForm adminFlightsForm = new AdminFlightsForm(airport, user.ID);
            adminFlightsForm.Show();
        }

        private void buttonCrew_Click(object sender, EventArgs e)
        {
            int raceNumber = Convert.ToInt32(raceComboBox.Text);
            int planeID = Convert.ToInt32(planeComboBox.Text);
            DateTime departure = dateTimePickerDate.Value;

            int raceID = airport.Races.Where(r => r.RaceNumber == raceNumber).FirstOrDefault().ID;
            int ID = airport.Flights.OrderByDescending(f => f.ID).FirstOrDefault().ID + 1;
            flight = new Flight(ID, departure, raceID, planeID);
            airport.Flights.Add(flight);
            airport.SaveChanges();
            Hide();
            AdminFlightsPickCrewForm adminFlightsPickCrewForm = new AdminFlightsPickCrewForm(airport, user.ID, flight.ID);
            adminFlightsPickCrewForm.Show();
        }
    }
}
