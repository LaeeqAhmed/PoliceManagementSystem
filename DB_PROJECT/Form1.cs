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
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-JSLCVG5\SHOZAB_17F8092;Initial Catalog=police_management_system;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
          //  SqlConnection con = new SqlConnection(@"Data Source=desktop-olv0avb\sqlexpress;Initial Catalog=police_management_system;Integrated Security=True;Pooling=False");
            //string query = " select * from district_table ";
            //SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            //DataTable d = new DataTable();
            //sda.Fill(d);
            //DataTable table_for_combo = new DataTable();
            //table_for_combo.Columns.Add("Name");
            //foreach(DataRow dr in d.Rows)
            //{
            //    table_for_combo.Rows.Add(dr["Name"].ToString());
            //}
            //comboBox1.DataSource = table_for_combo;
            //comboBox1.DisplayMember = "Name";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // SqlConnection con = new SqlConnection(@"Data Source=desktop-olv0avb\sqlexpress;Initial Catalog=police_management_system;Integrated Security=True;Pooling=False");
            string query = "select * from login_table where user_name='" + textBox1.Text.Trim() + "'and password='" + textBox2.Text.Trim() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            DataTable d = new DataTable();
            sda.Fill(d);
            if (d.Rows.Count == 1)
            {
                string account_type = d.Rows[0]["account_type"].ToString();
                switch (account_type)
                {
                    case "admin":
                        adminform admin = new adminform();
                        this.Hide();
                        admin.Show();
                        break;
                    case "employee":
                        emp_form emp = new emp_form();
                        this.Hide();
                        emp.Show();
                        break;
                    case "fir":
                        fir_form fir = new fir_form();
                        this.Hide();
                        fir.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Incorrect user name or password");
            }
        }

    }
}

