namespace SalesManHelper
{
    partial class frmCustomersList
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
            this.dgvCustomersList = new System.Windows.Forms.DataGridView();
            this.lblTotalDebit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new My_Custom_control_Library.CustomControl2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomersList
            // 
            this.dgvCustomersList.AllowUserToAddRows = false;
            this.dgvCustomersList.AllowUserToDeleteRows = false;
            this.dgvCustomersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomersList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCustomersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomersList.Location = new System.Drawing.Point(12, 144);
            this.dgvCustomersList.Name = "dgvCustomersList";
            this.dgvCustomersList.ReadOnly = true;
            this.dgvCustomersList.Size = new System.Drawing.Size(776, 246);
            this.dgvCustomersList.TabIndex = 1;
            // 
            // lblTotalDebit
            // 
            this.lblTotalDebit.AutoSize = true;
            this.lblTotalDebit.Location = new System.Drawing.Point(708, 413);
            this.lblTotalDebit.Name = "lblTotalDebit";
            this.lblTotalDebit.Size = new System.Drawing.Size(37, 13);
            this.lblTotalDebit.TabIndex = 2;
            this.lblTotalDebit.Text = "[????]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Debit";
            // 
            // btnClose
            // 
            this.btnClose.ButtonText = My_Custom_control_Library.CustomControl2.enButtonText.Close;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::SalesManHelper.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(355, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCustomersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalDebit);
            this.Controls.Add(this.dgvCustomersList);
            this.Name = "frmCustomersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCustomersList";
            this.Load += new System.EventHandler(this.frmCustomersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomersList;
        private System.Windows.Forms.Label lblTotalDebit;
        private System.Windows.Forms.Label label2;
        private My_Custom_control_Library.CustomControl2 btnClose;
    }
}