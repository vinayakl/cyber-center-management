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
    public partial class Rates : Form
    {
        SqlConnection con = null;
        int saveflag = 0;
        public Rates()
        {
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=cybercenter");
            InitializeComponent();
        }

        void clearControls()
        {
            //txtId.Text = "";
            txtRate.Text = "";
            cboCategory.Text="";
        }
        void enableControls()
        {
            
            txtRate.Enabled = true;
            cboCategory.Enabled = true;
        }
        void disableControls()
        {
            txtId.Enabled = false;
            txtRate.Enabled = false;
            cboCategory.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearControls();
            enableControls();
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            saveflag = 0;
            txtId.Visible = false;
            label1.Visible = false;
        }

        private void Rates_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            disableControls();
            btnNew.Enabled =  true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
           
            txtId.Visible = false;
            label1.Visible = false;
            refreshgrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (cboCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the customer's Category.");
                cboCategory.Focus();
                return;
            }
            if (txtRate.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter the rates.");
                txtRate.Focus();
                return;
            }


            if (saveflag == 0)
            {
               
             try
             {
                   bool flag = false;
                   SqlCommand cmd1 = new SqlCommand("Select * from rates where category='" + cboCategory.SelectedItem.ToString() + "'", con);
                   con.Open();
                   SqlDataReader rdr = cmd1.ExecuteReader();
                   while (rdr.Read())
                   {
                       flag = true;
                       break;
                   }
                   con.Close();
                   if (flag)
                   {
                       MessageBox.Show("Rates Details Already exists");
                   }
                   else
                   {
                       SqlCommand cmd = new SqlCommand("insert into rates (Category,rate)values ('" + cboCategory.Text + "','" + txtRate.Text +  "')", con);
                       con.Open();
                       cmd.ExecuteNonQuery();
                       MessageBox.Show("New Rate Details Added");
                       con.Close();

                   }
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.ToString());

               }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update rates set Category='" + cboCategory.Text + "',rate='" + txtRate.Text +  "' where ID="+txtId.Text, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rates Details Updated");
                con.Close();
            }
            clearControls();
            disableControls();
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtId.Visible = false;
            label1.Visible = false;
            refreshgrid();
        }
        void refreshgrid()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from rates", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "rates");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtId.Visible = true;
            label1.Visible = true;
            enableControls();
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            saveflag = 1;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Visible = true;
            label1.Visible = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                cboCategory.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtRate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
            disableControls();
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("delete from rates where ID=" + txtId.Text, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rates Details Deleted");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                txtId.Visible = false;
                label1.Visible = false;
            }
            disableControls();
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            refreshgrid();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
           
        
    }
}
