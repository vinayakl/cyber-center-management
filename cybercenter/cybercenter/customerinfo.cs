using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.IO;


namespace cybercenter
{
    public partial class customerinfo : Form
    {
        SqlConnection con = null;
        int saveflag = 0;
        public customerinfo()
        {
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=cybercenter");
            InitializeComponent();

            FillAssignedgrid();
            refreshgrid();
        }


        private void btnNew_Click_1(object sender, EventArgs e)
        {
            clearControls();
            enableControls();
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            saveflag = 0;
            txtFName.Focus();
           
        }

        public bool IsAlphaSpace(String strToCheck)
        {
            Regex objAlphaPattern = new Regex("[^a-z A-Z]");
            return !objAlphaPattern.IsMatch(strToCheck);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (txtFName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter the customer's first name.");
                txtFName.Focus();
                return;
            }
            if (!IsAlphaSpace(txtFName.Text))
            {
                MessageBox.Show("Enter alphabets only, space is allowed","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                return;
            }
            if (txtLName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter the customer's last name.");
                txtLName.Focus();
                return;
            }
            if (!IsAlphaSpace(txtLName.Text))
            {
                MessageBox.Show("Enter alphabets only, space is allowed");
                return;
            }
            if (txtAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter the customer's Address.");
                txtAddress.Focus();
                return;
            }
            if (mtxtMobileNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter the customer's Mobile number.");
                mtxtMobileNo.Focus();
                return;
            }
            if (mtxtMobileNo.Text.Trim().Length < 10)
            {
                MessageBox.Show("Please enter a valid Mobile number.");
                mtxtMobileNo.Text = "";
                mtxtMobileNo.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter the customer's E-mail.");
                txtEmail.Focus();
                return;
            }
            string pattern = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|" +
              @"0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z]" +
              @"[a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";
            System.Text.RegularExpressions.Match match =
                Regex.Match(txtEmail.Text.Trim(), pattern, RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                MessageBox.Show("Invalid email address");
                return;
            }
            if (cboGender.SelectedIndex==-1)
            {
                MessageBox.Show("Please select the customer's Gender.");
                cboGender.Focus();
                return;
            } 
            if (cboId.SelectedIndex==-1)
            {
                MessageBox.Show("Please select the customer's Id proof");
                cboId.Focus();
                return;
            }
            if (saveflag == 0)
            {
                DateTime moment = DateTime.Now;
               
                // Year gets 1999.
                int year = moment.Year;

                // Month gets 1 (January).
                int month = moment.Month;

                // Day gets 13.
                int day = moment.Day;

                // Hour gets 3.
                int hour = moment.Hour;

                // Minute gets 57.
                int minute = moment.Minute;

                // Second gets 32.
                int second = moment.Second;
               string customerid="" + year + month + day + hour + minute + second;
               try
               {
                   bool flag = false;
                   SqlCommand cmd1 = new SqlCommand("Select * from CustomerInfo where Fname='" + txtFName.Text + "'", con);
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
                       MessageBox.Show("Customer Details Already exists");
                   }
                   else
                   {
                       string pass = RandomPassword.Generate(8, 10);
                       SqlCommand cmd = new SqlCommand("insert into CustomerInfo (CustomerID,Fname,Mname,Lname,address,mobile,email,gender,idproof,pass)values ('"+customerid+"','" + txtFName.Text + "','" + txtMName.Text + "','" + txtLName.Text + "','" + txtAddress.Text + "','" + mtxtMobileNo.Text + "','" + txtEmail.Text + "','" + cboGender.Text + "','" + cboId.Text + "','"+pass+"')", con);
                       con.Open();
                       cmd.ExecuteNonQuery();
                       MessageBox.Show("Customer Details Registered. \n Customer ID is"+customerid+" and password is:"+pass);
                       con.Close();
                       tabControl1.SelectTab(1);//move to the next tab  
                       txtCustomerId.Text = customerid.ToString();
                   }
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.ToString());

               }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update CustomerInfo set Fname='" + txtFName.Text + "',Mname='" + txtMName.Text + "',Lname='" + txtLName.Text + "',address='" + txtAddress.Text + "',mobile='" + mtxtMobileNo.Text + "',email='" + txtEmail.Text + "',gender='" + cboGender.Text + "',idproof='" + cboId.Text + "' where CustomerId='" + lblCustomerId.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Details Updated");
                con.Close();
            }
            clearControls();
            disableControls();
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            refreshgrid();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            
            enableControls();
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            saveflag = 1;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SqlCommand deleteCmd = new SqlCommand("Delete from CustomerInfo where CustomerId='" + lblCustomerId.Text + "'", con);
                    con.Open();
                    deleteCmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer Details Deleted Permenantally ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            disableControls();
            clearControls();
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            refreshgrid();
                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


        private void cmdAssign_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text.Trim().Equals(""))
            {
                MessageBox.Show("Assign a computer.");
                txtCustomerId.Focus();
                return;
            }

