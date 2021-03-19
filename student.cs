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
    public partial class student : Form
    {
        SqlConnection con = new SqlConnection("Data Source=TUSHAR-PC;Initial Catalog=master;Integrated Security=True");
        public student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into student(rollno,Firstname,Lastname,Branch,mobileno,class,Email)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Record sucessfully");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update student set Firtsname='" + textBox2.Text + "',Lastname='" + textBox3.Text + "',Branch='" + textBox4.Text + "',mobileno='" + textBox5.Text + "',class='" + textBox6.Text + "',Email='" + textBox7.Text + "' where rollno='" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Record Update sucessfully");
            con.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from student where rollno='" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Record delete sucessfully");
            con.Close();
        }
    }
}
