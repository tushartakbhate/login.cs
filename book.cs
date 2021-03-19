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
    public partial class book : Form
    {
        SqlConnection con = new SqlConnection("Data Source=TUSHAR-PC;Initial Catalog=master;Integrated Security=True");
        public book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query="insert into books (Id,Title,Author,Edition,Publication,Email,price)values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"')";
            SqlDataAdapter sda=new SqlDataAdapter(query,con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Record sucessfully");
            con.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query="update books set Title='" + textBox2.Text + "',Author='" + textBox3.Text + "',Edition='" + textBox4.Text + "',Publication='" + textBox5.Text + "',Email='" + textBox6.Text + "',price='" + textBox7.Text + "' where Id='"+textBox1.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Record Update sucessfully");
            con.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from books where Id='" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Record delete sucessfully");
            con.Close();
            
        }
    }
}
