using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManHelper
{
    public partial class frmAddEditProductInfo : Form
    {
        enum enMode {AddNew,Update }
        enMode _Mode;
        int? _ProductID;
        string _WhatToDo;
        public frmAddEditProductInfo()
        {

            InitializeComponent();
            _Mode = enMode.AddNew;

        }
        public frmAddEditProductInfo(int? ProductID)
        {

            InitializeComponent();
            _ProductID = ProductID;
            _Mode = enMode.Update;

        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    ctrAddEditProductInfo1.AddNewProduct(_WhatToDo);
                    break;
                case enMode.Update:
                    ctrAddEditProductInfo1.UpdateProduct(_ProductID, _WhatToDo);
                    btnSave.Enabled = false;
                    break;
                default:
                    ctrAddEditProductInfo1.AddNewProduct(_WhatToDo);
                    break;
            }




        }

        private void ctrAddEditProductInfo1_OnAddNewProduct(object sender, MyControlLib_SMH_.ctrAddEditProductInfo.ProductArgs e)
        {
            lblProductID.Text = e.ProductID.ToString();
            btnSave.Enabled = false;
        }

        private void frmAddEditProductInfo_Load(object sender, EventArgs e)
        {
            if(_Mode == enMode.Update)
            {
                if (!ctrAddEditProductInfo1.LoadObjectInfoToControls(_ProductID))
                {
                    MessageBox.Show("Can not find Product with ID = " + _ProductID, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); return ;
                }
                lblUpdateProductInfo.Visible = true;
                lblAddNewProduct.Visible = false;
                lblProductID.Text=_ProductID.ToString();
                _WhatToDo = "Update";
                return;
            }
            _WhatToDo = "Add";
            lblAddNewProduct.Visible = true;
            lblUpdateProductInfo.Visible = false;
        }
    }
}
