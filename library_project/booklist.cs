using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace library_project
{
    public partial class booklist : Form
    {
        public booklist()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strcon = "server=(Local);Database=Library;Integrated Security=true";
            md.strsql = "select * from books";
            dataGridView1.DataSource = md.Showdata().DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strcon = "server=(Local);Database=Library;Integrated Security=true";
            md.strsql = "select * from books where book_code = '" +textBox1.Text+ "'";
            dataGridView1.DataSource = md.Showdata().DefaultView;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
