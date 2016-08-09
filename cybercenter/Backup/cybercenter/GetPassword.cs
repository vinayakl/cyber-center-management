using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cybercenter
{
    public partial class GetPassword : Form
    {
        SqlConnection con = null;

        public GetPassword()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=cybercenter");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                //SqlConnection con = new SqlConnection("Provider=Microsoft.Jet.Sql.4.0;Data Source=" + Path.GetFullPath("Cyber.mdb"));
                SqlCommand cmd = new SqlCommand("Select * from CustomerInfo where CustomerId='"+textBox1.Text+"' or (fname='"+textBox2.Text+"' and lname='"+textBox3.Text+"')", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    flag = true;
                    MessageBox.Show("Your CustomerId:"+dr["CustomerId"].ToString()+" and Password :"+dr["pass"].ToString());
                    break;
                }
                 if(!flag)   
                {
                    MessageBox.Show("Invalid Username or Password");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
        }
    }
}
