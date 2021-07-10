using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace library_project
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_Load(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strcon = "server=(Local);Database=Library;Integrated Security=true";
            md.strsql = "select * from books where book_name = N'" + textBox1.Text.ToString() + "'";
            dataGridView1.DataSource = md.Showdata().DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strcon = "server=(Local);Database=Library;Integrated Security=true";
            md.strsql = "select * from books where book_code = '" + textBox2.Text + "'";
            dataGridView1.DataSource = md.Showdata().DefaultView;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
