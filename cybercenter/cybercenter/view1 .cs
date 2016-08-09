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
    public partial class view1 : Form
    {
        public view1()
        {
            InitializeComponent();
        }

        private void view1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from Bill where BrowseDate between '" + dtpFromDate.Text + "' and '" + dtpToDate.Text + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Bill");
                dataGridView1.DataSource = ds.Tables[0];
                SqlCommand cmd = new SqlCommand("Select sum(TotalAmount) as TotalAmount from Bill where BrowseDate between '" + dtpFromDate.Text + "' and '" + dtpToDate.Text + "'", con);
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
