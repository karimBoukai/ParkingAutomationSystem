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
    public partial class Brand : Form
    {
        public Brand()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Connection = new SqlConnection("Data Source=localhost;Initial Catalog=Car_Parking;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void Brand_Load(object sender, EventArgs e)
        {
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into BrandInformation(Brand) values('" + textBox1.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
            MessageBox.Show("Brand Added Successfully");
            textBox1.Clear();
          
            
        }
    }
}
