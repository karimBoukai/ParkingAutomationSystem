using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingAutomationSystem
{
    public partial class VehicleParkingRegistration : Form
    {
        SqlConnection Connection = new SqlConnection("Data Source=localhost;Initial Catalog=Car_Parking;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void VehicleParkingRegistration_Load_1(object sender, EventArgs e)
        {
            EmptyCars();
            Brand();
           
        }

        private void Brand()
        {
            Connection.Open();
            SqlCommand command = new SqlCommand("SELECT Brand FROM BrandInformation", Connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ComboBrand.Items.Add(read["Brand"].ToString());
            }
            Connection.Close();
        }

        private void EmptyCars()
        {
            Connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM CarSituation WHERE Situation = 'EMPTY'", Connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ComboParkingSpace.Items.Add(read["ParkingSpace"].ToString());
            }
            Connection.Close();
        }

        public VehicleParkingRegistration()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VehicleParkingRegistration_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void CarGroup_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Car_Parking_Registartion(Id,Name,Surname,Phone,Email,Plate,Brand,Serial,Color,ParkingSpace,Date) values(@Id,@Name,@Surname,@Phone,@Email,@Plate,@Brand,@Serial,@Color,@ParkingSpace,@Date)", Connection);
            command.Parameters.AddWithValue("@Id", TxtID.Text);
            command.Parameters.AddWithValue("@Name", TxtName.Text);
            command.Parameters.AddWithValue("@Surname", TxtSurname.Text);
            command.Parameters.AddWithValue("@Phone", TxtPhone.Text);
            command.Parameters.AddWithValue("@Email", TxtEmail.Text);
            command.Parameters.AddWithValue("@Plate", TxtPlateNumber.Text);
            command.Parameters.AddWithValue("@Brand", ComboBrand.Text);
            command.Parameters.AddWithValue("@Serial", ComboSerial.Text);
            command.Parameters.AddWithValue("@Color", TxtColor.Text);
            command.Parameters.AddWithValue("@ParkingSpace", ComboParkingSpace.Text);
            command.Parameters.AddWithValue("@Date", DateTime.Now.ToString());



            command.ExecuteNonQuery();


            SqlCommand command2 = new SqlCommand("update CarSituation set Situation = 'FULL' where ParkingSpace='" + ComboParkingSpace.SelectedItem+"'", Connection);
            command2.ExecuteNonQuery();
            Connection.Close();
            MessageBox.Show("Vehicle Parking Registered Successfully", "Saved");
            ComboParkingSpace.Items.Clear();
            EmptyCars();
            ComboBrand.Items.Clear();
            Brand();
            ComboSerial.Items.Clear();
            foreach (Control item in PersonGroup.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in CarInformation.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }

            }
            foreach (Control item in CarInformation.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }

        private void ComboParkingSpace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnBrand_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            brand.ShowDialog();

        }

        private void BtnSerial_Click(object sender, EventArgs e)
        {
            Serial serial = new Serial();
            serial.ShowDialog();
        }

        private void ComboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand("SELECT Brand ,Serial FROM SerialInformation where Brand= '"+ComboBrand.SelectedItem+"' ", Connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ComboSerial.Items.Add(read["Serial"].ToString());
            }
            Connection.Close();
        }
    }
}
