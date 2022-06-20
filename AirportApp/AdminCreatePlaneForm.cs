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
    public partial class AdminCreatePlaneForm : Form
    {
        AirportModel airport;
        User user;
        public AdminCreatePlaneForm(AirportModel airport, int UserID)
        {
            InitializeComponent();
            this.airport = airport;
            user = airport.Users.Where(u => u.ID == UserID).FirstOrDefault();
        }

        private void linkLabelBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            AdminPlanesForm adminPlanesForm = new AdminPlanesForm(airport, user.ID);
            adminPlanesForm.Show();
        }

        private void AdminCreatePlaneForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDataSet.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.airportDataSet.Model);

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = comboBoxModel.Text;
                int modelID = airport.Models.Where(m => m.Name == name).FirstOrDefault().ID;
                string boardNumber = textBoxBoard.Text;
                int hoursWorked = Convert.ToInt32(numericUpDownHours.Value);
                Plane last = airport.Planes.OrderByDescending(p => p.ID).FirstOrDefault();
                Plane plane = new Plane(last.ID + 1, boardNumber, hoursWorked, modelID);
                airport.Planes.Add(plane);
                airport.SaveChanges();
                MessageBox.Show("New plane created!");
            }
            catch
            {
                MessageBox.Show("Invalid data!");
            }
        }
    }
}
