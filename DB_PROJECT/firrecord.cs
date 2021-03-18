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
    public partial class firrecord : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-JSLCVG5\SHOZAB_17F8092;Initial Catalog=police_management_system;Integrated Security=True");

        public firrecord(DataTable d)
        {
            InitializeComponent();
            dataGridView_fir.DataSource = d;
        }

        private void back_Click(object sender, EventArgs e)
        {
            fir_form logout = new fir_form();
            this.Hide();
            logout.Show();
        }

        private void dataGridView_fir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView_fir.Rows[e.RowIndex].Cells["fir_no"].Value.ToString());
            //SqlConnection c = new SqlConnection(@"Data Source=desktop-olv0avb\sqlexpress;Initial Catalog=police_management_system;Integrated Security=True;Pooling=False");
            string query = " select * from fir_table where fir_no=" + id + " ";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            DataTable d = new DataTable();
            sda.Fill(d);
            fir_form display = new fir_form(d);
            this.Hide();
            display.Show();
        }

        private void dataGridView_fir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
