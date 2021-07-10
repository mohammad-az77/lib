using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace library_project
{
    public partial class books : Form
    {
        public books()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strcon = "server=(Local);Database=Library;Integrated Security=true";
            md.strsql = "select * from books";
            dataGridView1.DataSource = md.Showdata().DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strcon = "server=(Local);Database=Library;Integrated Security=True";
            md.strsql = "Delete from books where book_code='" + textBox1.Text + "'";
            md.ManData();
            MessageBox.Show(".کتاب حذف شد");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strcon = "server=(Local);Database=Library;Integrated Security=True";
            md.strsql = "Insert into books Values('" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "',N'" + textBox4.Text + "',N'" + textBox5.Text + "')";
            md.ManData();
            MessageBox.Show("کتاب ثبت شد");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strcon = "server=(Local);Database=Library;Integrated Security=True";
            md.strsql = "UPDATE books  SET book_name= N'" + textBox2.Text + "', author_name= N'" + textBox3.Text + "', publication_year = '" + textBox4.Text.ToString() + "', borrow_style= N'" + textBox5.Text + "' where book_code = '"+ textBox1.Text+"'";
            md.ManData();
            MessageBox.Show("کتاب ویرایش شد");
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
    }
}
