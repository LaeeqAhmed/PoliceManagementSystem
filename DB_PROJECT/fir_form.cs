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
    public partial class fir_form : Form
    {
        public fir_form()
        {
            InitializeComponent();
        }
        public fir_form(DataTable d)
        {
            InitializeComponent();
            foreach (DataRow dr in d.Rows)
            {
                textBox1.Text = dr["fir_no"].ToString();
                textBox2.Text = dr["wriiten_by"].ToString();
                textBox3.Text = dr["police_station_no"].ToString();
                textBox4.Text = dr["crime_no"].ToString();
                textBox5.Text = dr["victum"].ToString();
                textBox6.Text = dr["suspect"].ToString();
                textBox7.Text = dr["time_stamp"].ToString();
                details.Text = dr["details"].ToString();
            }
        }
        private void outbtn_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            this.Hide();
            logout.Show();
        }

        private void submit_detail_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(@"Data Source=desktop-olv0avb\sqlexpress;Initial Catalog=police_management_system;Integrated Security=True;Pooling=False");
            string query = "insert into fir_table values("+textBox1.Text+" , "+textBox2.Text+" , '"+textBox3.Text+"' , '"+textBox4.Text+"' , '"+textBox5.Text+"' , '"+textBox6.Text+"' , '"+textBox7.Text+"' , '"+details.Text+"' )";
            SqlDataAdapter sda = new SqlDataAdapter(query, c);
            DataTable d = new DataTable();
            sda.Fill(d);
            firrecord display = new firrecord(d);
            this.Hide();
            display.Show();
        }

        private void show_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(@"Data Source=desktop-olv0avb\sqlexpress;Initial Catalog=police_management_system;Integrated Security=True;Pooling=False");
            string query = "select * from fir_table ";
            SqlDataAdapter sda = new SqlDataAdapter(query, c);
            DataTable d = new DataTable();
            sda.Fill(d);
            firrecord display = new firrecord(d);
            this.Hide();
            display.Show();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            details.Text = "";
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(@"Data Source=desktop-olv0avb\sqlexpress;Initial Catalog=police_management_system;Integrated Security=True;Pooling=False");
            string query = "update fir_table set fir_no=" + textBox1.Text + ", wriiten_by=" + textBox2.Text + ", police_station_no='" + textBox3.Text + "', crime_no='" + textBox4.Text + "' , victum='" + textBox5.Text + "', suspect='" + textBox6.Text + "', time_stamp='" + textBox7.Text + "', details='" + details.Text + "' where fir_no="+textBox1.Text+" ";
            SqlDataAdapter sda = new SqlDataAdapter(query, c);
            DataTable d = new DataTable();
            sda.Fill(d);
            firrecord display = new firrecord(d);
            this.Hide();
            display.Show();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(@"Data Source=desktop-olv0avb\sqlexpress;Initial Catalog=police_management_system;Integrated Security=True;Pooling=False");
            string query = "delete from fir_table where fir_no="+textBox1.Text+"";
            SqlDataAdapter sda = new SqlDataAdapter(query, c);
            DataTable d = new DataTable();
            sda.Fill(d);
            firrecord display = new firrecord(d);
            this.Hide();
            display.Show();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(@"Data Source=desktop-olv0avb\sqlexpress;Initial Catalog=police_management_system;Integrated Security=True;Pooling=False");
            string query = "select * from fir_table where fir_no="+textBox1.Text+" ";
            SqlDataAdapter sda = new SqlDataAdapter(query, c);
            DataTable d = new DataTable();
            sda.Fill(d);
            if (d.Rows.Count == 0)
            {
                MessageBox.Show("WARNING! THE DATA YOU MAY SEARCH IS NOT IN THE DATABASE PLEASE TRY AGAIN THANKS 😁");
            }
            else

            {
                firrecord display = new firrecord(d);
                this.Hide();
                display.Show();
            }
        }
    }
}
