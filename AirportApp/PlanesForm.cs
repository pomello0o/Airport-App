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
    public partial class PlanesForm : Form
    {
        AirportModel airport;
        User user;
        public PlanesForm(AirportModel airport, int UserID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
            buttonPlanes.BackColor = Color.Gold;
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

        private void buttonPlanes_Click(object sender, EventArgs e)
        {
            Hide();
            PlanesForm planesForm = new PlanesForm(airport, user.ID);
            planesForm.Show();
        }

        private void PlanesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDataSet1.Planes' table. You can move, or remove it, as needed.
            this.planesTableAdapter.Fill(this.airportDataSet1.Planes);

        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            planesBindingSource.Filter = "";
            string model = textBoxModel.Text;
            string places = numericUpDownPlaces.Value.ToString();
            string load = numericUpDownLoad.Value.ToString();
            string hours = numericUpDownHours.Value.ToString();
            string operationPlaces = SetOperationPlaces();
            string operationLoad = SetOperationLoad();
            string operationHours = SetOperationHours();
            Console.WriteLine(operationPlaces);
            if (model != "")
                planesBindingSource.Filter += string.Format("Name like '%{0}%'", model);
            if (places != null && operationPlaces != "")
                SetNumericFilter(places, "PlacesNumber", operationPlaces);
            if (load != null && operationLoad != "")
                SetNumericFilter(load, "LoadCapacity", operationLoad);
            if (hours != null && operationHours != "")
                SetNumericFilter(hours, "HoursWorked", operationHours);
        }
        private string SetOperationPlaces()
        {
            if (radioButtonMore.Checked)
                return ">";
            else if (radioButtonLess.Checked)
                return "<";
            else if (radioButtonEq.Checked)
                return "=";
            else return "";
        }
        private string SetOperationLoad()
        {
            if (radioButtonMoreLoad.Checked)
                return ">";
            else if (radioButtonLessLoad.Checked)
                return "<";
            else if (radioButtonEqLoad.Checked)
                return "=";
            else return "";
        }
        private string SetOperationHours()
        {
            if (radioButtonMoreHours.Checked)
                return ">";
            else if (radioButtonLessHours.Checked)
                return "<";
            else if (radioButtonEqHours.Checked)
                return "=";
            else return "";
        }
        private void SetNumericFilter(string value, string name, string operation)
        {
            if(planesBindingSource.Filter.Length > 0)
            {
                planesBindingSource.Filter += string.Format(" AND {0} {1} {2}", name, operation, value);
            } else
                planesBindingSource.Filter += string.Format("{0} {1} {2}", name, operation, value);
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
