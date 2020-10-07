namespace ICT526_A2_GRP2
{
    partial class InventoryMan
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
            this.btnIMUpdate1 = new System.Windows.Forms.Button();
            this.lblIMdisc1 = new System.Windows.Forms.Label();
            this.lblIMprice1 = new System.Windows.Forms.Label();
            this.lblIMCol1 = new System.Windows.Forms.Label();
            this.lblIMQuan1 = new System.Windows.Forms.Label();
            this.lblIMItemCode1 = new System.Windows.Forms.Label();
            this.lblIMName1 = new System.Windows.Forms.Label();
            this.dataIMInv1 = new System.Windows.Forms.DataGridView();
            this.btnIMAdd1 = new System.Windows.Forms.Button();
            this.txtIMdisc1 = new System.Windows.Forms.TextBox();
            this.txtIMprc1 = new System.Windows.Forms.TextBox();
            this.txtIMcol1 = new System.Windows.Forms.TextBox();
            this.txtIMQuan1 = new System.Windows.Forms.TextBox();
            this.txtIMCode1 = new System.Windows.Forms.TextBox();
            this.txtIMName1 = new System.Windows.Forms.TextBox();
            this.grpIMadd = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataIMInv1)).BeginInit();
            this.grpIMadd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIMUpdate1
            // 
            this.btnIMUpdate1.Location = new System.Drawing.Point(713, 469);
            this.btnIMUpdate1.Name = "btnIMUpdate1";
            this.btnIMUpdate1.Size = new System.Drawing.Size(75, 23);
            this.btnIMUpdate1.TabIndex = 32;
            this.btnIMUpdate1.Text = "Update Item";
            this.btnIMUpdate1.UseVisualStyleBackColor = true;
            this.btnIMUpdate1.Click += new System.EventHandler(this.btnIMUpdate1_Click);
            // 
            // lblIMdisc1
            // 
            this.lblIMdisc1.AutoSize = true;
            this.lblIMdisc1.Location = new System.Drawing.Point(356, 58);
            this.lblIMdisc1.Name = "lblIMdisc1";
            this.lblIMdisc1.Size = new System.Drawing.Size(47, 13);
            this.lblIMdisc1.TabIndex = 28;
            this.lblIMdisc1.Text = "discount";
            // 
            // lblIMprice1
            // 
            this.lblIMprice1.AutoSize = true;
            this.lblIMprice1.Location = new System.Drawing.Point(356, 17);
            this.lblIMprice1.Name = "lblIMprice1";
            this.lblIMprice1.Size = new System.Drawing.Size(33, 13);
            this.lblIMprice1.TabIndex = 27;
            this.lblIMprice1.Text = "price ";
            // 
            // lblIMCol1
            // 
            this.lblIMCol1.AutoSize = true;
            this.lblIMCol1.Location = new System.Drawing.Point(197, 58);
            this.lblIMCol1.Name = "lblIMCol1";
            this.lblIMCol1.Size = new System.Drawing.Size(31, 13);
            this.lblIMCol1.TabIndex = 26;
            this.lblIMCol1.Text = "Color";
            // 
            // lblIMQuan1
            // 
            this.lblIMQuan1.AutoSize = true;
            this.lblIMQuan1.Location = new System.Drawing.Point(197, 16);
            this.lblIMQuan1.Name = "lblIMQuan1";
            this.lblIMQuan1.Size = new System.Drawing.Size(46, 13);
            this.lblIMQuan1.TabIndex = 25;
            this.lblIMQuan1.Text = "Quantity";
            // 
            // lblIMItemCode1
            // 
            this.lblIMItemCode1.AutoSize = true;
            this.lblIMItemCode1.Location = new System.Drawing.Point(6, 58);
            this.lblIMItemCode1.Name = "lblIMItemCode1";
            this.lblIMItemCode1.Size = new System.Drawing.Size(55, 13);
            this.lblIMItemCode1.TabIndex = 24;
            this.lblIMItemCode1.Text = "Item Code";
            // 
            // lblIMName1
            // 
            this.lblIMName1.AutoSize = true;
            this.lblIMName1.Location = new System.Drawing.Point(6, 17);
            this.lblIMName1.Name = "lblIMName1";
            this.lblIMName1.Size = new System.Drawing.Size(35, 13);
            this.lblIMName1.TabIndex = 23;
            this.lblIMName1.Text = "Name";
            // 
            // dataIMInv1
            // 
            this.dataIMInv1.AllowUserToAddRows = false;
            this.dataIMInv1.AllowUserToDeleteRows = false;
            this.dataIMInv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataIMInv1.Location = new System.Drawing.Point(43, 137);
            this.dataIMInv1.Name = "dataIMInv1";
            this.dataIMInv1.ReadOnly = true;
            this.dataIMInv1.Size = new System.Drawing.Size(745, 316);
            this.dataIMInv1.TabIndex = 31;
            // 
            // btnIMAdd1
            // 
            this.btnIMAdd1.Location = new System.Drawing.Point(571, 48);
            this.btnIMAdd1.Name = "btnIMAdd1";
            this.btnIMAdd1.Size = new System.Drawing.Size(98, 23);
            this.btnIMAdd1.TabIndex = 21;
            this.btnIMAdd1.Text = "Add New Item";
            this.btnIMAdd1.UseVisualStyleBackColor = true;
            this.btnIMAdd1.Click += new System.EventHandler(this.btnIMAdd1_Click);
            // 
            // txtIMdisc1
            // 
            this.txtIMdisc1.Location = new System.Drawing.Point(359, 74);
            this.txtIMdisc1.Name = "txtIMdisc1";
            this.txtIMdisc1.Size = new System.Drawing.Size(100, 20);
            this.txtIMdisc1.TabIndex = 20;
            // 
            // txtIMprc1
            // 
            this.txtIMprc1.Location = new System.Drawing.Point(359, 33);
            this.txtIMprc1.Name = "txtIMprc1";
            this.txtIMprc1.Size = new System.Drawing.Size(100, 20);
            this.txtIMprc1.TabIndex = 19;
            // 
            // txtIMcol1
            // 
            this.txtIMcol1.Location = new System.Drawing.Point(200, 74);
            this.txtIMcol1.Name = "txtIMcol1";
            this.txtIMcol1.Size = new System.Drawing.Size(100, 20);
            this.txtIMcol1.TabIndex = 18;
            // 
            // txtIMQuan1
            // 
            this.txtIMQuan1.Location = new System.Drawing.Point(200, 33);
            this.txtIMQuan1.Name = "txtIMQuan1";
            this.txtIMQuan1.Size = new System.Drawing.Size(100, 20);
            this.txtIMQuan1.TabIndex = 17;
            // 
            // txtIMCode1
            // 
            this.txtIMCode1.Location = new System.Drawing.Point(6, 74);
            this.txtIMCode1.Name = "txtIMCode1";
            this.txtIMCode1.Size = new System.Drawing.Size(144, 20);
            this.txtIMCode1.TabIndex = 16;
            // 
            // txtIMName1
            // 
            this.txtIMName1.Location = new System.Drawing.Point(6, 33);
            this.txtIMName1.Name = "txtIMName1";
            this.txtIMName1.Size = new System.Drawing.Size(144, 20);
            this.txtIMName1.TabIndex = 15;
            // 
            // grpIMadd
            // 
            this.grpIMadd.Controls.Add(this.lblIMdisc1);
            this.grpIMadd.Controls.Add(this.lblIMprice1);
            this.grpIMadd.Controls.Add(this.lblIMCol1);
            this.grpIMadd.Controls.Add(this.lblIMQuan1);
            this.grpIMadd.Controls.Add(this.lblIMItemCode1);
            this.grpIMadd.Controls.Add(this.lblIMName1);
            this.grpIMadd.Controls.Add(this.btnIMAdd1);
            this.grpIMadd.Controls.Add(this.txtIMdisc1);
            this.grpIMadd.Controls.Add(this.txtIMprc1);
            this.grpIMadd.Controls.Add(this.txtIMcol1);
            this.grpIMadd.Controls.Add(this.txtIMQuan1);
            this.grpIMadd.Controls.Add(this.txtIMCode1);
            this.grpIMadd.Controls.Add(this.txtIMName1);
            this.grpIMadd.Location = new System.Drawing.Point(43, 21);
            this.grpIMadd.Name = "grpIMadd";
            this.grpIMadd.Size = new System.Drawing.Size(745, 110);
            this.grpIMadd.TabIndex = 33;
            this.grpIMadd.TabStop = false;
            this.grpIMadd.Text = "Add New Item";
            // 
            // InventoryMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 508);
            this.Controls.Add(this.btnIMUpdate1);
            this.Controls.Add(this.dataIMInv1);
            this.Controls.Add(this.grpIMadd);
            this.Name = "InventoryMan";
            this.Text = "Inventory Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataIMInv1)).EndInit();
            this.grpIMadd.ResumeLayout(false);
            this.grpIMadd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIMUpdate1;
        private System.Windows.Forms.Label lblIMdisc1;
        private System.Windows.Forms.Label lblIMprice1;
        private System.Windows.Forms.Label lblIMCol1;
        private System.Windows.Forms.Label lblIMQuan1;
        private System.Windows.Forms.Label lblIMItemCode1;
        private System.Windows.Forms.Label lblIMName1;
        private System.Windows.Forms.DataGridView dataIMInv1;
        private System.Windows.Forms.Button btnIMAdd1;
        private System.Windows.Forms.TextBox txtIMdisc1;
        private System.Windows.Forms.TextBox txtIMprc1;
        private System.Windows.Forms.TextBox txtIMcol1;
        private System.Windows.Forms.TextBox txtIMQuan1;
        private System.Windows.Forms.TextBox txtIMCode1;
        private System.Windows.Forms.TextBox txtIMName1;
        private System.Windows.Forms.GroupBox grpIMadd;
    }
}

