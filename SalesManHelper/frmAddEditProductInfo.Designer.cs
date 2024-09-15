namespace SalesManHelper
{
    partial class frmAddEditProductInfo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAddNewProduct = new System.Windows.Forms.Label();
            this.btnSave = new My_Custom_control_Library.CustomControl2();
            this.btnClose = new My_Custom_control_Library.CustomControl2();
            this.ctrAddEditProductInfo1 = new MyControlLib_SMH_.ctrAddEditProductInfo();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblUpdateProductInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SalesManHelper.Properties.Resources.product;
            this.pictureBox1.Location = new System.Drawing.Point(267, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblAddNewProduct
            // 
            this.lblAddNewProduct.AutoSize = true;
            this.lblAddNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewProduct.ForeColor = System.Drawing.Color.Red;
            this.lblAddNewProduct.Location = new System.Drawing.Point(229, 89);
            this.lblAddNewProduct.Name = "lblAddNewProduct";
            this.lblAddNewProduct.Size = new System.Drawing.Size(178, 25);
            this.lblAddNewProduct.TabIndex = 2;
            this.lblAddNewProduct.Text = "Add New Product";
            // 
            // btnSave
            // 
            this.btnSave.ButtonText = My_Custom_control_Library.CustomControl2.enButtonText.Save;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Image = global::SalesManHelper.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(174, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 34);
            this.btnSave.TabIndex = 3;
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
            this.btnClose.Location = new System.Drawing.Point(486, 357);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrAddEditProductInfo1
            // 
            this.ctrAddEditProductInfo1.Location = new System.Drawing.Point(12, 119);
            this.ctrAddEditProductInfo1.Name = "ctrAddEditProductInfo1";
            this.ctrAddEditProductInfo1.Size = new System.Drawing.Size(612, 241);
            this.ctrAddEditProductInfo1.TabIndex = 0;
            this.ctrAddEditProductInfo1.OnAddNewProduct += new System.EventHandler<MyControlLib_SMH_.ctrAddEditProductInfo.ProductArgs>(this.ctrAddEditProductInfo1_OnAddNewProduct);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ProductID : ";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(107, 119);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(33, 16);
            this.lblProductID.TabIndex = 6;
            this.lblProductID.Text = "N/A";
            // 
            // lblUpdateProductInfo
            // 
            this.lblUpdateProductInfo.AutoSize = true;
            this.lblUpdateProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateProductInfo.ForeColor = System.Drawing.Color.Red;
            this.lblUpdateProductInfo.Location = new System.Drawing.Point(216, 102);
            this.lblUpdateProductInfo.Name = "lblUpdateProductInfo";
            this.lblUpdateProductInfo.Size = new System.Drawing.Size(202, 25);
            this.lblUpdateProductInfo.TabIndex = 7;
            this.lblUpdateProductInfo.Text = "Update Product Info";
            // 
            // frmAddEditProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 426);
            this.Controls.Add(this.lblUpdateProductInfo);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAddNewProduct);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrAddEditProductInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditProductInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditProductInfo";
            this.Load += new System.EventHandler(this.frmAddEditProductInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControlLib_SMH_.ctrAddEditProductInfo ctrAddEditProductInfo1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAddNewProduct;
        private My_Custom_control_Library.CustomControl2 btnSave;
        private My_Custom_control_Library.CustomControl2 btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblUpdateProductInfo;
    }
}