            bool exist = false;
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Assign", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["ComputerName"].Equals(cboSelectComputer.SelectedItem.ToString()))
                    {
                        exist = true;
                        break;
                    }
                }
                con.Close();
                dr.Close();
                if (exist)
                {
                    MessageBox.Show("Computer Already Assigned");
                    return;
                }
                else
                {
                    try
                    {
                        SqlCommand Insertcmd = new SqlCommand("INSERT INTO Assign(ComputerName,CustomerId,BrowseStartTime)values('" + cboSelectComputer.SelectedItem.ToString() + "','" + txtCustomerId.Text + "','" + DateTime.Now.ToShortTimeString() + "')", con);
                        con.Open();
                        Insertcmd.ExecuteNonQuery();
                        MessageBox.Show("Computer Assigned Successfully");
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            FillAssignedgrid();
        }

        public void FillAssignedgrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Assign", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Assign");
            dataGridView2.DataSource = ds.Tables[0];
        }
    

        private void cmdclear_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtMName.Text = "";
            cboGender.Text = "";
            cboId.Text = "";
            mtxtMobileNo.Text = "";
        }

      

        private void customerinfo_Load(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            refreshgrid();
            clearControls();
            disableControls();
            //fill the combobox with the computer names
            try
            {
                SqlCommand cmd1 = new SqlCommand("Select machinename from Computer where status='free'", con);
                con.Open();
                SqlDataReader rdr = cmd1.ExecuteReader();
                while (rdr.Read())
                {
                    cboSelectComputer.Items.Add(rdr["machinename"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void refreshgrid()
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

        void clearControls()
        {
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtMName.Text = "";
            cboGender.Text = "";
            cboId.Text = "";
            mtxtMobileNo.Text = "";
        }
        void enableControls()
        {
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
            txtFName.Enabled = true;
            txtLName.Enabled = true;
            txtMName.Enabled = true;
            mtxtMobileNo.Enabled = true;
            cboGender.Enabled = true;
            cboId.Enabled = true;
        }
        void disableControls()
        {
            txtAddress.Enabled = false;
            txtEmail.Enabled = false;
            txtFName.Enabled = false;
            txtLName.Enabled = false;
            txtMName.Enabled = false;
            mtxtMobileNo.Enabled = false;
            cboGender.Enabled = false;
            cboId.Enabled = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                lblCustomerId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtFName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtMName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtLName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtAddress.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                mtxtMobileNo.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtEmail.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                cboGender.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                cboId.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcessBill_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection RowCollection = dataGridView2.SelectedRows;

            foreach (DataGridViewRow row in RowCollection)
            {
                if (row.Selected == true)
                {
                    String compname= row.Cells[0].Value.ToString();
                    String cid= row.Cells[1].Value.ToString();
                    
                    DateTime start=DateTime.Now;
                    DateTime stop = DateTime.Now;
                    TimeSpan diff=stop.Subtract(start);
                    try
                    {
                        SqlCommand SelectQuery = new SqlCommand("Select * FROM Assign WHERE ComputerName='" + compname + "'", con);
                        con.Open();
                        SqlDataReader dr = SelectQuery.ExecuteReader();
                        while (dr.Read())
                        {
                             start= DateTime.Parse(dr["browsestarttime"].ToString());
                             stop = DateTime.Parse(dr["browseendtime"].ToString());
                            diff = stop.Subtract(start);
                            //MessageBox.Show(diff.Minutes.ToString());

                        }
                        dr.Close();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString ());
                    }
                 
                    try
                    {
                        int total= 0;
                        int rate = 0;
                        int hrs = diff.Hours;
                        int mins = diff.Minutes;
                        //if (hrs > 0)
                        //{
                        //    mins = mins - (hrs * 60);
                        //}
                        MessageBox.Show("You have browsed for :"+hrs+":"+mins+" Minutes");
                        SqlCommand SelectQuery = new SqlCommand("Select Rate FROM Rates", con);
                        con.Open();
                        SqlDataReader dr = SelectQuery.ExecuteReader();
                        while (dr.Read())
                        {    
                            rate=int.Parse(dr["Rate"].ToString());
                        }
                        dr.Close();
                        con.Close();
        
                        int totalamount=rate*hrs;
                        
                        if(mins<=30)
                            totalamount=totalamount+(rate/2);
                        else
                            totalamount=totalamount+rate;
                        
                        MessageBox.Show(""+totalamount);
                        string totaltime = hrs + ":" + mins;
                        SqlCommand Insertcmd = new SqlCommand("Insert Into Bill (ComputerName,CustomerId,FromHours,ToHours,TotalTime,BrowseDate,TotalAmount)values('" + compname + "','" + cid + "','" + start + "','" + stop + "','" + totaltime + "','" + DateTime.Now.ToShortDateString() + "'," + totalamount + ")", con);
                        con.Open();
                        Insertcmd.ExecuteNonQuery();
                        con.Close();
                        
                        SqlCommand DeleteCmd = new SqlCommand("DELETE FROM Assign WHERE ComputerName='" + compname + "'", con);
                        con.Open();
                        DeleteCmd.ExecuteNonQuery();
                        MessageBox.Show("Computer Deassigned Successfully");
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    FillAssignedgrid();
                }
            }
        }

       

        
    }
}
