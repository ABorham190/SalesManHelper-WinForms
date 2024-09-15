namespace SalesManHelper
{
    partial class frmAddNewCollection
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
            this.tbxAmount = new My_Custom_control_Library.MyTextBox2();
            this.cbxCustomers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDebit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCollectionType = new System.Windows.Forms.ComboBox();
            this.btnSave = new My_Custom_control_Library.CustomControl2();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCollectionID = new System.Windows.Forms.Label();
            this.gbxChequeInfo = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblChequeID = new System.Windows.Forms.Label();
            this.lblCollectionID2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxChequeNumber = new My_Custom_control_Library.MyTextBox2();
            this.tbxChequeValue = new My_Custom_control_Library.MyTextBox2();
            this.dtpChequeDueDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxBanksList = new System.Windows.Forms.ComboBox();
            this.gbxChequeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxAmount
            // 
            this.tbxAmount.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Number;
            this.tbxAmount.IsRequired = false;
            this.tbxAmount.Location = new System.Drawing.Point(113, 103);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(100, 20);
            this.tbxAmount.TabIndex = 0;
            // 
            // cbxCustomers
            // 
            this.cbxCustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCustomers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCustomers.FormattingEnabled = true;
            this.cbxCustomers.Location = new System.Drawing.Point(540, 59);
            this.cbxCustomers.Name = "cbxCustomers";
            this.cbxCustomers.Size = new System.Drawing.Size(213, 21);
            this.cbxCustomers.TabIndex = 2;
            this.cbxCustomers.SelectedIndexChanged += new System.EventHandler(this.cbxCustomers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name : ";
            // 
            // lblDebit
            // 
            this.lblDebit.AutoSize = true;
            this.lblDebit.Location = new System.Drawing.Point(104, 59);
            this.lblDebit.Name = "lblDebit";
            this.lblDebit.Size = new System.Drawing.Size(37, 13);
            this.lblDebit.TabIndex = 4;
            this.lblDebit.Text = "[????]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Debit : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Collection Type : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount : ";
            // 
            // cbxCollectionType
            // 
            this.cbxCollectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCollectionType.FormattingEnabled = true;
            this.cbxCollectionType.Location = new System.Drawing.Point(540, 95);
            this.cbxCollectionType.Name = "cbxCollectionType";
            this.cbxCollectionType.Size = new System.Drawing.Size(213, 21);
            this.cbxCollectionType.TabIndex = 8;
            this.cbxCollectionType.SelectedIndexChanged += new System.EventHandler(this.cbxCollectionType_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.ButtonText = My_Custom_control_Library.CustomControl2.enButtonText.Save;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Image = global::SalesManHelper.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(156, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 34);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Collection ID : ";
            // 
            // lblCollectionID
            // 
            this.lblCollectionID.AutoSize = true;
            this.lblCollectionID.Location = new System.Drawing.Point(104, 31);
            this.lblCollectionID.Name = "lblCollectionID";
            this.lblCollectionID.Size = new System.Drawing.Size(37, 13);
            this.lblCollectionID.TabIndex = 11;
            this.lblCollectionID.Text = "[????]";
            // 
            // gbxChequeInfo
            // 
            this.gbxChequeInfo.Controls.Add(this.cbxBanksList);
            this.gbxChequeInfo.Controls.Add(this.label7);
            this.gbxChequeInfo.Controls.Add(this.dtpChequeDueDate);
            this.gbxChequeInfo.Controls.Add(this.tbxChequeValue);
            this.gbxChequeInfo.Controls.Add(this.tbxChequeNumber);
            this.gbxChequeInfo.Controls.Add(this.label11);
            this.gbxChequeInfo.Controls.Add(this.label10);
            this.gbxChequeInfo.Controls.Add(this.label8);
            this.gbxChequeInfo.Controls.Add(this.label9);
            this.gbxChequeInfo.Controls.Add(this.lblCollectionID2);
            this.gbxChequeInfo.Controls.Add(this.lblChequeID);
            this.gbxChequeInfo.Controls.Add(this.label6);
            this.gbxChequeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxChequeInfo.Location = new System.Drawing.Point(437, 154);
            this.gbxChequeInfo.Name = "gbxChequeInfo";
            this.gbxChequeInfo.Size = new System.Drawing.Size(316, 181);
            this.gbxChequeInfo.TabIndex = 12;
            this.gbxChequeInfo.TabStop = false;
            this.gbxChequeInfo.Text = "Cheque Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cheque ID : ";
            // 
            // lblChequeID
            // 
            this.lblChequeID.AutoSize = true;
            this.lblChequeID.ForeColor = System.Drawing.Color.Red;
            this.lblChequeID.Location = new System.Drawing.Point(83, 26);
            this.lblChequeID.Name = "lblChequeID";
            this.lblChequeID.Size = new System.Drawing.Size(43, 13);
            this.lblChequeID.TabIndex = 1;
            this.lblChequeID.Text = "[????]";
            // 
            // lblCollectionID2
            // 
            this.lblCollectionID2.AutoSize = true;
            this.lblCollectionID2.Location = new System.Drawing.Point(247, 26);
            this.lblCollectionID2.Name = "lblCollectionID2";
            this.lblCollectionID2.Size = new System.Drawing.Size(43, 13);
            this.lblCollectionID2.TabIndex = 2;
            this.lblCollectionID2.Text = "[????]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Collection ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Chq. Val. : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "DueDate : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Chq. Num. : ";
            // 
            // tbxChequeNumber
            // 
            this.tbxChequeNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxChequeNumber.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Number;
            this.tbxChequeNumber.IsRequired = false;
            this.tbxChequeNumber.Location = new System.Drawing.Point(95, 53);
            this.tbxChequeNumber.Name = "tbxChequeNumber";
            this.tbxChequeNumber.Size = new System.Drawing.Size(195, 20);
            this.tbxChequeNumber.TabIndex = 7;
            // 
            // tbxChequeValue
            // 
            this.tbxChequeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxChequeValue.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Number;
            this.tbxChequeValue.IsRequired = false;
            this.tbxChequeValue.Location = new System.Drawing.Point(95, 84);
            this.tbxChequeValue.Name = "tbxChequeValue";
            this.tbxChequeValue.Size = new System.Drawing.Size(195, 20);
            this.tbxChequeValue.TabIndex = 8;
            // 
            // dtpChequeDueDate
            // 
            this.dtpChequeDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpChequeDueDate.Location = new System.Drawing.Point(95, 138);
            this.dtpChequeDueDate.Name = "dtpChequeDueDate";
            this.dtpChequeDueDate.Size = new System.Drawing.Size(110, 20);
            this.dtpChequeDueDate.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Bank : ";
            // 
            // cbxBanksList
            // 
            this.cbxBanksList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBanksList.FormattingEnabled = true;
            this.cbxBanksList.Location = new System.Drawing.Point(95, 112);
            this.cbxBanksList.MaxDropDownItems = 50;
            this.cbxBanksList.Name = "cbxBanksList";
            this.cbxBanksList.Size = new System.Drawing.Size(195, 21);
            this.cbxBanksList.TabIndex = 13;
            // 
            // frmAddNewCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxChequeInfo);
            this.Controls.Add(this.lblCollectionID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxCollectionType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDebit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCustomers);
            this.Controls.Add(this.tbxAmount);
            this.Name = "frmAddNewCollection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddNewCollection";
            this.Load += new System.EventHandler(this.frmAddNewCollection_Load);
            this.gbxChequeInfo.ResumeLayout(false);
            this.gbxChequeInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private My_Custom_control_Library.MyTextBox2 tbxAmount;
        private System.Windows.Forms.ComboBox cbxCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDebit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCollectionType;
        private My_Custom_control_Library.CustomControl2 btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCollectionID;
        private System.Windows.Forms.GroupBox gbxChequeInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCollectionID2;
        private System.Windows.Forms.Label lblChequeID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpChequeDueDate;
        private My_Custom_control_Library.MyTextBox2 tbxChequeValue;
        private My_Custom_control_Library.MyTextBox2 tbxChequeNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxBanksList;
    }
}