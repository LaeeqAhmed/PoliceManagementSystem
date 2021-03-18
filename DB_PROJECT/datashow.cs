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
    
    public partial class datashow : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-JSLCVG5\SHOZAB_17F8092;Initial Catalog=police_management_system;Integrated Security=True");


        public datashow(DataTable d)
        {
            InitializeComponent();
            dataGridView2.DataSource = d;
        }

        private void datashow_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            adminform admin = new adminform();
            this.Hide();
            admin.Show();
        }

        

        //private void dataGridView2_Click(object sender, EventArgs e)
        //{
        //    adminform display = new adminform();
        //   // display = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        //}

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["police_id"].Value.ToString());
            //SqlConnection c = new SqlConnection(@"Data Source=desktop-olv0avb\sqlexpress;Initial Catalog=police_management_system;Integrated Security=True;Pooling=False");
            string query = " select * from employee_table where police_id="+id+" ";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            DataTable d = new DataTable();
            sda.Fill(d);
            adminform display = new adminform(d);
            this.Hide();
            display.Show();
        }
    }
}
