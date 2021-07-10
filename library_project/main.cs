using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace library_project
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ثبتکتابجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            books b = new books();
            b.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void لیستکتابهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            booklist b1 = new booklist();
            b1.Show();
        }

        private void کارکنانکتابخانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            library_staff l = new library_staff();
            l.Show();
        }

        private void بخشبرگشتکتابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            @return r = new @return();
            r.Show();

        }

        private void بحشامانتکتابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrow b = new borrow();
            b.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void ثبتاعضاءجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            members m = new members();
            m.Show();
        }
    }
}
