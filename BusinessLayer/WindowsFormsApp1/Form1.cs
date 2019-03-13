using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
    
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chand\OneDrive\Documents\testing.mdf;Integrated Security=True;Connect Timeout=30");
            public Form1()
            {
                InitializeComponent();
            }


            private void button1_Click(object sender, EventArgs e)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into table1 values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("record insterted successfully");
            }
        }
    }


