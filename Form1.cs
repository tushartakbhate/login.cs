using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace library_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=TUSHAR-PC;Initial Catalog=master;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            //con.Open();
            string query="select * from login where username='"+textBox1.Text+"'and password='"+textBox2.Text+"'";
                SqlDataAdapter sda=new SqlDataAdapter(query,con);
            DataTable db=new DataTable();
            sda.Fill(db);
            if(db.Rows.Count==0)
            {
                Form2 obj=new Form2();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("check your username and passsword");
            }
        }
    }
}
