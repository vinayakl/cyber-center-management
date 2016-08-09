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
using Microsoft.Win32;





namespace cybercenter
{
    public partial class changepassword : Form
    {
        public string u;
        SqlConnection con = null;
        public changepassword()
        {

            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=cybercenter");
            InitializeComponent();
        }
        public changepassword(string uname)
        {
             u = uname;
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=cybercenter");
            InitializeComponent();
        }
       
        private void btnChange_Click(object sender, EventArgs e)
        {
            
            bool flag = false;
            if (txtOld.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter the  Old PassWord");
            }
            if (txtNew.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter the new PassWord");
            }
            if (TxtConfirm.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter the Confirmation  PassWord");
              
            }
             try
            {
                
               
                SqlCommand scmd = new SqlCommand("select * from login where uname='"+u+"'", con);
                con.Open();
                SqlDataReader dr= scmd.ExecuteReader();
                while (dr.Read())
                {
                    if (txtOld.Text.Equals(dr["pass"]))
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        flag = false;
                    }
                   
                }
                con.Close();
                if (flag)
                {
                   
                  
                    SqlCommand cmd = new SqlCommand("update login set pass='" + txtNew.Text + "' where uname='" + u + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password changed");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Old Password wrong");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }           
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            

        }

        
    }

