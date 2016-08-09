using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cyberuser
{
    public partial class myHistory : Form
    {
        String uname = "";
        SqlConnection con = null;
        public myHistory()
        {
            con=new SqlConnection("server=localhost;uid=sa;pwd=;database=cybercenter");
            InitializeComponent();
        }
           
        public myHistory(string u)
        {
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=cybercenter");
            InitializeComponent();
            uname = u;
           
        }

        private void myHistory_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select URL as 'Website', VisitTime,VisitDate as 'Date' from History where UserName='" + uname + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "History");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
