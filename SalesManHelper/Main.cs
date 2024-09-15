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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnAddSalesInvoice_Click(object sender, EventArgs e)
        {
            frmAddEditSalesInvoice frm=new frmAddEditSalesInvoice();
            frm.ShowDialog();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer frm=new frmAddEditCustomer();
            frm.ShowDialog();
        }

        private void btnEditSalesInvoice_Click(object sender, EventArgs e)
        {
            frmAddEditSalesInvoice frm= new frmAddEditSalesInvoice(55);
            frm.ShowDialog();
        }

        private void btnAddNewCollection_Click(object sender, EventArgs e)
        {
            frmAddNewCollection frm=new frmAddNewCollection();
            frm.ShowDialog();
        }

        private void btnCustomersList_Click(object sender, EventArgs e)
        {
            frmCustomersList frm=new frmCustomersList();
            frm.ShowDialog();
        }

        private void btnSalesInvoices_Click(object sender, EventArgs e)
        {
            frmSalesInvoices frm=new frmSalesInvoices();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOutStandingCheques_Click(object sender, EventArgs e)
        {
            frmOutStandingCheques frm=new frmOutStandingCheques();
            frm.ShowDialog();
        }

        private void btnTotalSalesAndCollection_Click(object sender, EventArgs e)
        {
            frmSalesAndCollectionInAPeriod frm = new frmSalesAndCollectionInAPeriod();
            frm.ShowDialog();
        }
    }
}
