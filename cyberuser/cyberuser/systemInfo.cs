using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.IO;

namespace cyberuser
{
    public partial class systemInfo : Form
    {
        public systemInfo()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void lblcpu_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void systemInfo_Load(object sender, EventArgs e)
        {
            try
            {
                lblSystem.Text = System.Environment.SystemDirectory;
                lblMachine.Text = System.Environment.MachineName;
                lblMemory.Text = System.Environment.WorkingSet.ToString();
                lblVersion.Text = System.Environment.OSVersion.ToString();
                lblVnumber.Text = System.Environment.Version.ToString();
                RegistryKey Rkey = Registry.LocalMachine;
				Rkey = Rkey.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0");
                lblCpu.Text = (string)Rkey.GetValue("ProcessorNameString");
                int q = System.Environment.TickCount;
                int w = (q / 1000) / 60;
                lblOs.Text = w.ToString() + "  Minute(s)";
                lblMonitor.Text = SystemInformation.PrimaryMonitorSize.ToString();
                lblDomain.Text = System.Environment.UserDomainName;
                lblName.Text = System.Environment.UserName;
                

            }
            catch
            {
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                SqlConnection con = new SqlConnection("server=localhost;uid=sa;pwd=;database=cybercenter");
                SqlCommand cmd1 = new SqlCommand("Select * from computer where machinename='" + lblMachine.Text + "'", con);
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
                    MessageBox.Show("Machine Details Already exists");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into computer (systemname,machinename,cpu,memory,monitorsize,os,username,status)values ('" + lblSystem.Text + "','" + lblMachine.Text + "','" + lblCpu.Text + "','" + lblMemory.Text + "','" + lblMonitor.Text + "','" + lblOs.Text + "','" + lblName.Text + "','free')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Machine Details Registered");
                    con.Close();
                    btnSend.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
