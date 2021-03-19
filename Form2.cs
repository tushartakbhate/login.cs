using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;

namespace library_management_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
           
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book obj = new book();
            obj.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student obj = new student();
            obj.Show();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff obj = new staff();
            obj.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
