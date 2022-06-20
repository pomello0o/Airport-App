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
    public partial class AdminPlanesForm : Form
    {
        AirportModel airport;
        User user;
        public AdminPlanesForm(AirportModel airport, int UserID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
            buttonPlanes.BackColor = Color.Gold;
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

        private void AdminPlanesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDataSet.Plane' table. You can move, or remove it, as needed.
            this.planeTableAdapter.Fill(this.airportDataSet.Plane);
            // TODO: This line of code loads data into the 'airportDataSet.Plane' table. You can move, or remove it, as needed.
            this.planeTableAdapter.Fill(this.airportDataSet.Plane);
        }

        private void planeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.planeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airportDataSet);

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Hide();
            AdminCreatePlaneForm adminCreatePlaneForm = new AdminCreatePlaneForm(airport, user.ID);
            adminCreatePlaneForm.Show();
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
            if (planeBindingSource.Filter.Length > 0)
            {
                planeBindingSource.Filter += string.Format(" AND {0} {1} {2}", name, operation, value);
            }
            else
                planeBindingSource.Filter += string.Format("{0} {1} {2}", name, operation, value);
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            planeBindingSource.Filter = "";
            string modelID = numericUpDownModel.Value.ToString();
            string board = textBoxBoard.Text;
            string hours = numericUpDownHours.Value.ToString();
            string operationHours = SetOperationHours();
            if (board != "")
                planeBindingSource.Filter += string.Format("BoardNumber like '%{0}%'", board);
            if (hours != null && hours != "" && hours != "0")
                SetNumericFilter(hours, "HoursWorked", operationHours);
            if (modelID != null && modelID != "" && modelID != "0")
                SetNumericFilter(modelID, "ModelID", "=");
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
