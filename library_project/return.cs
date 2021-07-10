using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace library_project
{
    public partial class @return : Form
    {
        public @return()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strcon = "server=(Local);Database=Library;Integrated Security=True";
            md.strsql = "UPDATE borrowed SET actual_return_date='" + textBox3.Text.ToString() + "',delay='" + textBox4.Text + "'where member_code='" + textBox1.Text + "'AND book_code='" + textBox2.Text + "'";
            md.ManData();
            MyData md1 = new MyData();
            md1.strcon = "server=(Local);Database=Library;Integrated Security=True";
            md1.strsql = "UPDATE books  SET borrow_style= N'" + textBox5.Text + "' where book_code = '" + textBox2.Text + "' ";
            md1.ManData();
            MessageBox.Show("امانت ثبت شد");
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strcon = "server=(Local);Database=Library;Integrated Security=true";
            md.strsql = "select * from borrowed";
            dataGridView1.DataSource = md.Showdata().DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strcon = "server=(Local);Database=Library;Integrated Security=true";
            md.strsql = "select * from borrowed where member_code= '"+ textBox1.Text+"'";
            dataGridView1.DataSource = md.Showdata().DefaultView;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strcon = "server=(Local);Database=Library;Integrated Security=True";
            md.strsql = "UPDATE borrowed SET actual_return_date='" + textBox3.Text.ToString() + "',delay='" + textBox4.Text + "'where member_code='" + textBox1.Text + "'AND book_code='" + textBox2.Text + "'";
            md.ManData();
            MyData md1 = new MyData();
            md1.strcon = "server=(Local);Database=Library;Integrated Security=True";
            md1.strsql = "UPDATE books  SET borrow_style= N'" + textBox5.Text + "' where book_code = '" + textBox2.Text + "' ";
            md1.ManData();
            MessageBox.Show("امانت ویرایش شد");
        }
    }
}
