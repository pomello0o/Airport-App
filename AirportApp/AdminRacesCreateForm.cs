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
    public partial class AdminRacesCreateForm : Form
    {
        AirportModel airport;
        User user;
        public AdminRacesCreateForm(AirportModel airport, int UserID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
        }

        private void linkLabelBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            AdminRacesForm adminRacesForm = new AdminRacesForm(airport, user.ID);
            adminRacesForm.Show();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int raceNumber = Convert.ToInt32(numericUpDownRace.Value);
                if(airport.Races.Where(r => r.RaceNumber == raceNumber).Count() > 0)
                {
                    MessageBox.Show($"Race with number {raceNumber} already exists!");
                    return;
                }
                string departurePoint = textBoxDeparturePoint.Text;
                string destinationPoint = textBoxDestinationPoint.Text;
                int depH = Convert.ToInt32(numericUpDownDepartureHours.Value);
                int depM = Convert.ToInt32(numericUpDownDepartureMin.Value);
                int depS = Convert.ToInt32(numericUpDownDepartureSec.Value);
                int landH = Convert.ToInt32(numericUpDownLandingHours.Value);
                int landM = Convert.ToInt32(numericUpDownLandingMin.Value);
                int landS = Convert.ToInt32(numericUpDownLandingSec.Value);
                TimeSpan departureTime = new TimeSpan(depH, depM, depS);
                TimeSpan landingTime = new TimeSpan(landH, landM, landS);
                Race last = airport.Races.OrderByDescending(r => r.ID).FirstOrDefault();
                Race race = new Race(last.ID + 1, departurePoint, destinationPoint, departureTime, landingTime, raceNumber);
                airport.Races.Add(race);
                airport.SaveChanges();
                MessageBox.Show("New race created!");
            }
            catch
            {
                MessageBox.Show("Invalid data!");
            }
        }
    }
}
