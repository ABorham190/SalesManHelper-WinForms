namespace SalesManHelper
{
    partial class frmAddEditCustomer
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
            this.btnClose = new My_Custom_control_Library.CustomControl2();
            this.btnSave = new My_Custom_control_Library.CustomControl2();
            this.gbxCustomer = new System.Windows.Forms.GroupBox();
            this.tbxCreditLimit = new My_Custom_control_Library.MyTextBox2();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxBusinessType = new System.Windows.Forms.ComboBox();
            this.tbxEmail = new My_Custom_control_Library.MyTextBox2();
            this.tbxPhone = new My_Custom_control_Library.MyTextBox2();
            this.tbxAddress = new My_Custom_control_Library.MyTextBox2();
            this.tbxName = new My_Custom_control_Library.MyTextBox2();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picboxOwnerImage = new System.Windows.Forms.PictureBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUpdateCustomerInfo = new System.Windows.Forms.Label();
            this.lblAddNewCustomer = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxOwnerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.ButtonText = My_Custom_control_Library.CustomControl2.enButtonText.Close;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::SalesManHelper.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(58, 294);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 34);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.ButtonText = My_Custom_control_Library.CustomControl2.enButtonText.Save;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Image = global::SalesManHelper.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(494, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbxCustomer
            // 
            this.gbxCustomer.Controls.Add(this.tbxCreditLimit);
            this.gbxCustomer.Controls.Add(this.label2);
            this.gbxCustomer.Controls.Add(this.cbxBusinessType);
            this.gbxCustomer.Controls.Add(this.tbxEmail);
            this.gbxCustomer.Controls.Add(this.tbxPhone);
            this.gbxCustomer.Controls.Add(this.tbxAddress);
            this.gbxCustomer.Controls.Add(this.tbxName);
            this.gbxCustomer.Controls.Add(this.label7);
            this.gbxCustomer.Controls.Add(this.label10);
            this.gbxCustomer.Controls.Add(this.label9);
            this.gbxCustomer.Controls.Add(this.label8);
            this.gbxCustomer.Controls.Add(this.label3);
            this.gbxCustomer.Controls.Add(this.picboxOwnerImage);
            this.gbxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCustomer.Location = new System.Drawing.Point(12, 70);
            this.gbxCustomer.Name = "gbxCustomer";
            this.gbxCustomer.Size = new System.Drawing.Size(684, 207);
            this.gbxCustomer.TabIndex = 0;
            this.gbxCustomer.TabStop = false;
            // 
            // tbxCreditLimit
            // 
            this.tbxCreditLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCreditLimit.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Number;
            this.tbxCreditLimit.IsRequired = false;
            this.tbxCreditLimit.Location = new System.Drawing.Point(400, 54);
            this.tbxCreditLimit.Name = "tbxCreditLimit";
            this.tbxCreditLimit.Size = new System.Drawing.Size(100, 21);
            this.tbxCreditLimit.TabIndex = 5;
            this.tbxCreditLimit.Validating += new System.ComponentModel.CancelEventHandler(this._CheckValidity);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Credit Limit : ";
            // 
            // cbxBusinessType
            // 
            this.cbxBusinessType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBusinessType.FormattingEnabled = true;
            this.cbxBusinessType.Items.AddRange(new object[] {
            "Dairy Farm",
            "Fattening Farm",
            "Distributor",
            "Sales Center",
            "Pharmacy",
            "Doctor"});
            this.cbxBusinessType.Location = new System.Drawing.Point(138, 52);
            this.cbxBusinessType.Name = "cbxBusinessType";
            this.cbxBusinessType.Size = new System.Drawing.Size(145, 23);
            this.cbxBusinessType.TabIndex = 1;
            // 
            // tbxEmail
            // 
            this.tbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEmail.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Text;
            this.tbxEmail.IsRequired = false;
            this.tbxEmail.Location = new System.Drawing.Point(138, 103);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(286, 21);
            this.tbxEmail.TabIndex = 3;
            this.tbxEmail.Validating += new System.ComponentModel.CancelEventHandler(this._CheckValidity);
            // 
            // tbxPhone
            // 
            this.tbxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPhone.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Text;
            this.tbxPhone.IsRequired = true;
            this.tbxPhone.Location = new System.Drawing.Point(138, 79);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(145, 21);
            this.tbxPhone.TabIndex = 2;
            this.tbxPhone.Tag = "4";
            this.tbxPhone.Validating += new System.ComponentModel.CancelEventHandler(this._CheckValidity);
            // 
            // tbxAddress
            // 
            this.tbxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAddress.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Text;
            this.tbxAddress.IsRequired = true;
            this.tbxAddress.Location = new System.Drawing.Point(138, 128);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(363, 59);
            this.tbxAddress.TabIndex = 4;
            this.tbxAddress.Tag = "0";
            this.tbxAddress.Validating += new System.ComponentModel.CancelEventHandler(this._CheckValidity);
            // 
            // tbxName
            // 
            this.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxName.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Text;
            this.tbxName.IsRequired = true;
            this.tbxName.Location = new System.Drawing.Point(138, 27);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(286, 21);
            this.tbxName.TabIndex = 0;
            this.tbxName.Tag = "0";
            this.tbxName.Validating += new System.ComponentModel.CancelEventHandler(this._CheckValidity);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Phone : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Business Type : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Address : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(83, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // picboxOwnerImage
            // 
            this.picboxOwnerImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxOwnerImage.Location = new System.Drawing.Point(546, 31);
            this.picboxOwnerImage.Name = "picboxOwnerImage";
            this.picboxOwnerImage.Size = new System.Drawing.Size(123, 112);
            this.picboxOwnerImage.TabIndex = 3;
            this.picboxOwnerImage.TabStop = false;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(55, 53);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(29, 15);
            this.lblCustomerID.TabIndex = 20;
            this.lblCustomerID.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "ID : ";
            // 
            // lblUpdateCustomerInfo
            // 
            this.lblUpdateCustomerInfo.AutoSize = true;
            this.lblUpdateCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateCustomerInfo.Location = new System.Drawing.Point(234, 14);
            this.lblUpdateCustomerInfo.Name = "lblUpdateCustomerInfo";
            this.lblUpdateCustomerInfo.Size = new System.Drawing.Size(240, 25);
            this.lblUpdateCustomerInfo.TabIndex = 8;
            this.lblUpdateCustomerInfo.Text = "Update Customer Info";
            // 
            // lblAddNewCustomer
            // 
            this.lblAddNewCustomer.AutoSize = true;
            this.lblAddNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewCustomer.Location = new System.Drawing.Point(248, 22);
            this.lblAddNewCustomer.Name = "lblAddNewCustomer";
            this.lblAddNewCustomer.Size = new System.Drawing.Size(212, 25);
            this.lblAddNewCustomer.TabIndex = 7;
            this.lblAddNewCustomer.Text = "Add New Customer";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 348);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxCustomer);
            this.Controls.Add(this.lblUpdateCustomerInfo);
            this.Controls.Add(this.lblAddNewCustomer);
            this.Controls.Add(this.label6);
            this.Name = "frmAddEditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditCustomer";
            this.Load += new System.EventHandler(this.frmAddEditCustomer_Load);
            this.gbxCustomer.ResumeLayout(false);
            this.gbxCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxOwnerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private My_Custom_control_Library.CustomControl2 btnClose;
        private My_Custom_control_Library.CustomControl2 btnSave;
        private System.Windows.Forms.GroupBox gbxCustomer;
        private System.Windows.Forms.Label lblCustomerID;
        private My_Custom_control_Library.MyTextBox2 tbxEmail;
        private My_Custom_control_Library.MyTextBox2 tbxPhone;
        private My_Custom_control_Library.MyTextBox2 tbxAddress;
        private My_Custom_control_Library.MyTextBox2 tbxName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picboxOwnerImage;
        private System.Windows.Forms.Label lblUpdateCustomerInfo;
        private System.Windows.Forms.Label lblAddNewCustomer;
        private System.Windows.Forms.ComboBox cbxBusinessType;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private My_Custom_control_Library.MyTextBox2 tbxCreditLimit;
        private System.Windows.Forms.Label label2;
    }
}