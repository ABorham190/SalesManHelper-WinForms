namespace SalesManHelper
{
    partial class frmProductDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new My_Custom_control_Library.CustomControl2();
            this.llabelEditProductInfo = new System.Windows.Forms.LinkLabel();
            this.ctrlShowProductDetails1 = new MyControlLib_SMH_.ctrlShowProductDetails();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(193, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Details";
            // 
            // btnClose
            // 
            this.btnClose.ButtonText = My_Custom_control_Library.CustomControl2.enButtonText.Close;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::SalesManHelper.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(236, 325);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 34);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // llabelEditProductInfo
            // 
            this.llabelEditProductInfo.AutoSize = true;
            this.llabelEditProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llabelEditProductInfo.Location = new System.Drawing.Point(371, 112);
            this.llabelEditProductInfo.Name = "llabelEditProductInfo";
            this.llabelEditProductInfo.Size = new System.Drawing.Size(86, 13);
            this.llabelEditProductInfo.TabIndex = 40;
            this.llabelEditProductInfo.TabStop = true;
            this.llabelEditProductInfo.Text = "Edit Product Info";
            this.llabelEditProductInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llabelEditProductInfo_LinkClicked);
            // 
            // ctrlShowProductDetails1
            // 
            this.ctrlShowProductDetails1.Location = new System.Drawing.Point(12, 71);
            this.ctrlShowProductDetails1.Name = "ctrlShowProductDetails1";
            this.ctrlShowProductDetails1.Size = new System.Drawing.Size(539, 248);
            this.ctrlShowProductDetails1.TabIndex = 1;
            this.ctrlShowProductDetails1.OnShowProductDetails += new System.EventHandler<MyControlLib_SMH_.ctrlShowProductDetails.clsProductEventArgs>(this.ctrlShowProductDetails1_OnShowProductDetails);
            // 
            // frmProductDetails
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 390);
            this.Controls.Add(this.llabelEditProductInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlShowProductDetails1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductDetails";
            this.Load += new System.EventHandler(this.frmProductDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MyControlLib_SMH_.ctrlShowProductDetails ctrlShowProductDetails1;
        private My_Custom_control_Library.CustomControl2 btnClose;
        private System.Windows.Forms.LinkLabel llabelEditProductInfo;
    }
}