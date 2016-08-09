using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace cyberuser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (txtUserid.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter the UserID ");
                txtUserid.Text = "";
                txtUserid.Focus();
                return;
            }
            if (txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter the Password ");
                txtPassword.Text = "";
                txtPassword.Focus();
                return;
            }
            if (txtPassword.Text.Trim().Length < 6)
            {
                MessageBox.Show(" Password too short ");
                txtPassword.Text = "";
                txtPassword.Focus();
                return;
            }
           
            try
            {
                if (txtPassword.Text.Trim().Equals("admin123") && txtUserid.Text.Trim().Equals("admin"))
                    {
                        systemInfo s = new systemInfo();
                        s.Show();
                        this.Visible = false;
                        return;

                    }
                string custid = "";  
                SqlConnection con = new SqlConnection("server=localhost;uid=sa;pwd=;database=cybercenter");
                SqlCommand cmd = new SqlCommand("Select * from CustomerInfo where CustomerId='"+txtUserid.Text+"' and pass='"+txtPassword.Text+"'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    custid = dr["CustomerID"].ToString();
                        flag = true;
                        break;
                   
                }
                if (flag)
                {

                        DateTime log = DateTime.Now;
                        browser b = new browser(custid,log);
                        b.Show();
                        this.Visible = false;
                        MessageBox.Show(" Welcome User ","Welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                else
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUserid.Text = "";
            txtPassword.Text = "";
            txtUserid.Focus();
               
        }
    }
}
