using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace library_project
{
    public partial class library_staff : Form
    {
        public library_staff()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("server=(Local);Database=Library;Integrated Security=True"); try { con1.Open(); }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            SqlCommand c1 = new SqlCommand();
            c1.Connection = con1;
            c1.CommandText = "select * from login where user_code = '" + textBox1.Text + "' and pass = '" + textBox2.Text + "' ";
            SqlDataReader dr = c1.ExecuteReader();
            if (dr.Read())
            {
                MyData md = new MyData();
                md.strcon = "server=(Local);Database=Library;Integrated Security=True";
                md.strsql = "Insert into login Values('" + textBox3.Text + "','" + textBox4.Text + "',N'" + textBox5.Text + "',N'" + textBox6.Text + "')";
                md.ManData();
                MessageBox.Show("کاربر ثبت شد");
            }
            else
            {
                MessageBox.Show("فقط مدیر کتابخانه مجاز به ثبت کاربر جدید است");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("server=(Local);Database=Library;Integrated Security=True"); try { con1.Open(); }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            SqlCommand c1 = new SqlCommand();
            c1.Connection = con1;
            c1.CommandText = "select * from login where user_code = '" + textBox1.Text + "' and pass = '" + textBox2.Text + "' ";
            SqlDataReader dr = c1.ExecuteReader();
            if (dr.Read())
            {
                MyData md = new MyData();
                md.strcon = "server=(Local);Database=Library;Integrated Security=True";
                md.strsql = "Delete from login where user_code='"+textBox3.Text+"'";
                md.ManData();
                MessageBox.Show(".کاربر حذف شد");
            }
            else
            {
                MessageBox.Show("فقط مدیر کتابخانه مجاز به این عملیات است");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("server=(Local);Database=Library;Integrated Security=True"); try { con1.Open(); }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            SqlCommand c1 = new SqlCommand();
            c1.Connection = con1;
            c1.CommandText = "select * from login where user_code = '" + textBox1.Text + "' and pass = '" + textBox2.Text + "' ";
            SqlDataReader dr = c1.ExecuteReader();
            if (dr.Read())
            {
                MyData md = new MyData();
                md.strcon = "server=(Local);Database=Library;Integrated Security=True";
                md.strsql = "UPDATE login  SET pass= '"+textBox4.Text+"', name= N'"+textBox5.Text+"', position = N'"+textBox6.Text+ "' where  user_code= '" + textBox3.Text + "'";
                md.ManData();
                MessageBox.Show("اطلاعات کاربر ویرایش شد");
            }
            else
            {
                MessageBox.Show("فقط مدیر کتابخانه مجاز به ثبت کاربر جدید است");
            }
        }
    }
    }

