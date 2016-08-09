namespace cybercenter
{
    partial class blist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(blist));
            this.label1 = new System.Windows.Forms.Label();
            this.txturl = new System.Windows.Forms.TextBox();
            this.cmdblock = new System.Windows.Forms.Button();
            this.cmdunblock = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL-";
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(60, 18);
            this.txturl.Multiline = true;
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(226, 23);
            this.txturl.TabIndex = 1;
            this.txturl.TextChanged += new System.EventHandler(this.txturl_TextChanged);
            // 
            // cmdblock
            // 
            this.cmdblock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdblock.Location = new System.Drawing.Point(304, 15);
            this.cmdblock.Name = "cmdblock";
            this.cmdblock.Size = new System.Drawing.Size(84, 26);
            this.cmdblock.TabIndex = 3;
            this.cmdblock.Text = "BLOCK";
            this.cmdblock.UseVisualStyleBackColor = true;
            this.cmdblock.Click += new System.EventHandler(this.cmdblock_Click);
            // 
            // cmdunblock
            // 
            this.cmdunblock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdunblock.Location = new System.Drawing.Point(394, 15);
            this.cmdunblock.Name = "cmdunblock";
            this.cmdunblock.Size = new System.Drawing.Size(97, 26);
            this.cmdunblock.TabIndex = 4;
            this.cmdunblock.Text = "UNBLOCK";
            this.cmdunblock.UseVisualStyleBackColor = true;
            this.cmdunblock.Click += new System.EventHandler(this.cmdunblock_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 189);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "DESCRIPTION-";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 80);
            this.textBox1.TabIndex = 2;
            // 
            // blist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(515, 351);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdunblock);
            this.Controls.Add(this.cmdblock);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "blist";
            this.Text = "blist";
            this.Load += new System.EventHandler(this.blist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.Button cmdblock;
        private System.Windows.Forms.Button cmdunblock;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}