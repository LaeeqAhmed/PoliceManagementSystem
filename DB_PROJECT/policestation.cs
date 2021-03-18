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
namespace DB_PROJECT
{
    public partial class policestation : Form
    {
        public policestation()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-JSLCVG5\SHOZAB_17F8092;Initial Catalog=police_management_system;Integrated Security=True");
            string query = "insert into police_station_table values (" + textBox1.Text + " , '" + textBox2.Text + "', " + textBox3.Text + ",'" + comboBox1.Text + "', '" + comboBox2.Text + "' , '" + comboBox3.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            DataTable d = new DataTable();
            sda.Fill(d);
        }
    }
}
