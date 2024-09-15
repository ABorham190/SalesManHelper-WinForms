namespace MyControlLib_SMH_
{
    partial class ctrAddEditProductInfo
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxCompany = new My_Custom_control_Library.MyTextBox2();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxProductType = new System.Windows.Forms.ComboBox();
            this.tbxConc = new My_Custom_control_Library.MyTextBox2();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNotes = new My_Custom_control_Library.MyTextBox2();
            this.tbxActiveIng = new My_Custom_control_Library.MyTextBox2();
            this.tbxProductName = new My_Custom_control_Library.MyTextBox2();
            this.tbxUnit = new My_Custom_control_Library.MyTextBox2();
            this.tbxBrandName = new My_Custom_control_Library.MyTextBox2();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxCompany);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbxProductType);
            this.groupBox1.Controls.Add(this.tbxConc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxNotes);
            this.groupBox1.Controls.Add(this.tbxActiveIng);
            this.groupBox1.Controls.Add(this.tbxProductName);
            this.groupBox1.Controls.Add(this.tbxUnit);
            this.groupBox1.Controls.Add(this.tbxBrandName);
            this.groupBox1.Location = new System.Drawing.Point(6, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tbxCompany
            // 
            this.tbxCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCompany.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Text;
            this.tbxCompany.IsRequired = true;
            this.tbxCompany.Location = new System.Drawing.Point(428, 128);
            this.tbxCompany.Name = "tbxCompany";
            this.tbxCompany.Size = new System.Drawing.Size(132, 22);
            this.tbxCompany.TabIndex = 24;
            this.tbxCompany.Validating += new System.ComponentModel.CancelEventHandler(this.CheckValidity);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(315, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Company :";
            // 
            // cbxProductType
            // 
            this.cbxProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProductType.FormattingEnabled = true;
            this.cbxProductType.Location = new System.Drawing.Point(428, 90);
            this.cbxProductType.Name = "cbxProductType";
            this.cbxProductType.Size = new System.Drawing.Size(132, 21);
            this.cbxProductType.TabIndex = 5;
            // 
            // tbxConc
            // 
            this.tbxConc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxConc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConc.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Number;
            this.tbxConc.IsRequired = false;
            this.tbxConc.Location = new System.Drawing.Point(428, 56);
            this.tbxConc.Name = "tbxConc";
            this.tbxConc.Size = new System.Drawing.Size(100, 22);
            this.tbxConc.TabIndex = 4;
            this.tbxConc.Validating += new System.ComponentModel.CancelEventHandler(this.CheckValidity);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Notes : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Concentration : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Active Ing : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Type : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Unit : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Brand Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Product Name : ";
            // 
            // tbxNotes
            // 
            this.tbxNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNotes.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Text;
            this.tbxNotes.IsRequired = false;
            this.tbxNotes.Location = new System.Drawing.Point(154, 125);
            this.tbxNotes.Multiline = true;
            this.tbxNotes.Name = "tbxNotes";
            this.tbxNotes.Size = new System.Drawing.Size(148, 56);
            this.tbxNotes.TabIndex = 6;
            this.tbxNotes.Validating += new System.ComponentModel.CancelEventHandler(this.CheckValidity);
            // 
            // tbxActiveIng
            // 
            this.tbxActiveIng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxActiveIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveIng.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Text;
            this.tbxActiveIng.IsRequired = false;
            this.tbxActiveIng.Location = new System.Drawing.Point(428, 21);
            this.tbxActiveIng.Name = "tbxActiveIng";
            this.tbxActiveIng.Size = new System.Drawing.Size(132, 22);
            this.tbxActiveIng.TabIndex = 3;
            this.tbxActiveIng.Validating += new System.ComponentModel.CancelEventHandler(this.CheckValidity);
            // 
            // tbxProductName
            // 
            this.tbxProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductName.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Text;
            this.tbxProductName.IsRequired = true;
            this.tbxProductName.Location = new System.Drawing.Point(154, 21);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(148, 22);
            this.tbxProductName.TabIndex = 0;
            this.tbxProductName.Validating += new System.ComponentModel.CancelEventHandler(this.CheckValidity);
            // 
            // tbxUnit
            // 
            this.tbxUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUnit.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Number;
            this.tbxUnit.IsRequired = true;
            this.tbxUnit.Location = new System.Drawing.Point(154, 56);
            this.tbxUnit.Name = "tbxUnit";
            this.tbxUnit.Size = new System.Drawing.Size(100, 22);
            this.tbxUnit.TabIndex = 1;
            this.tbxUnit.Validating += new System.ComponentModel.CancelEventHandler(this.CheckValidity);
            // 
            // tbxBrandName
            // 
            this.tbxBrandName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBrandName.InPutType = My_Custom_control_Library.MyTextBox2.enInPutType.Text;
            this.tbxBrandName.IsRequired = true;
            this.tbxBrandName.Location = new System.Drawing.Point(154, 89);
            this.tbxBrandName.Name = "tbxBrandName";
            this.tbxBrandName.Size = new System.Drawing.Size(148, 22);
            this.tbxBrandName.TabIndex = 2;
            this.tbxBrandName.Validating += new System.ComponentModel.CancelEventHandler(this.CheckValidity);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrAddEditProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrAddEditProductInfo";
            this.Size = new System.Drawing.Size(612, 241);
            this.Load += new System.EventHandler(this.AddNewProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private My_Custom_control_Library.MyTextBox2 tbxNotes;
        private My_Custom_control_Library.MyTextBox2 tbxActiveIng;
        private My_Custom_control_Library.MyTextBox2 tbxProductName;
        private My_Custom_control_Library.MyTextBox2 tbxUnit;
        private My_Custom_control_Library.MyTextBox2 tbxBrandName;
        private System.Windows.Forms.ComboBox cbxProductType;
        private My_Custom_control_Library.MyTextBox2 tbxConc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private My_Custom_control_Library.MyTextBox2 tbxCompany;
        private System.Windows.Forms.Label label8;
    }
}
