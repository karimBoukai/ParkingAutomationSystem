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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }
        SqlConnection Connection = new SqlConnection("Data Source=localhost;Initial Catalog=Car_Parking;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        DataSet ds = new DataSet();
        private void Sales_Load(object sender, EventArgs e)
        {
            SalesList();
            Connection.Open();
            SqlCommand command = new SqlCommand("select SUM(Total) from Sales", Connection);
            label1.Text = "Total Sales Amount: " + command.ExecuteScalar() + " $";
            Connection.Close();
        }

        private void SalesList()
        {
            Connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Sales", Connection);
            adtr.Fill(ds, "Sales");
            dataGridView1.DataSource = ds.Tables["Sales"];
            Connection.Close();
        }

    }
}
