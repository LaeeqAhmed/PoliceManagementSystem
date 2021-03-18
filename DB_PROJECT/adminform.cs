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
    public partial class adminform : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-JSLCVG5\SHOZAB_17F8092;Initial Catalog=police_management_system;Integrated Security=True");



        public adminform()
        {
            InitializeComponent();
        }
        public adminform(DataTable d)
        {
            InitializeComponent();
            foreach(DataRow dr in d.Rows)
            {
                text_id.Text = dr["police_id"].ToString();
                text_Name.Text= dr["Name"].ToString();
                text_rank.Text = dr["Rank"].ToString();
                text_address.Text= dr["Address"].ToString();
                text_dob.Text = dr["D.O.B"].ToString();
                textBox1.Text = dr["Grade"].ToString();
                text_cnic.Text = dr["CNIC"].ToString();
                text_doe.Text = dr["date_of_employment"].ToString();
                textBox2.Text = dr["date_of_retirement"].ToString();
                comboBox1.Text = dr["Gender"].ToString();

            }
        }


        private void logout_btn_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }

        private void showdata_btn_Click(object sender, EventArgs e)
        {
           // SqlConnection c = new SqlConnection(@"Data Source=desktop-olv0avb\sqlexpress;Initial Catalog=police_management_system;Integrated Security=True;Pooling=False");
            string query = "select * from employee_table ";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            DataTable d = new DataTable();
            sda.Fill(d);
            datashow display = new datashow(d);
            this.Hide();
            display.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
           // SqlConnection c = new SqlConnection(@"Data Source=desktop-olv0avb\sqlexpress;Initial Catalog=police_management_system;Integrated Security=True;Pooling=False");
            string query = "insert into employee_table values("+text_id.Text+",'"+text_Name.Text+"','"+text_rank.Text+"','"+text_address.Text+"','"+text_dob.Text+"',"+textBox1.Text+",'"+text_cnic.Text+"','"+text_doe.Text+"','"+textBox2.Text+"','"+comboBox1.Text+"') ";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            DataTable d = new DataTable();
            sda.Fill(d);
            datashow display = new datashow(d);
            this.Hide();
            display.Show();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
           // SqlConnection c = new SqlConnection(@"Data Source=desktop-olv0avb\sqlexpress;Initial Catalog=police_management_system;Integrated Security=True;Pooling=False");
            string query = " delete from employee_table where police_id="+text_id.Text+" ";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            DataTable d = new DataTable();
            sda.Fill(d);
            datashow display = new datashow(d);
            this.Hide();
            display.Show();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
           // SqlConnection c = new SqlConnection(@"Data Source=desktop-olv0avb\sqlexpress;Initial Catalog=police_management_system;Integrated Security=True;Pooling=False");
            string query = " update employee_table set police_id="+text_id.Text+" , Name = '"+text_Name.Text+"' , Rank='"+text_rank.Text+"' , Address='"+text_address.Text+"' , [D.O.B]='"+text_dob.Text+"' , Grade="+textBox1.Text+" , CNIC='"+text_cnic.Text+"' , date_of_employment='"+text_doe.Text+"' , date_of_retirement='"+textBox2.Text+"' , Gender='"+comboBox1.Text+"' where police_id="+text_id.Text+" ";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            DataTable d = new DataTable();
            sda.Fill(d);
            datashow display = new datashow(d);
            this.Hide();
            display.Show();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
           // SqlConnection c = new SqlConnection(@"Data Source=desktop-olv0avb\sqlexpress;Initial Catalog=police_management_system;Integrated Security=True;Pooling=False");
            string query = "select * from employee_table where police_id="+text_id.Text+" ";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            DataTable d = new DataTable();
            sda.Fill(d);
            if (d.Rows.Count == 0)
            {
                MessageBox.Show("WARNING! YOU MIGHT INPUTTED WRONG ID PLEASE TRY AGAIN THANKS 😁");
            }
            else
            {
                datashow display = new datashow(d);
                this.Hide();
                display.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text_id.Text = "";
            text_Name.Text = "";
            text_rank.Text = "";
            text_address.Text = "";
            text_dob.Text = "";
            textBox1.Text= "";
            text_cnic.Text = "";
            text_doe.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
        }

        private void pstation_Click(object sender, EventArgs e)
        {
            policestation pstation = new policestation();
            this.Hide();
            pstation.Show();
        }
    }
}
