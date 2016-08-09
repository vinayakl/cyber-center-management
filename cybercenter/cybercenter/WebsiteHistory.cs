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
    public partial class WebsiteHistory : Form
    {
        SqlConnection con = null;
        public WebsiteHistory()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=cybercenter");
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from History where VisitDate='" + dateTimePicker1.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "History");
            dataGridView1.DataSource = ds.Tables[0];
        }

       
    }
}
