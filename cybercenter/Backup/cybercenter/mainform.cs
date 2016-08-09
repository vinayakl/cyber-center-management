using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cybercenter
{
    public partial class mainform : Form
    {
        public string u;
        public mainform()
        {
            InitializeComponent();
        }
        public mainform(string uname)
        {
            u=uname;
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerinfo c = new customerinfo();
            c.Show();
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void computerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newcomputer n = new newcomputer();
            n.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changepassword c = new changepassword(u);
            c.Show();
        }

        private void dailyCollectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyCollections d = new DailyCollections();
            d.Show();
        }

        private void createdByToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" This Software is Designed and created by Sanskkriti ", "Created By", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void abouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Cyber Center Software controls, secures, and enhances the running of your internet cafe with Effeciency and Ease ","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void ratesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rates r = new Rates();
            r.Show();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
            hideToolStripMenuItem.Enabled = false;
            
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
            showToolStripMenuItem.Enabled = false;
            hideToolStripMenuItem.Enabled = true;

        }

        private void blackListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blist b = new blist();
            b.Show();
        }

        private void tStripBtnCustomer_Click(object sender, EventArgs e)
        {
            customerinfo c = new customerinfo();
            c.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            newcomputer n = new newcomputer();
            n.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
             blist b = new blist();
             b.Show();
        }

        private void mouthlyCollectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthlyCollection mc = new MonthlyCollection();
            mc.MdiParent = this;
            mc.Show();
        }

        private void customersReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerReport cr = new CustomerReport();
            cr.MdiParent = this;
            cr.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            DailyCollections dc = new DailyCollections();
            dc.MdiParent = this;
            dc.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            MonthlyCollection mc = new MonthlyCollection();
            mc.MdiParent = this;
            mc.Show();
        }

        private void getCustomerPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetPassword gp = new GetPassword();
            gp.MdiParent = this;
            gp.Show();
        }

        private void websiteHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebsiteHistory wh = new WebsiteHistory();
            wh.MdiParent = this;
            wh.Show();
        }

        private void customersHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerHistory ch = new CustomerHistory();
            ch.MdiParent = this;
            ch.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {

            CustomerReport cr = new CustomerReport();
            cr.MdiParent = this;
            cr.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            CustomerHistory ch = new CustomerHistory();
            ch.MdiParent = this;
            ch.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

            WebsiteHistory wh = new WebsiteHistory();
            wh.MdiParent = this;
            wh.Show();
        }
    }
}
