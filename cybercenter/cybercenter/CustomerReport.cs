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
    public partial class CustomerReport : Form
    {
        SqlConnection con = null;
        public CustomerReport()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=cybercenter");
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from CustomerInfo", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "CustomerInfo");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
