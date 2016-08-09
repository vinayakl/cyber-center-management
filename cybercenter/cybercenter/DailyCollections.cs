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
    public partial class DailyCollections : Form
    {
        SqlConnection con = null;
        public DailyCollections()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=cybercenter");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DailyCollections_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from Bill where BrowseDate='" + DateTime.Now.ToShortDateString() + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Bill");
                dataGridView1.DataSource = ds.Tables[0];
                SqlCommand cmd = new SqlCommand("Select sum(TotalAmount) as TotalAmount from Bill where BrowseDate='" + DateTime.Now.ToShortDateString() + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtTotalBill.Text = dr["TotalAmount"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
