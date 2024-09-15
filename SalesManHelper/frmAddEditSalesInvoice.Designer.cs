namespace SalesManHelper
{
    partial class frmAddEditSalesInvoice
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
            this.cbxProducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNumberOfUnits = new My_Custom_control_Library.MyTextBox2();
            this.cbxCustomerNames = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new My_Custom_control_Library.CustomControl2();
            this.tbxTotalAmount = new My_Custom_control_Library.MyTextBox2();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new My_Custom_control_Library.CustomControl2();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPrice = new My_Custom_control_Library.MyTextBox2();
            this.tbxPaidAmount = new My_Custom_control_Library.MyTextBox2();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSalesItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxProducts
            // 
            this.cbxProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxProducts.FormattingEnabled = true;
            this.cbxProducts.Location = new System.Drawing.Point(129, 109);
            this.cbxProducts.Name = "cbxProducts";
            this.cbxProducts.Size = new System.Drawing.Size(121, 21);
            this.cbxProducts.TabIndex = 0;
            this.cbxProducts.Validating += new System.ComponentModel.CancelEventHandler(this.cbxProducts_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Product : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number Of Units :";
            // 
            // tbxNumberOfUnits
            // 
            this.tbxNumberOfUnits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNumberOfUnits.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Number;
            this.tbxNumberOfUnits.IsRequired = true;
            this.tbxNumberOfUnits.Location = new System.Drawing.Point(129, 132);
            this.tbxNumberOfUnits.Name = "tbxNumberOfUnits";
            this.tbxNumberOfUnits.Size = new System.Drawing.Size(121, 20);
            this.tbxNumberOfUnits.TabIndex = 4;
            this.tbxNumberOfUnits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumberOfUnits_KeyPress);
            this.tbxNumberOfUnits.Validating += new System.ComponentModel.CancelEventHandler(this.tbxNumberOfUnits_Validating);
            // 
            // cbxCustomerNames
            // 
            this.cbxCustomerNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCustomerNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCustomerNames.FormattingEnabled = true;
            this.cbxCustomerNames.Location = new System.Drawing.Point(129, 182);
            this.cbxCustomerNames.Name = "cbxCustomerNames";
            this.cbxCustomerNames.Size = new System.Drawing.Size(234, 21);
            this.cbxCustomerNames.TabIndex = 6;
            this.cbxCustomerNames.SelectedIndexChanged += new System.EventHandler(this.cbxCustomerNames_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer Name : ";
            // 
            // btnAdd
            // 
            this.btnAdd.ButtonText = My_Custom_control_Library.CustomControl2.enButtonText.Save;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(586, 504);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxTotalAmount
            // 
            this.tbxTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxTotalAmount.Enabled = false;
            this.tbxTotalAmount.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Number;
            this.tbxTotalAmount.IsRequired = true;
            this.tbxTotalAmount.Location = new System.Drawing.Point(607, 156);
            this.tbxTotalAmount.Name = "tbxTotalAmount";
            this.tbxTotalAmount.Size = new System.Drawing.Size(121, 20);
            this.tbxTotalAmount.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(505, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total Amount : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.ButtonText = My_Custom_control_Library.CustomControl2.enButtonText.Save;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(723, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price : ";
            // 
            // tbxPrice
            // 
            this.tbxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPrice.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Number;
            this.tbxPrice.IsRequired = true;
            this.tbxPrice.Location = new System.Drawing.Point(129, 156);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(121, 20);
            this.tbxPrice.TabIndex = 5;
            this.tbxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrice_KeyPress);
            this.tbxPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPrice_Validating);
            // 
            // tbxPaidAmount
            // 
            this.tbxPaidAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPaidAmount.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Number;
            this.tbxPaidAmount.IsRequired = true;
            this.tbxPaidAmount.Location = new System.Drawing.Point(607, 182);
            this.tbxPaidAmount.Name = "tbxPaidAmount";
            this.tbxPaidAmount.Size = new System.Drawing.Size(121, 20);
            this.tbxPaidAmount.TabIndex = 14;
            this.tbxPaidAmount.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPaidAmount_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(509, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Paid Amount : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(14, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(840, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSalesItemToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 26);
            // 
            // deleteSalesItemToolStripMenuItem
            // 
            this.deleteSalesItemToolStripMenuItem.Name = "deleteSalesItemToolStripMenuItem";
            this.deleteSalesItemToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deleteSalesItemToolStripMenuItem.Text = "Delete Sales Item";
            this.deleteSalesItemToolStripMenuItem.Click += new System.EventHandler(this.deleteSalesItemToolStripMenuItem_Click);
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Location = new System.Drawing.Point(126, 82);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(37, 13);
            this.lblInvoiceID.TabIndex = 16;
            this.lblInvoiceID.Text = "[????]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Invoice ID : ";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.ForeColor = System.Drawing.Color.Red;
            this.lblTotalValue.Location = new System.Drawing.Point(604, 132);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(43, 13);
            this.lblTotalValue.TabIndex = 18;
            this.lblTotalValue.Text = "[????]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(519, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Total Value : ";
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.Red;
            this.lblFormHeader.Location = new System.Drawing.Point(329, 9);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(173, 31);
            this.lblFormHeader.TabIndex = 20;
            this.lblFormHeader.Text = "Form Header";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(332, 82);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(78, 25);
            this.lblCustomerName.TabIndex = 21;
            this.lblCustomerName.Text = "[????]";
            // 
            // frmAddEditSalesInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 559);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblFormHeader);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblInvoiceID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbxPaidAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxTotalAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxCustomerNames);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxNumberOfUnits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxProducts);
            this.Name = "frmAddEditSalesInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddEditSalesInvoice";
            this.Load += new System.EventHandler(this.frmAddEditSalesInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private My_Custom_control_Library.MyTextBox2 tbxNumberOfUnits;
        private System.Windows.Forms.ComboBox cbxCustomerNames;
        private System.Windows.Forms.Label label4;
        private My_Custom_control_Library.CustomControl2 btnAdd;
        private My_Custom_control_Library.MyTextBox2 tbxTotalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private My_Custom_control_Library.CustomControl2 btnSave;
        private My_Custom_control_Library.MyTextBox2 tbxPaidAmount;
        private System.Windows.Forms.Label label6;
        private My_Custom_control_Library.MyTextBox2 tbxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteSalesItemToolStripMenuItem;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Label lblCustomerName;
    }
}