using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingAutomationSystem
{
    public partial class VehicleParkingExitPage : Form
    {
        public VehicleParkingExitPage()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand Command = new SqlCommand("select *from Car_Parking_Registartion where ParkingSpace='" + ComboParkingSpace.SelectedItem + "'", Connection);
            SqlDataReader read = Command.ExecuteReader();
            while (read.Read())
            {
                TxtParkSpace.Text = read["ParkingSpace"].ToString();
                TxtID.Text = read["ID"].ToString();
                TxtName.Text = read["Name"].ToString();
                TxtSurname.Text = read["Surname"].ToString();
                TxtBrand.Text = read["Brand"].ToString();
                TxtSerial.Text = read["Serial"].ToString();
                Plate.Text = read["Plate"].ToString();
                lblEntryDate.Text = read["Date"].ToString();
                lblExitDate.Text = DateTime.Now.ToString();
            }
            Connection.Close();
            DateTime Entry, Exit;
            Entry = DateTime.Parse(lblEntryDate.Text);
            Exit = DateTime.Parse(lblExitDate.Text);
            TimeSpan difference;
            difference = Exit - Entry;
            lblDuration.Text = difference.TotalHours.ToString("0.00");

            lblTotal.Text=(double.Parse(lblDuration.Text) * (2.5)).ToString("0.00");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Connection = new SqlConnection("Data Source=localhost;Initial Catalog=Car_Parking;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void VehicleParkingExitPage_Load(object sender, EventArgs e)
        {
            FullSpaces();
            Plates();
            timer1.Enabled = true;

        }

        private void Plates()
        {
            Connection.Open();
            SqlCommand Command = new SqlCommand("select * from Car_Parking_Registartion ", Connection);
            SqlDataReader read = Command.ExecuteReader();
            while (read.Read())
            {
                ComboPlate.Items.Add(read["Plate"].ToString());
            }
            Connection.Close();
        }

        private void FullSpaces()
        {
            Connection.Open();
            SqlCommand Command = new SqlCommand("select * from CarSituation where Situation ='FULL'", Connection);
            SqlDataReader read = Command.ExecuteReader();
            while (read.Read())
            {
                ComboParkingSpace.Items.Add(read["ParkingSpace"].ToString());
            }
            Connection.Close();
        }

        private void ComboPlate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand Command = new SqlCommand("select * from Car_Parking_Registartion where Plate='" + ComboPlate.SelectedItem +"'", Connection);
            SqlDataReader read = Command.ExecuteReader();
            while (read.Read())
            {
                TxtParkingSpace.Text = read["ParkingSpace"].ToString();
            }
            Connection.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblExitDate.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand("delete from Car_Parking_Registartion where Plate='" + Plate.Text + "'", Connection);
            command.ExecuteNonQuery();

            SqlCommand command2 = new SqlCommand("update  CarSituation set Situation='EMPTY' where ParkingSpace='" + TxtParkSpace.Text + "'", Connection);
            command2.ExecuteNonQuery();

            SqlCommand command3 = new SqlCommand("insert into Sales(ID,ParkingSpace,Plate,Entry_Date,Exit_Date,Duration,Total) values(@ID,@ParkingSpace,@Plate,@Entry_Date,@Exit_Date,@Duration,@Total)", Connection);
            command3.Parameters.AddWithValue("@ID", TxtID.Text);
            command3.Parameters.AddWithValue("@ParkingSpace", TxtParkSpace.Text);
            command3.Parameters.AddWithValue("@Plate", TxtPlate.Text);
            command3.Parameters.AddWithValue("@Entry_Date", lblEntryDate.Text);
            command3.Parameters.AddWithValue("@Exit_Date", lblExitDate.Text);
            command3.Parameters.AddWithValue("@Duration", double.Parse(lblDuration.Text));
            command3.Parameters.AddWithValue("@Total", double.Parse(lblTotal.Text));
            
            command3.ExecuteNonQuery();

            Connection.Close();
            MessageBox.Show("Vehicle Exit Process Completed.");
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    TxtParkingSpace.Text = "";
                    ComboParkingSpace.Text = "";
                    ComboPlate.Text = "";
                }
            }
            ComboPlate.Items.Clear();
            ComboParkingSpace.Items.Clear();
            FullSpaces();
            Plates();

        }
    }
}
