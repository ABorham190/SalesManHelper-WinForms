namespace SalesManHelper
{
    partial class frmAddEditSupplierInfo
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
            this.lblAddNewSupplier = new System.Windows.Forms.Label();
            this.lblUpdateSupplierInfo = new System.Windows.Forms.Label();
            this.picboxOwnerImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAupplierID = new System.Windows.Forms.Label();
            this.tbxEmail = new My_Custom_control_Library.MyTextBox2();
            this.tbxPhone = new My_Custom_control_Library.MyTextBox2();
            this.tbxAddress = new My_Custom_control_Library.MyTextBox2();
            this.tbxTaxID = new My_Custom_control_Library.MyTextBox2();
            this.tbxCR = new My_Custom_control_Library.MyTextBox2();
            this.tbxOwner = new My_Custom_control_Library.MyTextBox2();
            this.tbxCoName = new My_Custom_control_Library.MyTextBox2();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new My_Custom_control_Library.CustomControl2();
            this.btnClose = new My_Custom_control_Library.CustomControl2();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picboxOwnerImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddNewSupplier
            // 
            this.lblAddNewSupplier.AutoSize = true;
            this.lblAddNewSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewSupplier.Location = new System.Drawing.Point(202, 35);
            this.lblAddNewSupplier.Name = "lblAddNewSupplier";
            this.lblAddNewSupplier.Size = new System.Drawing.Size(199, 25);
            this.lblAddNewSupplier.TabIndex = 1;
            this.lblAddNewSupplier.Text = "Add New Supplier";
            // 
            // lblUpdateSupplierInfo
            // 
            this.lblUpdateSupplierInfo.AutoSize = true;
            this.lblUpdateSupplierInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateSupplierInfo.Location = new System.Drawing.Point(193, 27);
            this.lblUpdateSupplierInfo.Name = "lblUpdateSupplierInfo";
            this.lblUpdateSupplierInfo.Size = new System.Drawing.Size(227, 25);
            this.lblUpdateSupplierInfo.TabIndex = 2;
            this.lblUpdateSupplierInfo.Text = "Update Supplier Info";
            // 
            // picboxOwnerImage
            // 
            this.picboxOwnerImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxOwnerImage.Location = new System.Drawing.Point(482, 45);
            this.picboxOwnerImage.Name = "picboxOwnerImage";
            this.picboxOwnerImage.Size = new System.Drawing.Size(123, 112);
            this.picboxOwnerImage.TabIndex = 3;
            this.picboxOwnerImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAupplierID);
            this.groupBox1.Controls.Add(this.tbxEmail);
            this.groupBox1.Controls.Add(this.tbxPhone);
            this.groupBox1.Controls.Add(this.tbxAddress);
            this.groupBox1.Controls.Add(this.tbxTaxID);
            this.groupBox1.Controls.Add(this.tbxCR);
            this.groupBox1.Controls.Add(this.tbxOwner);
            this.groupBox1.Controls.Add(this.tbxCoName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.picboxOwnerImage);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 207);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblAupplierID
            // 
            this.lblAupplierID.AutoSize = true;
            this.lblAupplierID.Location = new System.Drawing.Point(351, 27);
            this.lblAupplierID.Name = "lblAupplierID";
            this.lblAupplierID.Size = new System.Drawing.Size(29, 15);
            this.lblAupplierID.TabIndex = 20;
            this.lblAupplierID.Text = "N/A";
            // 
            // tbxEmail
            // 
            this.tbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEmail.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Text;
            this.tbxEmail.IsRequired = false;
            this.tbxEmail.Location = new System.Drawing.Point(312, 102);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(145, 21);
            this.tbxEmail.TabIndex = 19;
            this.tbxEmail.Validating += new System.ComponentModel.CancelEventHandler(this._CheckValidity);
            // 
            // tbxPhone
            // 
            this.tbxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPhone.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Text;
            this.tbxPhone.IsRequired = true;
            this.tbxPhone.Location = new System.Drawing.Point(312, 79);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(145, 21);
            this.tbxPhone.TabIndex = 18;
            this.tbxPhone.Tag = "4";
            this.tbxPhone.Validating += new System.ComponentModel.CancelEventHandler(this._CheckValidity);
            // 
            // tbxAddress
            // 
            this.tbxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAddress.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Text;
            this.tbxAddress.IsRequired = true;
            this.tbxAddress.Location = new System.Drawing.Point(94, 125);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(363, 59);
            this.tbxAddress.TabIndex = 16;
            this.tbxAddress.Tag = "0";
            this.tbxAddress.Validating += new System.ComponentModel.CancelEventHandler(this._CheckValidity);
            // 
            // tbxTaxID
            // 
            this.tbxTaxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxTaxID.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Text;
            this.tbxTaxID.IsRequired = false;
            this.tbxTaxID.Location = new System.Drawing.Point(94, 102);
            this.tbxTaxID.Name = "tbxTaxID";
            this.tbxTaxID.Size = new System.Drawing.Size(142, 21);
            this.tbxTaxID.TabIndex = 15;
            this.tbxTaxID.Validating += new System.ComponentModel.CancelEventHandler(this._CheckValidity);
            // 
            // tbxCR
            // 
            this.tbxCR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCR.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Text;
            this.tbxCR.IsRequired = false;
            this.tbxCR.Location = new System.Drawing.Point(94, 79);
            this.tbxCR.Name = "tbxCR";
            this.tbxCR.Size = new System.Drawing.Size(142, 21);
            this.tbxCR.TabIndex = 14;
            this.tbxCR.Validating += new System.ComponentModel.CancelEventHandler(this._CheckValidity);
            // 
            // tbxOwner
            // 
            this.tbxOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxOwner.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Text;
            this.tbxOwner.IsRequired = true;
            this.tbxOwner.Location = new System.Drawing.Point(94, 56);
            this.tbxOwner.Name = "tbxOwner";
            this.tbxOwner.Size = new System.Drawing.Size(199, 21);
            this.tbxOwner.TabIndex = 13;
            this.tbxOwner.Tag = "0";
            this.tbxOwner.Validating += new System.ComponentModel.CancelEventHandler(this._CheckValidity);
            // 
            // tbxCoName
            // 
            this.tbxCoName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCoName.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Text;
            this.tbxCoName.IsRequired = true;
            this.tbxCoName.Location = new System.Drawing.Point(94, 27);
            this.tbxCoName.Name = "tbxCoName";
            this.tbxCoName.Size = new System.Drawing.Size(199, 21);
            this.tbxCoName.TabIndex = 12;
            this.tbxCoName.Tag = "0";
            this.tbxCoName.Validating += new System.ComponentModel.CancelEventHandler(this._CheckValidity);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Owner : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Address : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Phone : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "ID : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tax ID : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "C.R : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Co. Name : ";
            // 
            // btnSave
            // 
            this.btnSave.ButtonText = My_Custom_control_Library.CustomControl2.enButtonText.Save;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Image = global::SalesManHelper.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(490, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 34);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.ButtonText = My_Custom_control_Library.CustomControl2.enButtonText.Close;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::SalesManHelper.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(54, 307);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditSupplierInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 356);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblUpdateSupplierInfo);
            this.Controls.Add(this.lblAddNewSupplier);
            this.Name = "frmAddEditSupplierInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditSupplierInfo";
            this.Load += new System.EventHandler(this.frmAddEditSupplierInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxOwnerImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAddNewSupplier;
        private System.Windows.Forms.Label lblUpdateSupplierInfo;
        private System.Windows.Forms.PictureBox picboxOwnerImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private My_Custom_control_Library.MyTextBox2 tbxEmail;
        private My_Custom_control_Library.MyTextBox2 tbxPhone;
        private My_Custom_control_Library.MyTextBox2 tbxAddress;
        private My_Custom_control_Library.MyTextBox2 tbxTaxID;
        private My_Custom_control_Library.MyTextBox2 tbxCR;
        private My_Custom_control_Library.MyTextBox2 tbxOwner;
        private My_Custom_control_Library.MyTextBox2 tbxCoName;
        private My_Custom_control_Library.CustomControl2 btnSave;
        private My_Custom_control_Library.CustomControl2 btnClose;
        private System.Windows.Forms.Label lblAupplierID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}