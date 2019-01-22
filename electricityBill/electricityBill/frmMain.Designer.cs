namespace electricityBill
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtkWh = new System.Windows.Forms.TextBox();
            this.lblkWh = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.lblkWhPeak = new System.Windows.Forms.Label();
            this.txtkWhOff = new System.Windows.Forms.TextBox();
            this.txtkWhPeak = new System.Windows.Forms.TextBox();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalCustomer = new System.Windows.Forms.TextBox();
            this.txtTotalRes = new System.Windows.Forms.TextBox();
            this.txtTotalComm = new System.Windows.Forms.TextBox();
            this.txtTotalInd = new System.Windows.Forms.TextBox();
            this.txtTotalAll = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblkWhOff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtkWh
            // 
            this.txtkWh.Location = new System.Drawing.Point(366, 311);
            this.txtkWh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtkWh.Name = "txtkWh";
            this.txtkWh.Size = new System.Drawing.Size(160, 26);
            this.txtkWh.TabIndex = 1;
            // 
            // lblkWh
            // 
            this.lblkWh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblkWh.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkWh.Location = new System.Drawing.Point(30, 311);
            this.lblkWh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkWh.Name = "lblkWh";
            this.lblkWh.Size = new System.Drawing.Size(303, 26);
            this.lblkWh.TabIndex = 2;
            this.lblkWh.Text = "Enter total usage (kWh):";
            this.lblkWh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBill
            // 
            this.lblBill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBill.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.Location = new System.Drawing.Point(31, 456);
            this.lblBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(302, 26);
            this.lblBill.TabIndex = 15;
            this.lblBill.Text = "Amount Due:";
            this.lblBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBill
            // 
            this.txtBill.Enabled = false;
            this.txtBill.Location = new System.Drawing.Point(366, 456);
            this.txtBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(160, 26);
            this.txtBill.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.LawnGreen;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.Location = new System.Drawing.Point(366, 405);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(160, 33);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate Bill";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(366, 590);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 33);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(444, 590);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 33);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1071, 74);
            this.label1.TabIndex = 16;
            this.label1.Text = "Electricity Bill";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(30, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select Customer Type:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCustomer
            // 
            this.cboCustomer.BackColor = System.Drawing.Color.White;
            this.cboCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Items.AddRange(new object[] {
            "Residential",
            "Commercial",
            "Industrial"});
            this.cboCustomer.Location = new System.Drawing.Point(366, 165);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(160, 28);
            this.cboCustomer.TabIndex = 9;
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // lblkWhPeak
            // 
            this.lblkWhPeak.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblkWhPeak.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkWhPeak.Location = new System.Drawing.Point(30, 311);
            this.lblkWhPeak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkWhPeak.Name = "lblkWhPeak";
            this.lblkWhPeak.Size = new System.Drawing.Size(303, 27);
            this.lblkWhPeak.TabIndex = 13;
            this.lblkWhPeak.Text = "Enter peak hours usage (kWh):";
            this.lblkWhPeak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtkWhOff
            // 
            this.txtkWhOff.Location = new System.Drawing.Point(366, 361);
            this.txtkWhOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtkWhOff.Name = "txtkWhOff";
            this.txtkWhOff.Size = new System.Drawing.Size(160, 26);
            this.txtkWhOff.TabIndex = 3;
            // 
            // txtkWhPeak
            // 
            this.txtkWhPeak.Location = new System.Drawing.Point(366, 311);
            this.txtkWhPeak.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtkWhPeak.Name = "txtkWhPeak";
            this.txtkWhPeak.Size = new System.Drawing.Size(160, 26);
            this.txtkWhPeak.TabIndex = 2;
            // 
            // lstCustomer
            // 
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.ItemHeight = 20;
            this.lstCustomer.Location = new System.Drawing.Point(579, 164);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(481, 284);
            this.lstCustomer.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(679, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Customer List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(366, 265);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(160, 26);
            this.txtCustomerName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(30, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Customer Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(366, 216);
            this.txtAccountNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(160, 26);
            this.txtAccountNo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(30, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Account No:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalCustomer
            // 
            this.txtTotalCustomer.Enabled = false;
            this.txtTotalCustomer.Location = new System.Drawing.Point(870, 507);
            this.txtTotalCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalCustomer.Name = "txtTotalCustomer";
            this.txtTotalCustomer.Size = new System.Drawing.Size(160, 26);
            this.txtTotalCustomer.TabIndex = 25;
            // 
            // txtTotalRes
            // 
            this.txtTotalRes.Enabled = false;
            this.txtTotalRes.Location = new System.Drawing.Point(870, 543);
            this.txtTotalRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalRes.Name = "txtTotalRes";
            this.txtTotalRes.Size = new System.Drawing.Size(160, 26);
            this.txtTotalRes.TabIndex = 26;
            // 
            // txtTotalComm
            // 
            this.txtTotalComm.Enabled = false;
            this.txtTotalComm.Location = new System.Drawing.Point(870, 579);
            this.txtTotalComm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalComm.Name = "txtTotalComm";
            this.txtTotalComm.Size = new System.Drawing.Size(160, 26);
            this.txtTotalComm.TabIndex = 27;
            // 
            // txtTotalInd
            // 
            this.txtTotalInd.Enabled = false;
            this.txtTotalInd.Location = new System.Drawing.Point(870, 615);
            this.txtTotalInd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalInd.Name = "txtTotalInd";
            this.txtTotalInd.Size = new System.Drawing.Size(160, 26);
            this.txtTotalInd.TabIndex = 28;
            // 
            // txtTotalAll
            // 
            this.txtTotalAll.Enabled = false;
            this.txtTotalAll.Location = new System.Drawing.Point(870, 651);
            this.txtTotalAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalAll.Name = "txtTotalAll";
            this.txtTotalAll.Size = new System.Drawing.Size(160, 26);
            this.txtTotalAll.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label6.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(700, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Statistics";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label8.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(597, 543);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 26);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total Residential Charge:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label9.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(597, 579);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 26);
            this.label9.TabIndex = 22;
            this.label9.Text = "Total Commercial Charge:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label10.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(597, 614);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 26);
            this.label10.TabIndex = 23;
            this.label10.Text = "Total Industrial Charge:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label11.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(597, 651);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 26);
            this.label11.TabIndex = 24;
            this.label11.Text = "Total  Charge (All):";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(366, 497);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 33);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "&Add Customer";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label12.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(597, 504);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(233, 26);
            this.label12.TabIndex = 20;
            this.label12.Text = "Number of Customers:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblkWhOff
            // 
            this.lblkWhOff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblkWhOff.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkWhOff.Location = new System.Drawing.Point(30, 361);
            this.lblkWhOff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkWhOff.Name = "lblkWhOff";
            this.lblkWhOff.Size = new System.Drawing.Size(303, 27);
            this.lblkWhOff.TabIndex = 14;
            this.lblkWhOff.Text = "Enter off-peak hours usage (kWh):";
            this.lblkWhOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 725);
            this.Controls.Add(this.lblkWhOff);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalAll);
            this.Controls.Add(this.txtTotalInd);
            this.Controls.Add(this.txtTotalComm);
            this.Controls.Add(this.txtTotalRes);
            this.Controls.Add(this.txtTotalCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCustomer);
            this.Controls.Add(this.txtkWhPeak);
            this.Controls.Add(this.txtkWhOff);
            this.Controls.Add(this.lblkWhPeak);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.lblkWh);
            this.Controls.Add(this.txtkWh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtkWh;
        private System.Windows.Forms.Label lblkWh;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label lblkWhPeak;
        private System.Windows.Forms.TextBox txtkWhOff;
        private System.Windows.Forms.TextBox txtkWhPeak;
        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalCustomer;
        private System.Windows.Forms.TextBox txtTotalRes;
        private System.Windows.Forms.TextBox txtTotalComm;
        private System.Windows.Forms.TextBox txtTotalInd;
        private System.Windows.Forms.TextBox txtTotalAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblkWhOff;
    }
}

