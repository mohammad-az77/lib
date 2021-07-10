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

namespace library_project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("server=(Local);Database=Library;Integrated Security=True"); 
            try { con1.Open(); }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            SqlCommand c1 = new SqlCommand();
            c1.Connection = con1;
            c1.CommandText = "select * from login where user_code = '" + textBox1.Text + "' and pass = '" + textBox2.Text + "' ";
            SqlDataReader dr = c1.ExecuteReader();
            if (dr.Read())
            {
                main m = new main();
                m.Show();
            }
            else {
                MessageBox.Show("کد کاربری با رمز عبور اشتباه است");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            search se = new search();
            se.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
