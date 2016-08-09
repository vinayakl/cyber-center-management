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
    public partial class CustomerHistory : Form
    {
        SqlConnection con = null;
        public CustomerHistory()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=cybercenter");
        }

        private void btnGetHistory_Click(object sender, EventArgs e)
        {
            try
            {
                String uname = "";
                //(Select CustomerID from CustomerInfo where (Fname='" + txtFirstName.Text + "' and Lname='" + txtLastName.Text + "') or Email='" + txtEmail.Text + "')
                //SqlDataAdapter da = new SqlDataAdapter("select c.Fname,c.Mname,c.Lname,h.URL,h.VisitTime,h.VisitDate from History h,CustomerInfo c where h.UserName=c.CustomerID and (((c.Fname='" + txtFirstName.Text + "' and c.LName='" + txtLastName.Text + "') or email='" + txtEmail.Text + "' ) and VisitDate='" + dateTimePicker1.Text + "' ) ", con);
                SqlCommand cmd = new SqlCommand("Select CustomerID from CustomerInfo where (Fname='" + txtFirstName.Text + "' and Lname='" + txtLastName.Text + "') or Email='" + txtEmail.Text + "'",con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    uname = dr["CustomerID"].ToString();
                }
                con.Close();
                SqlDataAdapter da = new SqlDataAdapter("select * from History where Username ='" + uname + "' and VisitDate='"+dateTimePicker1.Text+"'", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
