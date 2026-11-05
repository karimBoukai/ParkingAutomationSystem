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
    public partial class Serial : Form
    {
        public Serial()
        {
            InitializeComponent();
        }
        SqlConnection Connection = new SqlConnection("Data Source=localhost;Initial Catalog=Car_Parking;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void Serial_Load(object sender, EventArgs e)
        {
            Brand();

        }

        private void Brand()
        {
            Connection.Open();
            SqlCommand command = new SqlCommand("SELECT Brand FROM BrandInformation", Connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["Brand"].ToString());
            }
            Connection.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into SerialInformation(Brand,Serial) values('" + comboBox1.Text + "','"+textBox1.Text + "')", Connection);
            
            command.ExecuteNonQuery();
            Connection.Close();
            MessageBox.Show("Brand specific vehicle series Added.");
            textBox1.Clear();
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            Brand();
        }
    }
}
