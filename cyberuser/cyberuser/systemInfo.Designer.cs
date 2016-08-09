namespace cyberuser
{
    partial class systemInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(systemInfo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCpu = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblMemory = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMachine = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblDomain = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblVnumber = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOs = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 310);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCpu);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.lblMonitor);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.lblMemory);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lblMachine);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblSystem);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(412, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HardWare";
            // 
            // lblCpu
            // 
            this.lblCpu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCpu.Location = new System.Drawing.Point(136, 121);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(256, 23);
            this.lblCpu.TabIndex = 9;
            this.lblCpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCpu.Click += new System.EventHandler(this.lblcpu_Click);
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Location = new System.Drawing.Point(8, 125);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 23);
            this.label19.TabIndex = 8;
            this.label19.Text = "CPU";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonitor
            // 
            this.lblMonitor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonitor.Location = new System.Drawing.Point(136, 223);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(160, 23);
            this.lblMonitor.TabIndex = 7;
            this.lblMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMonitor.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(8, 223);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 6;
            this.label17.Text = "Monitor Size";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMemory
            // 
            this.lblMemory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMemory.Location = new System.Drawing.Point(264, 175);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(100, 23);
            this.lblMemory.TabIndex = 5;
            this.lblMemory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(8, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Memory Mapped To The Process  Context";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMachine
            // 
            this.lblMachine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMachine.Location = new System.Drawing.Point(136, 77);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(100, 23);
            this.lblMachine.TabIndex = 3;
            this.lblMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(8, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Machine Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSystem
            // 
            this.lblSystem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSystem.Location = new System.Drawing.Point(136, 24);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(160, 23);
            this.lblSystem.TabIndex = 1;
            this.lblSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Directory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblDomain);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.lblName);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.lblVnumber);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.lblVersion);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.lblOs);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(412, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SoftWare";
            // 
            // lblDomain
            // 
            this.lblDomain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDomain.Location = new System.Drawing.Point(182, 207);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(208, 23);
            this.lblDomain.TabIndex = 9;
            this.lblDomain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(8, 207);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 23);
            this.label15.TabIndex = 8;
            this.label15.Text = "User Domain Name";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblName.Location = new System.Drawing.Point(182, 161);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(208, 23);
            this.lblName.TabIndex = 7;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(8, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 6;
            this.label13.Text = "User Name";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVnumber
            // 
            this.lblVnumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblVnumber.Location = new System.Drawing.Point(182, 114);
            this.lblVnumber.Name = "lblVnumber";
            this.lblVnumber.Size = new System.Drawing.Size(208, 23);
            this.lblVnumber.TabIndex = 5;
            this.lblVnumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVnumber.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(8, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "OS - Version Number";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblVersion.Location = new System.Drawing.Point(182, 62);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(208, 23);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(8, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "OS - Version";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOs
            // 
            this.lblOs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblOs.Location = new System.Drawing.Point(182, 16);
            this.lblOs.Name = "lblOs";
            this.lblOs.Size = new System.Drawing.Size(208, 23);
            this.lblOs.TabIndex = 1;
            this.lblOs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(8, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "The OS Opened From ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(198, 365);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(126, 26);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send To Server";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(341, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 26);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // systemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 411);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "systemInfo";
            this.Text = "SYSTEM INFORMATION";
            this.Load += new System.EventHandler(this.systemInfo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblMonitor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblVnumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblOs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnExit;
    }
}