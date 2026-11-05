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


namespace ParkingAutomationSystem
{
    public partial class CarParkingSpaces : Form
    {
        public CarParkingSpaces()
        {
            InitializeComponent();
        }
        

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Connection = new SqlConnection("Data Source=localhost;Initial Catalog=Car_Parking;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void CarParkingSpaces_Load(object sender, EventArgs e)
        {
            EmptyParkingSpaces();

            FullParkingSpace();
            Connection.Open();

            SqlCommand command = new SqlCommand("select *from Car_Parking_Registartion", Connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == read["ParkingSpace"].ToString() )
                        {
                           item.Text = read["Plate"].ToString();
                        }
                    }
                }
            }


            Connection.Close();
        }

        private void FullParkingSpace()
        {
            Connection.Open();

            SqlCommand command = new SqlCommand("SELECT  *FROM CarSituation;", Connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == read["ParkingSpace"].ToString() && read["Situation"].ToString() == "FULL")
                        {
                            item.BackColor = Color.Red;
                        }
                    }
                }
            }


            Connection.Close();
        }

        private void EmptyParkingSpaces()
        {
            int counter = 1;
            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.Text = "P-" + counter;
                    item.Name = "P-" + counter;
                    counter++;
                }

                {

                }
            }
        }
    }
}
