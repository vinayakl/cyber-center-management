namespace cybercenter
{
    partial class customerinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerinfo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmdclear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtMobileNo = new System.Windows.Forms.MaskedTextBox();
            this.cboId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMobileNo = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblMName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnProcessBill = new System.Windows.Forms.Button();
            this.cboSelectComputer = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmdAssign = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(47, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 583);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmdclear);
            this.tabPage1.Controls.Add(this.btnExit);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnNew);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmdclear
            // 
            this.cmdclear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclear.Location = new System.Drawing.Point(252, 475);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(90, 39);
            this.cmdclear.TabIndex = 12;
            this.cmdclear.Text = "Clear";
            this.cmdclear.UseVisualStyleBackColor = true;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(585, 475);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 39);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(478, 475);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 39);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(367, 475);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 39);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(147, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 39);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(38, 475);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 39);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 164);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtMobileNo);
            this.groupBox1.Controls.Add(this.cboId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboGender);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblMobileNo);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.txtMName);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.lblLName);
            this.groupBox1.Controls.Add(this.lblMName);
            this.groupBox1.Controls.Add(this.lblFName);
            this.groupBox1.Location = new System.Drawing.Point(38, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 222);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // mtxtMobileNo
            // 
            this.mtxtMobileNo.Enabled = false;
            this.mtxtMobileNo.Location = new System.Drawing.Point(389, 87);
            this.mtxtMobileNo.Mask = "9999999999";
            this.mtxtMobileNo.Name = "mtxtMobileNo";
            this.mtxtMobileNo.Size = new System.Drawing.Size(179, 26);
            this.mtxtMobileNo.TabIndex = 7;
            // 
            // cboId
            // 
            this.cboId.Enabled = false;
            this.cboId.FormattingEnabled = true;
            this.cboId.Items.AddRange(new object[] {
            "Select",
            "School ID",
            "Licence",
            "Bank Pass Book",
            "Pan Card",
            "Ration Card",
            "Voters ID",
            "Aadhar Card"});
            this.cboId.Location = new System.Drawing.Point(389, 184);
            this.cboId.Name = "cboId";
            this.cboId.Size = new System.Drawing.Size(179, 27);
            this.cboId.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID Proof";
            // 
            // cboGender
            // 
            this.cboGender.Enabled = false;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(389, 150);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(179, 27);
            this.cboGender.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(389, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 26);
            this.txtEmail.TabIndex = 8;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(325, 153);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 19);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(314, 122);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 19);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-Mail ID";
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.AutoSize = true;
            this.lblMobileNo.Location = new System.Drawing.Point(313, 96);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(76, 19);
            this.lblMobileNo.TabIndex = 8;
            this.lblMobileNo.Text = "Mobile No";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(29, 107);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(260, 87);
            this.txtAddress.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(25, 85);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 19);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // txtLName
            // 
            this.txtLName.Enabled = false;
            this.txtLName.Location = new System.Drawing.Point(413, 47);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(155, 26);
            this.txtLName.TabIndex = 5;
            // 
            // txtMName
            // 
            this.txtMName.Enabled = false;
            this.txtMName.Location = new System.Drawing.Point(214, 47);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(171, 26);
            this.txtMName.TabIndex = 4;
            // 
            // txtFName
            // 
            this.txtFName.Enabled = false;
            this.txtFName.Location = new System.Drawing.Point(29, 47);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(156, 26);
            this.txtFName.TabIndex = 3;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(427, 21);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(76, 19);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name";
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Location = new System.Drawing.Point(220, 21);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(159, 19);
            this.lblMName.TabIndex = 1;
            this.lblMName.Text = "Middle Name (Optional)";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(29, 21);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(77, 19);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnProcessBill);
            this.tabPage2.Controls.Add(this.cboSelectComputer);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.cmdAssign);
            this.tabPage2.Controls.Add(this.cmdCancel);
            this.tabPage2.Controls.Add(this.txtCustomerId);
            this.tabPage2.Controls.Add(this.lblId);
            this.tabPage2.Controls.Add(this.lblSelect);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Assign Computer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProcessBill
            // 
            this.btnProcessBill.Location = new System.Drawing.Point(144, 465);
            this.btnProcessBill.Name = "btnProcessBill";
            this.btnProcessBill.Size = new System.Drawing.Size(113, 45);
            this.btnProcessBill.TabIndex = 8;
            this.btnProcessBill.Text = "Process Bill";
            this.btnProcessBill.UseVisualStyleBackColor = true;
            this.btnProcessBill.Click += new System.EventHandler(this.btnProcessBill_Click);
            // 
            // cboSelectComputer
            // 
            this.cboSelectComputer.FormattingEnabled = true;
            this.cboSelectComputer.Location = new System.Drawing.Point(264, 113);
            this.cboSelectComputer.Name = "cboSelectComputer";
            this.cboSelectComputer.Size = new System.Drawing.Size(176, 27);
            this.cboSelectComputer.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(36, 212);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(626, 235);
            this.dataGridView2.TabIndex = 6;
            //this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // cmdAssign
            // 
            this.cmdAssign.Location = new System.Drawing.Point(474, 79);
            this.cmdAssign.Name = "cmdAssign";
            this.cmdAssign.Size = new System.Drawing.Size(75, 23);
            this.cmdAssign.TabIndex = 5;
            this.cmdAssign.Text = "Assign";
            this.cmdAssign.UseVisualStyleBackColor = true;
            this.cmdAssign.Click += new System.EventHandler(this.cmdAssign_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(474, 119);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(264, 76);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(176, 26);
            this.txtCustomerId.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(140, 79);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(91, 19);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Customer ID:";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(140, 121);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(114, 19);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "Select Computer:";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(48, 29);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(10, 13);
            this.lblCustomerId.TabIndex = 23;
            this.lblCustomerId.Text = "-";
            this.lblCustomerId.Visible = false;
            // 
            // customerinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 640);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "customerinfo";
            this.Text = "CUSTOMER INFORMATION";
            this.Load += new System.EventHandler(this.customerinfo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMobileNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.ComboBox cboId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAssign;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cboSelectComputer;
        private System.Windows.Forms.MaskedTextBox mtxtMobileNo;
        private System.Windows.Forms.Button cmdclear;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnProcessBill;
    }
}