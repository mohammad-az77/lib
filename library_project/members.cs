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
    public partial class members : Form
    {
        public members()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strcon = "server=(Local);Database=Library;Integrated Security=true";
            md.strsql = "select * from members";
            dataGridView1.DataSource = md.Showdata().DefaultView;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strcon = "server=(Local);Database=Library;Integrated Security=True";
            md.strsql = "Insert into members (member_code,member_name,sex,date_of_birth,contact_number) Values('" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox4.Text + "','" + textBox3.Text.ToString() + "','"+textBox5.Text.ToString()+"')";
            md.ManData();
            MessageBox.Show("کاربر ثبت شد");
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
            MyData md = new MyData();
            md.strcon = "server=(Local);Database=Library;Integrated Security=True";
            md.strsql = "Delete from members where member_code='" + textBox1.Text + "'";
            md.ManData();
            MessageBox.Show(".عضو حذف شد");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strcon = "server=(Local);Database=Library;Integrated Security=True";
            md.strsql = "UPDATE members  SET member_name= N'" + textBox2.Text + "', sex= N'" + textBox4.Text + "', date_of_birth = '" + textBox3.Text.ToString() + "', contact_number= N'" + textBox5.Text.ToString() + "' where member_code = '" + textBox1.Text + "'";
            md.ManData();
            MessageBox.Show("کاربر ویرایش شد");
        }
    }
}
