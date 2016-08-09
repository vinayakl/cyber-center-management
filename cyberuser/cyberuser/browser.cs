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
    public partial class browser : Form
    {
        SqlConnection con = null;
        string user = "", custid = "";
        DateTime InTime = DateTime.Now;
        public browser()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=cybercenter");
        }
        public browser(string user, DateTime d)
        {
            this.user = user;
            this.InTime = d;
            this.custid = user;
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=cybercenter");
            InitializeComponent();
        }

        private void btnReback_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Visible = false;


        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text.Trim().Length == 0)
                MessageBox.Show("Enter Valid URL");
            else          
                webBrowser1.Navigate(toolStripTextBox1.Text);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {
                SqlCommand Insertcmd = new SqlCommand("UPDATE Assign set BrowseEndTime='" + DateTime.Now.ToShortTimeString() + "' WHERE CustomerId='" + custid + "'", con);
                con.Open();
                Insertcmd.ExecuteNonQuery();
                con.Close();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Application.Exit();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            toolStripTextBox1.Text = webBrowser1.Url.ToString();
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand("Select * from Blacklist where Website='" + toolStripTextBox1.Text + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    flag = true;
                }

                if (flag)
                {
                    MessageBox.Show("Website Blocked");
                    webBrowser1.Stop();
                    toolStripTextBox1.Text = "";

                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("insert into History (UserName,URL,VisitDate,VisitTime)values('" + user + "','" + webBrowser1.Url.ToString() + "','" + DateTime.Now.ToShortDateString() + "','" + DateTime.Now.ToShortTimeString() + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            toolStripTextBox1.Focus();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void browser_Load(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Today's Date is :" + DateTime.Now.ToShortDateString();
            statusBar1.Panels[3].Text = "You logged in at :" + DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime OutTime = DateTime.Now;
            TimeSpan duration = OutTime - InTime;
            statusBar1.Panels[4].Text = "You Have Browsed " + duration.Hours+":"+duration.Minutes+":"+duration.Seconds;
           
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            myHistory h = new myHistory(custid);
           
            h.Show();
        }

      
    }
}
