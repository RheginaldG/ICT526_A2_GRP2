namespace ICT526_A2_GRP2
{
    partial class InventoryUp
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIMcode1 = new System.Windows.Forms.ComboBox();
            this.lblIMname2 = new System.Windows.Forms.Label();
            this.grpIM2 = new System.Windows.Forms.GroupBox();
            this.lblIMcode2 = new System.Windows.Forms.Label();
            this.btnIMreturn2 = new System.Windows.Forms.Button();
            this.txtIMprc2 = new System.Windows.Forms.TextBox();
            this.btnIMupdate2 = new System.Windows.Forms.Button();
            this.txtIMdisc2 = new System.Windows.Forms.TextBox();
            this.lblIMdisc2 = new System.Windows.Forms.Label();
            this.lbIMlName2 = new System.Windows.Forms.Label();
            this.txtIMQty2 = new System.Windows.Forms.TextBox();
            this.lblIMqty2 = new System.Windows.Forms.Label();
            this.txtIMName2 = new System.Windows.Forms.TextBox();
            this.lblIMcol2 = new System.Windows.Forms.Label();
            this.lblIMprc2 = new System.Windows.Forms.Label();
            this.txtIMclr2 = new System.Windows.Forms.TextBox();
            this.grpIM2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Item Discount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Item Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Item Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Item Quantity:";
            // 
            // cmbIMcode1
            // 
            this.cmbIMcode1.FormattingEnabled = true;
            this.cmbIMcode1.Location = new System.Drawing.Point(12, 19);
            this.cmbIMcode1.Name = "cmbIMcode1";
            this.cmbIMcode1.Size = new System.Drawing.Size(170, 21);
            this.cmbIMcode1.TabIndex = 28;
            this.cmbIMcode1.SelectedIndexChanged += new System.EventHandler(this.cmbIMcode1_SelectedIndexChanged);
            // 
            // lblIMname2
            // 
            this.lblIMname2.AutoSize = true;
            this.lblIMname2.Location = new System.Drawing.Point(35, 110);
            this.lblIMname2.Name = "lblIMname2";
            this.lblIMname2.Size = new System.Drawing.Size(61, 13);
            this.lblIMname2.TabIndex = 50;
            this.lblIMname2.Text = "Item Name:";
            // 
            // grpIM2
            // 
            this.grpIM2.Controls.Add(this.lblIMcode2);
            this.grpIM2.Controls.Add(this.cmbIMcode1);
            this.grpIM2.Location = new System.Drawing.Point(24, 26);
            this.grpIM2.Name = "grpIM2";
            this.grpIM2.Size = new System.Drawing.Size(564, 67);
            this.grpIM2.TabIndex = 49;
            this.grpIM2.TabStop = false;
            this.grpIM2.Text = "Please Enter The Item Code";
            // 
            // lblIMcode2
            // 
            this.lblIMcode2.AutoSize = true;
            this.lblIMcode2.Location = new System.Drawing.Point(202, 22);
            this.lblIMcode2.Name = "lblIMcode2";
            this.lblIMcode2.Size = new System.Drawing.Size(10, 13);
            this.lblIMcode2.TabIndex = 29;
            this.lblIMcode2.Text = "-";
            // 
            // btnIMreturn2
            // 
            this.btnIMreturn2.Location = new System.Drawing.Point(447, 212);
            this.btnIMreturn2.Name = "btnIMreturn2";
            this.btnIMreturn2.Size = new System.Drawing.Size(141, 65);
            this.btnIMreturn2.TabIndex = 48;
            this.btnIMreturn2.Text = "back to inventory management";
            this.btnIMreturn2.UseVisualStyleBackColor = true;
            this.btnIMreturn2.Click += new System.EventHandler(this.btnIMreturn2_Click);
            // 
            // txtIMprc2
            // 
            this.txtIMprc2.Location = new System.Drawing.Point(232, 186);
            this.txtIMprc2.Name = "txtIMprc2";
            this.txtIMprc2.Size = new System.Drawing.Size(141, 20);
            this.txtIMprc2.TabIndex = 46;
            // 
            // btnIMupdate2
            // 
            this.btnIMupdate2.Location = new System.Drawing.Point(447, 160);
            this.btnIMupdate2.Name = "btnIMupdate2";
            this.btnIMupdate2.Size = new System.Drawing.Size(141, 46);
            this.btnIMupdate2.TabIndex = 47;
            this.btnIMupdate2.Text = "Update Item";
            this.btnIMupdate2.UseVisualStyleBackColor = true;
            this.btnIMupdate2.Click += new System.EventHandler(this.btnIMupdate2_Click);
            // 
            // txtIMdisc2
            // 
            this.txtIMdisc2.Location = new System.Drawing.Point(447, 126);
            this.txtIMdisc2.Name = "txtIMdisc2";
            this.txtIMdisc2.Size = new System.Drawing.Size(141, 20);
            this.txtIMdisc2.TabIndex = 45;
            // 
            // lblIMdisc2
            // 
            this.lblIMdisc2.AutoSize = true;
            this.lblIMdisc2.Location = new System.Drawing.Point(525, 110);
            this.lblIMdisc2.Name = "lblIMdisc2";
            this.lblIMdisc2.Size = new System.Drawing.Size(10, 13);
            this.lblIMdisc2.TabIndex = 41;
            this.lblIMdisc2.Text = "-";
            // 
            // lbIMlName2
            // 
            this.lbIMlName2.AutoSize = true;
            this.lbIMlName2.Location = new System.Drawing.Point(102, 110);
            this.lbIMlName2.Name = "lbIMlName2";
            this.lbIMlName2.Size = new System.Drawing.Size(10, 13);
            this.lbIMlName2.TabIndex = 37;
            this.lbIMlName2.Text = "-";
            // 
            // txtIMQty2
            // 
            this.txtIMQty2.Location = new System.Drawing.Point(38, 186);
            this.txtIMQty2.Name = "txtIMQty2";
            this.txtIMQty2.Size = new System.Drawing.Size(145, 20);
            this.txtIMQty2.TabIndex = 43;
            // 
            // lblIMqty2
            // 
            this.lblIMqty2.AutoSize = true;
            this.lblIMqty2.Location = new System.Drawing.Point(113, 170);
            this.lblIMqty2.Name = "lblIMqty2";
            this.lblIMqty2.Size = new System.Drawing.Size(10, 13);
            this.lblIMqty2.TabIndex = 38;
            this.lblIMqty2.Text = "-";
            // 
            // txtIMName2
            // 
            this.txtIMName2.Location = new System.Drawing.Point(38, 126);
            this.txtIMName2.Name = "txtIMName2";
            this.txtIMName2.Size = new System.Drawing.Size(145, 20);
            this.txtIMName2.TabIndex = 42;
            // 
            // lblIMcol2
            // 
            this.lblIMcol2.AutoSize = true;
            this.lblIMcol2.Location = new System.Drawing.Point(292, 110);
            this.lblIMcol2.Name = "lblIMcol2";
            this.lblIMcol2.Size = new System.Drawing.Size(10, 13);
            this.lblIMcol2.TabIndex = 39;
            this.lblIMcol2.Text = "-";
            // 
            // lblIMprc2
            // 
            this.lblIMprc2.AutoSize = true;
            this.lblIMprc2.Location = new System.Drawing.Point(292, 170);
            this.lblIMprc2.Name = "lblIMprc2";
            this.lblIMprc2.Size = new System.Drawing.Size(10, 13);
            this.lblIMprc2.TabIndex = 40;
            this.lblIMprc2.Text = "-";
            // 
            // txtIMclr2
            // 
            this.txtIMclr2.Location = new System.Drawing.Point(232, 126);
            this.txtIMclr2.Name = "txtIMclr2";
            this.txtIMclr2.Size = new System.Drawing.Size(141, 20);
            this.txtIMclr2.TabIndex = 44;
            // 
            // InventoryUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 334);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIMname2);
            this.Controls.Add(this.grpIM2);
            this.Controls.Add(this.btnIMreturn2);
            this.Controls.Add(this.txtIMprc2);
            this.Controls.Add(this.btnIMupdate2);
            this.Controls.Add(this.txtIMdisc2);
            this.Controls.Add(this.lblIMdisc2);
            this.Controls.Add(this.lbIMlName2);
            this.Controls.Add(this.txtIMQty2);
            this.Controls.Add(this.lblIMqty2);
            this.Controls.Add(this.txtIMName2);
            this.Controls.Add(this.lblIMcol2);
            this.Controls.Add(this.lblIMprc2);
            this.Controls.Add(this.txtIMclr2);
            this.Name = "InventoryUp";
            this.Text = "InventoryUp";
            this.Load += new System.EventHandler(this.InventoryUp_Load);
            this.grpIM2.ResumeLayout(false);
            this.grpIM2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIMcode1;
        private System.Windows.Forms.Label lblIMname2;
        private System.Windows.Forms.GroupBox grpIM2;
        private System.Windows.Forms.Label lblIMcode2;
        private System.Windows.Forms.Button btnIMreturn2;
        private System.Windows.Forms.TextBox txtIMprc2;
        private System.Windows.Forms.Button btnIMupdate2;
        private System.Windows.Forms.TextBox txtIMdisc2;
        private System.Windows.Forms.Label lblIMdisc2;
        private System.Windows.Forms.Label lbIMlName2;
        private System.Windows.Forms.TextBox txtIMQty2;
        private System.Windows.Forms.Label lblIMqty2;
        private System.Windows.Forms.TextBox txtIMName2;
        private System.Windows.Forms.Label lblIMcol2;
        private System.Windows.Forms.Label lblIMprc2;
        private System.Windows.Forms.TextBox txtIMclr2;
    }
}