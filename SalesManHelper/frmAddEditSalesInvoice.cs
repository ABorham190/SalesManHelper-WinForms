using BussinesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManHelper
{
    public partial class frmAddEditSalesInvoice : Form
    {
        clsProduct _Product;
        Decimal _TotalAmountOfAnItem;
        Decimal _TotalAmountOfInvoice;
        Decimal? _PaidAmount;
        clsSalesInvoice _SalesInvoice = new clsSalesInvoice();
        clsCustomer _Customer;
        int? _CustomerID;
        List<clsSalesItem> _salesItemsList=new List<clsSalesItem>();
        int? _SalesInvoiceID;
        DataTable _dtSalesItems=new DataTable();

        enum enMode { AddNew,Update};
        enMode _Mode=enMode.AddNew;
        public frmAddEditSalesInvoice()
        {
            InitializeComponent();
        }
        public frmAddEditSalesInvoice(int?SalesInvoiceID)
        {
            InitializeComponent();
            this._SalesInvoiceID = SalesInvoiceID;
            _Mode = enMode.Update;
        }
        private void _GetSalesItemsInSalesInvoice()
        {
            _dtSalesItems = clsSalesItem.GetSalesItemsInSalesInvoice(this._SalesInvoiceID);
            dataGridView1.DataSource= _dtSalesItems;
        }

        private void _GetAndLoadSalesInvoiceInfo()
        {
            _SalesInvoice = clsSalesInvoice.Find(this._SalesInvoiceID);
            lblInvoiceID.Text = _SalesInvoice.SalesInvoiceID.ToString();
            lblTotalValue.Text = _SalesInvoice.TotalValue.ToString();
            cbxCustomerNames.SelectedItem = _SalesInvoice.Customer.Name;
            cbxCustomerNames.Enabled=false;

           
        }
        private void _LoadProductsIncbxProducts()
        {

            DataTable dt=clsProduct.GetAllProducts();
            foreach(DataRow dr in dt.Rows)
            {
                cbxProducts.Items.Add(dr["ProductName"].ToString());
            }

        }
        private void _LoadCustomersInComboBox()
        {

            DataTable dt=clsCustomer.GetAllCustomers();
            foreach(DataRow dr in dt.Rows)
            {
                cbxCustomerNames.Items.Add(dr["Name"]);
            }

        }

        private void frmAddEditSalesInvoice_Load(object sender, EventArgs e)
        {
            _LoadProductsIncbxProducts();
            _LoadCustomersInComboBox();
            if (_Mode == enMode.AddNew)
            {
                return;
            }
            if (!clsSalesInvoice.IsSalesInvoiceExists(this._SalesInvoiceID))
            {
                MessageBox.Show("There is no Sales invoic with this ID", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            
            _GetSalesItemsInSalesInvoice();
            _GetAndLoadSalesInvoiceInfo();

        }

        private void _GetProduct()
        {
            _Product = clsProduct.FindProductByProductName(cbxProducts.SelectedItem.ToString());
        }
        public bool _IsRequiredFieldEmpty()
        {
            return (tbxPrice.Text.Trim().Length == 0||tbxNumberOfUnits.Text.Trim().Length==0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_IsRequiredFieldEmpty())
            {
                MessageBox.Show("Empty Field Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _GetProduct();

            int? NumberOfUnits = Convert.ToInt32(tbxNumberOfUnits.Text);

            Decimal? Price=Convert.ToDecimal(tbxPrice.Text);

            clsSalesItem.AddSalesItemToList(_salesItemsList,_Product.ProductID,NumberOfUnits,null,Price,_TotalAmountOfAnItem);
            btnAdd.Enabled = false;
            cbxProducts.ResetText();
            tbxNumberOfUnits.Text = "";
            tbxPrice.Text = "";

            _TotalAmountOfInvoice += _TotalAmountOfAnItem;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource= _salesItemsList;

        }

        private void tbxNumberOfUnits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void _validateTotalAmount()
        {
            if(tbxNumberOfUnits.Text.Trim().Length > 0&&tbxPrice.Text.Trim().Length>0)
            {
                int NumberOfUnits = Convert.ToInt32(tbxNumberOfUnits.Text);
                Decimal Price = Convert.ToDecimal(tbxPrice.Text);

                 _TotalAmountOfAnItem = NumberOfUnits * Price;

                tbxTotalAmount.Text = _TotalAmountOfAnItem.ToString();

            }
        }

        private void tbxNumberOfUnits_Validating(object sender, CancelEventArgs e)
        {
            _validateTotalAmount();
            if (tbxNumberOfUnits.Text.Trim() == "")
            {
                errorProvider1.SetError(tbxNumberOfUnits, "Required field");
                tbxNumberOfUnits.Focus();
            }
            else
            {
                errorProvider1.SetError(tbxNumberOfUnits, "");
            }
        }

        private void tbxPrice_Validating(object sender, CancelEventArgs e)
        {
            _validateTotalAmount();
            if (tbxPrice.Text.Trim() == "")
            {
                errorProvider1.SetError(tbxPrice, "Required field");
                tbxNumberOfUnits.Focus();
            }
            else
            {
                errorProvider1.SetError(tbxPrice, "");
                btnAdd.Enabled = true;
            }
        }

        private void cbxProducts_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbxProducts.Text.Trim()))
            {
                errorProvider1.SetError(cbxProducts, "Required Field");
                cbxProducts.Focus();
            }
            else
            {
                errorProvider1.SetError(cbxProducts, "");
            }
        }
        private int? _GetCustomerID()
        {
            _Customer = clsCustomer.FindCustomer(cbxCustomerNames.SelectedItem.ToString());
            int? CustID = _Customer.ID;
            if (CustID.HasValue)
            {
                return CustID;
            }
            else
            {
                return null;
            }
        }
        private void _PrepareSalesInvoiceObject()
        {
            //_CustomerID = _GetCustomerID();
            

            _SalesInvoice.CustomerID=_Customer.ID;
            _SalesInvoice.InvoiceDate=DateTime.Now;
            _SalesInvoice.TotalValue = _TotalAmountOfInvoice;
            _SalesInvoice.DueDate = DateTime.Now.AddMonths(3);
            if(_PaidAmount.HasValue)
                _SalesInvoice.AmountPaid = _PaidAmount.Value;
            else
                _SalesInvoice.AmountPaid=0;
            _SalesInvoice.IsCash = (_SalesInvoice.AmountPaid==_SalesInvoice.TotalValue);

        }

        private void _EditSalesItems_SalesInvoiceID()
        {
            clsSalesItem.EditSalesInvoiceIDInSalesItems(_salesItemsList, _SalesInvoice.SalesInvoiceID);
        }
        private bool _SaveSalesItems()
        {
            foreach(clsSalesItem item in _salesItemsList)
            {
                if (!item.Save())
                {
                    return false;
                }
            }

            return true;
        }
        private bool _IsDebitPlusInvoiceValueWillExceedCreditLimit()
        {
            return (_Customer.Debit+_TotalAmountOfInvoice)>_Customer.CreditLimit;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_IsDebitPlusInvoiceValueWillExceedCreditLimit())
            {
                if((MessageBox.Show("This Customer Will Exceed CreditLimit After This Invoice ," +
                    "Are You Sure You Want To Perform This Action?","WARNING",MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Hand)) != DialogResult.Yes)
                {
                    return;
                }
            }
            if(_salesItemsList.Count > 0)
            {
                _PrepareSalesInvoiceObject();

                if (_SalesInvoice.Save())
                {
                    _EditSalesItems_SalesInvoiceID();
                    if (_SaveSalesItems())
                    {
                        MessageBox.Show("Invoice Added Successfully", "Done", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                       // _salesItemsList.Clear();
                        this._TotalAmountOfInvoice = 0;
                    }
                    else
                    {
                        MessageBox.Show("Error in saving Sales Items", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Error in Adding Sales invoice", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this._TotalAmountOfInvoice = 0;

                    _salesItemsList.Clear();
                    return;
                }


            }
            else
            {
                MessageBox.Show("There is no Sales Items , Please add sales items firstly to make an invoice",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxPaidAmount_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxPaidAmount.Text))
                _PaidAmount = Convert.ToDecimal(tbxPaidAmount.Text);
            else
                _PaidAmount = 0;
        }

        private void deleteSalesItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridView1.RowCount == 1)
            {
                if ((MessageBox.Show("Are You Sure you want to Delete this invoice?", "Delete Confirm",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) == DialogResult.Yes)

                {
                    if (clsSalesInvoice.Delete(_SalesInvoice.SalesInvoiceID))
                    {
                        MessageBox.Show("Deleted Successfully");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Not Deleted Successfully");
                        return;

                    }
                }

                return;

            }

            if(
            clsSalesItem.DeleteSalesItem((int)dataGridView1.CurrentRow.Cells[0].Value,
                (Decimal)dataGridView1.CurrentRow.Cells[5].Value, _SalesInvoice.SalesInvoiceID, _SalesInvoice.CustomerID))
            {
                MessageBox.Show("Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Not Deleted Successfully");
            }
        }

        private void cbxCustomerNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxCustomerNames.Text))
            {
                _Customer = clsCustomer.FindCustomer(cbxCustomerNames.Text);
                lblCustomerName.Text = cbxCustomerNames.Text;
            }
        }
    }
}
