using BussinesLayer;
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
    public partial class frmAddNewCollection : Form
    {
        clsCustomer _Customer = new clsCustomer();
        clsCollection _Collection = new clsCollection();
        Decimal _Amount;
        clsCheque _Cheque = new clsCheque();
        public frmAddNewCollection()
        {
            InitializeComponent();
        }
        private void _LoadCustomersToComboBox()
        {

            List<string> CustomersNames = clsCustomer.GetAllCustomersNames();
            cbxCustomers.DataSource = CustomersNames;
            cbxCustomers.SelectedItem = null;
           
        }
        private void _LoadPaymentMethod()
        {
            Dictionary<int,string>PayMethods=new Dictionary<int,string>();
            PayMethods = clsPaymentMethods.GetPaymentMethods();

            foreach(var item in PayMethods)
            {
                cbxCollectionType.Items.Add(item.Value);
            }
            cbxCollectionType.SelectedIndex = 0;
        }
        private void _LoadBanksListToComboBox()
        {
            List<string> BanksNamesList = clsBank.GetAllBanksNames();
            if(BanksNamesList != null)
            {
                cbxBanksList.DataSource = BanksNamesList;
            }
            
        }
        private void frmAddNewCollection_Load(object sender, EventArgs e)
        {
            _LoadCustomersToComboBox();
            _LoadPaymentMethod();
            _LoadBanksListToComboBox();
        }

        private void cbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxCustomers.Text)) 
            {


                _Customer = clsCustomer.FindCustomer(cbxCustomers.SelectedItem.ToString().Trim());
                lblDebit.Text = _Customer.Debit.ToString();


            }
        }

        private void _LoadDataFromControlsToCollectionObject()
        {
            _Collection.CustomerID=_Customer.ID;
            if (!string.IsNullOrEmpty(tbxAmount.Text))
            {
                _Amount = Convert.ToDecimal(tbxAmount.Text);
                _Collection.Amount = _Amount;

            }
            else
            {
                _Amount = Convert.ToDecimal(tbxChequeValue.Text);
                _Collection.Amount = _Amount;
            }

            byte PaymentMethod = Convert.ToByte(cbxCollectionType.SelectedIndex);
            PaymentMethod += 1;
            _Collection.CollectionType =PaymentMethod;
        }
        private void _LoadChequeInfoToObject()
        {
            _Cheque.CollectionID=_Collection.CollectionID;
            _Cheque.Number=tbxChequeNumber.Text;
            _Cheque.Value = Convert.ToDecimal(tbxChequeValue.Text);
            _Cheque.DueDate = dtpChequeDueDate.Value;

            
            
            int BankID = (cbxBanksList.SelectedIndex + 1);
            
            _Cheque.BankNameID = (byte)BankID;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _LoadDataFromControlsToCollectionObject();
            if (clsCollection.IsPaymentMoreThanDebit(_Amount, _Customer.Debit))
            {
                if ((MessageBox.Show("WARNING , Payment is More than Customer Debit !!," +
                    "Are You Sure You Want to Perform This Collection?", "WARNING",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) != DialogResult.Yes)
                {
                    return;
                }
            }
            
            if (_Collection.Save())
            {
                if (cbxCollectionType.SelectedIndex==1)
                {
                    _LoadChequeInfoToObject();

                    if (!_Cheque.Save())
                    {
                        MessageBox.Show("Error In Saving Cheque Info", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    lblChequeID.Text = _Cheque.ID.ToString();
                    lblCollectionID2.Text = _Cheque.CollectionID.ToString();

                }

                lblCollectionID.Text = _Collection.CollectionID.ToString();
                MessageBox.Show("Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Not Saved Successfully", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void cbxCollectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            (gbxChequeInfo.Enabled) = (cbxCollectionType.SelectedIndex == 1);
            
        }
        
    }
}
