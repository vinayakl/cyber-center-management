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


namespace cybercenter
{
    public partial class blist : Form
    {
        SqlConnection con = null;
        public blist()
        {
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=cybercenter");
            InitializeComponent();
        }

        private void txturl_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdblock_Click(object sender, EventArgs e)
        {
            try
            {
                //bool flag = false;
                //SqlCommand cmd1 = new SqlCommand("Select * from Blacklist Website='" + txturl.Text + "'", con);
                //con.Open();
               // SqlDataReader rdr = cmd1.ExecuteReader();
                //while (rdr.Read())
                //{
                 //   flag = true;
                  //  break;
                //}
                //con.Close();
                //if (flag)
                //{
                 //   MessageBox.Show("Website Blocked");
                //}
                //else
                {

                    SqlCommand cmd = new SqlCommand("insert into Blacklist (Website,Description)values ('" + txturl.Text + "','" + textBox1.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Website Blocked");
                    con.Close();
                 
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            refreshgrid();

        }
        void refreshgrid()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from Blacklist", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Blacklist");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void blist_Load(object sender, EventArgs e)
        {
            refreshgrid();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txturl.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            }
            
        }

        private void cmdunblock_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SqlCommand deleteCmd = new SqlCommand("Delete from Blacklist where Website='" + txturl.Text + "'", con);
                    con.Open();
                    deleteCmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Website Unblocked Permenantally ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            txturl.Text = "";
            textBox1.Text = "";
            refreshgrid();
        }
    }
}
