namespace SalesManHelper
{
    partial class Form1
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
            this.customControl24 = new My_Custom_control_Library.CustomControl2();
            this.customControl21 = new My_Custom_control_Library.CustomControl2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customControl24
            // 
            this.customControl24.ButtonText = My_Custom_control_Library.CustomControl2.enButtonText.Save;
            this.customControl24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customControl24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customControl24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customControl24.ImageIndex = 0;
            this.customControl24.Location = new System.Drawing.Point(64, 306);
            this.customControl24.Name = "customControl24";
            this.customControl24.Size = new System.Drawing.Size(75, 34);
            this.customControl24.TabIndex = 4;
            this.customControl24.Text = "customControl24";
            this.customControl24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customControl24.UseVisualStyleBackColor = true;
            this.customControl24.Click += new System.EventHandler(this.customControl24_Click);
            // 
            // customControl21
            // 
            this.customControl21.ButtonText = My_Custom_control_Library.CustomControl2.enButtonText.Save;
            this.customControl21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customControl21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customControl21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customControl21.Location = new System.Drawing.Point(124, 52);
            this.customControl21.Name = "customControl21";
            this.customControl21.Size = new System.Drawing.Size(90, 34);
            this.customControl21.TabIndex = 5;
            this.customControl21.Text = "Delete";
            this.customControl21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customControl21.UseVisualStyleBackColor = true;
            this.customControl21.Click += new System.EventHandler(this.customControl21_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.customControl21);
            this.Controls.Add(this.customControl24);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private My_Custom_control_Library.CustomControl2 customControl24;
        private My_Custom_control_Library.CustomControl2 customControl21;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

