using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingAutomationSystem
{
    public partial class FRMHomePage : Form
    {
        public FRMHomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VehicleParkingRegistration Registration = new VehicleParkingRegistration();
            Registration.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarParkingSpaces Spaces = new CarParkingSpaces();
            Spaces.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VehicleParkingExitPage exit = new VehicleParkingExitPage();
            exit.ShowDialog();

        }

        private void FRMHomePage_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.ShowDialog();
        }
    }
}
