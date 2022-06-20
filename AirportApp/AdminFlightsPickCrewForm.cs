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
    public partial class AdminFlightsPickCrewForm : Form
    {
        AirportModel airport;
        User user;
        Flight flight;
        public AdminFlightsPickCrewForm(AirportModel airport, int UserID, int FlightID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
            flight = airport.Flights.Where(u => u.ID == FlightID).FirstOrDefault();
        }

        private void AdminFlightsPickCrewForm_Load(object sender, EventArgs e)
        {
            List<int?> commanders = new List<int?>();
            foreach (var com in airport.AllowedCrewMemberModels.Where(a => (a.ModelID == flight.Plane.ModelID && a.CrewMember.Role == "Commander")))
            {
                SqlParameter sqlParameterCrew = new SqlParameter("@CrewMemberID", com.CrewMemberID);
                SqlParameter sqlParameterDate = new SqlParameter("@FlightDate", flight.DepartureDate);
                int? days = airport.Database.SqlQuery<int?>("exec ClosestFlight @CrewMemberID, @FlightDate", sqlParameterCrew, sqlParameterDate).ToList().First();
                if (days == null)
                    commanders.Add(com.CrewMemberID);
                else if (days > 3 || days < -3)
                    commanders.Add(com.CrewMemberID);
            }
            commanderComboBox.DataSource = commanders;

            List<int?> pilots = new List<int?>();
            foreach (var pil in airport.AllowedCrewMemberModels.Where(a => (a.ModelID == flight.Plane.ModelID && a.CrewMember.Role == "Pilot")))
            {
                SqlParameter sqlParameterCrew = new SqlParameter("@CrewMemberID", pil.CrewMemberID);
                SqlParameter sqlParameterDate = new SqlParameter("@FlightDate", flight.DepartureDate);
                int? days = airport.Database.SqlQuery<int?>("exec ClosestFlight @CrewMemberID, @FlightDate", sqlParameterCrew, sqlParameterDate).ToList().First();
                if (days == null)
                    pilots.Add(pil.CrewMemberID);
                else if (Math.Abs(Convert.ToInt32(days)) > 3)
                    pilots.Add(pil.CrewMemberID);
            }
            pilotComboBox.DataSource = pilots;

            List<int?> stewardesses = new List<int?>();
            foreach (var stew in airport.CrewMembers.Where(c => c.Role == "Stewardess"))
            {
                SqlParameter sqlParameterCrew = new SqlParameter("@CrewMemberID", stew.ID);
                SqlParameter sqlParameterDate = new SqlParameter("@FlightDate", flight.DepartureDate);
                int? days = airport.Database.SqlQuery<int?>("exec ClosestFlight @CrewMemberID, @FlightDate", sqlParameterCrew, sqlParameterDate).ToList().First();
                if (days == null)
                    stewardesses.Add(stew.ID);
                else if (Math.Abs(Convert.ToInt32(days)) > 3)
                    stewardesses.Add(stew.ID);
            }
            stewardess1ComboBox.DataSource = stewardesses;
        }

        private void commanderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int commanderID = Convert.ToInt32(commanderComboBox.Text);
            CrewMember commander = airport.CrewMembers.Where(c => c.ID == commanderID).FirstOrDefault();
            textBoxCommanderName.Text = commander.Name;
            textBoxCommanderSurname.Text = commander.Surname;
            textBoxCommanderAddress.Text = commander.Address;
            dateTimePickerCommanderBirthday.Value = commander.Birthday;
        }

        private void pilotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilotID = Convert.ToInt32(pilotComboBox.Text);
            CrewMember pilot = airport.CrewMembers.Where(c => c.ID == pilotID).FirstOrDefault();
            textBoxPilotName.Text = pilot.Name;
            textBoxPilotSurname.Text = pilot.Surname;
            textBoxPilotAddress.Text = pilot.Address;
            dateTimePickerPilotBirthday.Value = pilot.Birthday;
        }

        private void stewardess1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stewardessID = Convert.ToInt32(stewardess1ComboBox.Text);
            CrewMember stewardess = airport.CrewMembers.Where(c => c.ID == stewardessID).FirstOrDefault();
            textBoxStewardess1Name.Text = stewardess.Name;
            textBoxStewardess1Surname.Text = stewardess.Surname;
            textBoxStewardess1Address.Text = stewardess.Address;
            dateTimePickerStewardess1Birthday.Value = stewardess.Birthday;
            List<int?> stewardesses = new List<int?>();
            foreach (var stew in airport.CrewMembers.Where(c => c.Role == "Stewardess"))
            {
                SqlParameter sqlParameterCrew = new SqlParameter("@CrewMemberID", stew.ID);
                SqlParameter sqlParameterDate = new SqlParameter("@FlightDate", flight.DepartureDate);
                int? days = airport.Database.SqlQuery<int?>("exec ClosestFlight @CrewMemberID, @FlightDate", sqlParameterCrew, sqlParameterDate).ToList().First();
                if(stew.ID != Convert.ToInt32(stewardess1ComboBox.Text))
                    if (days == null)
                        stewardesses.Add(stew.ID);
                    else if (Math.Abs(Convert.ToInt32(days)) > 3)
                        stewardesses.Add(stew.ID);
            }
            stewardess2ComboBox.DataSource = stewardesses;
        }

        private void stewardess2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stewardessID = Convert.ToInt32(stewardess2ComboBox.Text);
            CrewMember stewardess = airport.CrewMembers.Where(c => c.ID == stewardessID).FirstOrDefault();
            textBoxStewardess2Name.Text = stewardess.Name;
            textBoxStewardess2Surname.Text = stewardess.Surname;
            textBoxStewardess2Address.Text = stewardess.Address;
            dateTimePickerStewardess2Birthday.Value = stewardess.Birthday;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
            airport.Flights.Remove(airport.Flights.Where(f => f.ID == flight.ID).FirstOrDefault());
            AdminFlightsForm adminFlightsForm = new AdminFlightsForm(airport, user.ID);
            adminFlightsForm.Show();
        }

        private void buttonCrew_Click(object sender, EventArgs e)
        {
            int commanderID = Convert.ToInt32(commanderComboBox.Text);
            int pilotID = Convert.ToInt32(pilotComboBox.Text);
            int stewardess1ID = Convert.ToInt32(stewardess1ComboBox.Text);
            int stewardess2ID = Convert.ToInt32(stewardess2ComboBox.Text);
            int flightID = flight.ID;
            int ID = airport.Crews.OrderByDescending(c => c.ID).FirstOrDefault().ID;
            Crew commander = new Crew(ID + 1, commanderID, flightID);
            Crew pilot = new Crew(ID + 2, pilotID, flightID);
            Crew stewardess1 = new Crew(ID + 3, stewardess1ID, flightID);
            Crew stewardess2 = new Crew(ID + 4, stewardess2ID, flightID);
            airport.Crews.Add(commander);
            airport.Crews.Add(pilot);
            airport.Crews.Add(stewardess1);
            airport.Crews.Add(stewardess2);
            airport.SaveChanges();
            MessageBox.Show("New flight with crew created!");
            Hide();
            AdminFlightsForm adminFlightsForm = new AdminFlightsForm(airport, user.ID);
            adminFlightsForm.Show();
        }
    }
}
