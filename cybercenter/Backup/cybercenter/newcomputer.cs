using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace cybercenter
{
    public partial class newcomputer : Form
    {
        public newcomputer()
        {
            InitializeComponent();
        }

     
        private void btnNew_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OleDbConnection con = null;
            try
            {
                con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Path.GetFullPath("Cyber.mdb"));
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from Computers", con);
                
                DataSet ds = new DataSet();
                da.Fill(ds,"Computers");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Changes Edited. ");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Info Deleted.");
        }

        private void btuExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void newcomputer_Load(object sender, EventArgs e)
        {

        }

        
    }
}
