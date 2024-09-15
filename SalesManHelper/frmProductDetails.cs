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
    public partial class frmProductDetails : Form
    {
        int? _ProductID;
        string _ProductName;

        enum enFindBy { ProductID, ProductName };
        enFindBy _FindBy;
        public frmProductDetails(int productID)
        {
            InitializeComponent();
            _ProductID = productID;
            _FindBy=enFindBy.ProductID;
        }
        public frmProductDetails(string ProductName)
        {
            InitializeComponent();
            _ProductName = ProductName;
            _FindBy =enFindBy.ProductName;
        }

        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            switch (_FindBy)
            {
                case enFindBy.ProductID:
                    if (!ctrlShowProductDetails1.LoadProductInfo(_ProductID))
                    {
                        this.Close();
                    }
                    break;
                case enFindBy.ProductName:
                    if(!ctrlShowProductDetails1.LoadProductInfo(_ProductName))
                    {
                        this.Close();
                    }
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llabelEditProductInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditProductInfo frm=new frmAddEditProductInfo(_ProductID);
            frm.ShowDialog();
            ctrlShowProductDetails1.LoadProductInfo(_ProductID);
        }

        private void ctrlShowProductDetails1_OnShowProductDetails(object sender, MyControlLib_SMH_.ctrlShowProductDetails.clsProductEventArgs e)
        {
            this._ProductID = e.ProductID;
        }
    }
}
