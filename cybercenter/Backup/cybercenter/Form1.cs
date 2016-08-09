using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;

namespace cybercenter
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string uname = txtUserid.Text;
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
                SqlConnection con = con = new SqlConnection("server=localhost;uid=sa;pwd=;database=cybercenter");
                SqlCommand cmd = new SqlCommand("Select * from login", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (txtUserid.Text.Trim().Equals(dr[0].ToString()) && txtPassword.Text.Trim().Equals(dr[1].ToString()))
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    mainform m = new mainform(uname);
                    m.Show();
                    this.Visible = false;
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
            this.Close();
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserid.Text = "";
            txtUserid.Focus();
        }  

        
    }
}
