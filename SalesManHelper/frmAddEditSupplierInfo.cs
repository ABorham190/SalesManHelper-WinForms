using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLayer;

namespace SalesManHelper
{
    public partial class frmAddEditSupplierInfo : Form
    {
        clsSupplier _Supplier=new clsSupplier();
        int _supplierID;
        string _WhatToDo;
        
        enum enMode { Update ,AddNew}
        enMode _Mode;
        public frmAddEditSupplierInfo()
        {
            InitializeComponent();
            _Mode=enMode.AddNew;
           
            
        }
        public frmAddEditSupplierInfo(int SupplierID)
        {
            InitializeComponent();

            _supplierID=SupplierID;
            _Mode = enMode.Update;
        }

        private void _LoadHeaderLabel()
        {
            lblAddNewSupplier.Visible=_Mode==enMode.AddNew;
            lblUpdateSupplierInfo.Visible=_Mode==enMode.Update;
        }
        private bool _LoadObjectInfoToControls()
        {
            if ((_Supplier = clsSupplier.FindSupplier(this._supplierID)) != null)
            {
                lblAupplierID.Text = _Supplier.SupplierID.ToString();
                tbxCoName.Text = _Supplier.CompanyName;
                tbxOwner.Text = _Supplier.Name;
                tbxTaxID.Text = _Supplier.TaxIDCard;
                tbxCR.Text = _Supplier.CommeercialRegister;
                tbxAddress.Text = _Supplier.Address;
                tbxPhone.Text = _Supplier.Phone;
                tbxEmail.Text = _Supplier.Email;
                return true;

            }
            else
            {
                return false;
            }
        }

        private void frmAddEditSupplierInfo_Load(object sender, EventArgs e)
        {
            _LoadHeaderLabel();
            if(_Mode==enMode.AddNew)
            {
                this._WhatToDo = "Add";
                return;
            }
            if (!_LoadObjectInfoToControls())
            {
                MessageBox.Show("Error In Loading Supplier Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            this._WhatToDo = "Update";


        }
        private void _CheckValidity(object sender,CancelEventArgs e)
        {
            My_Custom_control_Library.MyTextBox2 Temp = (My_Custom_control_Library.MyTextBox2)sender;
            if (!Temp.IsValid())
            {

                errorProvider1.SetError(Temp, "Required field");
                Temp.Focus();
                

            }
            else
            {
                errorProvider1.SetError(Temp, "");
            }
        }
        private void _LoadInfoToObject()
        {
            _Supplier.CompanyName= tbxCoName.Text;
            _Supplier.Name=tbxOwner.Text;
            _Supplier.TaxIDCard = tbxTaxID.Text;
            _Supplier.CommeercialRegister = tbxCR.Text;
            _Supplier.Address = tbxAddress.Text;
            _Supplier.Email = tbxEmail.Text;
            _Supplier.Phone= tbxPhone.Text;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("There Are Required Empty Field", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return
                    ;
            }


            if ((MessageBox.Show($"Are You Sure You Want to {_WhatToDo} This Supplier ?", "Confirmation",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                _LoadInfoToObject();
                if (_Supplier.Save())
                {
                    MessageBox.Show("Saved Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblAupplierID.Text =_Supplier.SupplierID.ToString();
                    btnSave.Enabled = false;
                    return;
                }
                else
                {
                    MessageBox.Show("Not Saved Successfully :-(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Cancelled Operation :-(", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
