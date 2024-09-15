namespace SalesManHelper
{
    partial class frmSalesInvoices
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSalesInvoices = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editSalesInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customControl21 = new My_Custom_control_Library.CustomControl2();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxFilterBy = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.tbxFilterBox = new System.Windows.Forms.TextBox();
            this.tbxCustName2 = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInvoices)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(315, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Invoices";
            // 
            // dgvSalesInvoices
            // 
            this.dgvSalesInvoices.AllowUserToAddRows = false;
            this.dgvSalesInvoices.AllowUserToDeleteRows = false;
            this.dgvSalesInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesInvoices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSalesInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesInvoices.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSalesInvoices.Location = new System.Drawing.Point(12, 103);
            this.dgvSalesInvoices.Name = "dgvSalesInvoices";
            this.dgvSalesInvoices.ReadOnly = true;
            this.dgvSalesInvoices.Size = new System.Drawing.Size(810, 286);
            this.dgvSalesInvoices.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSalesInvoiceToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.showDetailsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 82);
            // 
            // editSalesInvoiceToolStripMenuItem
            // 
            this.editSalesInvoiceToolStripMenuItem.Name = "editSalesInvoiceToolStripMenuItem";
            this.editSalesInvoiceToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.editSalesInvoiceToolStripMenuItem.Text = "Edit ";
            this.editSalesInvoiceToolStripMenuItem.Click += new System.EventHandler(this.editSalesInvoiceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deleteToolStripMenuItem.Text = "Delete ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(138, 6);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            // 
            // customControl21
            // 
            this.customControl21.ButtonText = My_Custom_control_Library.CustomControl2.enButtonText.Close;
            this.customControl21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customControl21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customControl21.Image = global::SalesManHelper.Properties.Resources.Close_32;
            this.customControl21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customControl21.Location = new System.Drawing.Point(365, 404);
            this.customControl21.Name = "customControl21";
            this.customControl21.Size = new System.Drawing.Size(90, 34);
            this.customControl21.TabIndex = 2;
            this.customControl21.Text = "Close";
            this.customControl21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customControl21.UseVisualStyleBackColor = true;
            this.customControl21.Click += new System.EventHandler(this.customControl21_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Records : ";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(80, 417);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(43, 13);
            this.lblRecords.TabIndex = 4;
            this.lblRecords.Text = "[????]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filter By : ";
            // 
            // cbxFilterBy
            // 
            this.cbxFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilterBy.FormattingEnabled = true;
            this.cbxFilterBy.Items.AddRange(new object[] {
            "None",
            "Date",
            "Customer Name",
            "Date & Customer Name"});
            this.cbxFilterBy.Location = new System.Drawing.Point(78, 74);
            this.cbxFilterBy.Name = "cbxFilterBy";
            this.cbxFilterBy.Size = new System.Drawing.Size(128, 21);
            this.cbxFilterBy.TabIndex = 6;
            this.cbxFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbxFilterBy_SelectedIndexChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(213, 78);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(46, 13);
            this.lblFrom.TabIndex = 8;
            this.lblFrom.Text = "From : ";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(258, 75);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(95, 20);
            this.dtpDateFrom.TabIndex = 9;
            this.dtpDateFrom.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(395, 75);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(95, 20);
            this.dtpDateTo.TabIndex = 10;
            this.dtpDateTo.ValueChanged += new System.EventHandler(this.dtpDateTo_ValueChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(358, 78);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(34, 13);
            this.lblTo.TabIndex = 11;
            this.lblTo.Text = "To : ";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(656, 417);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(43, 13);
            this.lblTotalSales.TabIndex = 13;
            this.lblTotalSales.Text = "[????]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(574, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total Sales : ";
            // 
            // btnShow
            // 
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(526, 62);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 36);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // tbxFilterBox
            // 
            this.tbxFilterBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFilterBox.Location = new System.Drawing.Point(216, 74);
            this.tbxFilterBox.Name = "tbxFilterBox";
            this.tbxFilterBox.Size = new System.Drawing.Size(173, 20);
            this.tbxFilterBox.TabIndex = 15;
            this.tbxFilterBox.TextChanged += new System.EventHandler(this.tbxFilterBox_TextChanged);
            // 
            // tbxCustName2
            // 
            this.tbxCustName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCustName2.Location = new System.Drawing.Point(659, 74);
            this.tbxCustName2.Name = "tbxCustName2";
            this.tbxCustName2.Size = new System.Drawing.Size(163, 20);
            this.tbxCustName2.TabIndex = 16;
            this.tbxCustName2.TextChanged += new System.EventHandler(this.tbxCustName2_TextChanged);
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(607, 77);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(51, 13);
            this.lblCustName.TabIndex = 17;
            this.lblCustName.Text = "Name : ";
            // 
            // frmSalesInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.tbxCustName2);
            this.Controls.Add(this.tbxFilterBox);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.cbxFilterBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customControl21);
            this.Controls.Add(this.dgvSalesInvoices);
            this.Controls.Add(this.label1);
            this.Name = "frmSalesInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalesInvoices";
            this.Load += new System.EventHandler(this.frmSalesInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInvoices)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSalesInvoices;
        private My_Custom_control_Library.CustomControl2 customControl21;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editSalesInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxFilterBy;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox tbxFilterBox;
        private System.Windows.Forms.TextBox tbxCustName2;
        private System.Windows.Forms.Label lblCustName;
    }
}