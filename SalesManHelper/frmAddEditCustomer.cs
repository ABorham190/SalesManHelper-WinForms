using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLayer;

namespace SalesManHelper
{
    public partial class frmAddEditCustomer : Form
    {
        clsCustomer _Customer=new clsCustomer();
        enum enMode { UpdateMode,AddNewMode}
        enMode _Mode;
        int? _CustomerID;
        public frmAddEditCustomer()
        {
            InitializeComponent();
            _Mode = enMode.AddNewMode;
        }
        public frmAddEditCustomer(int? customerID)
        {

            InitializeComponent();
            _Mode = enMode.UpdateMode;
            _CustomerID = customerID;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _SetHeaderLabelVisibility()
        {
            lblAddNewCustomer.Visible=(_Mode == enMode.AddNewMode);
            lblUpdateCustomerInfo.Visible=(_Mode == enMode.UpdateMode);
        }
       
        private void _LoadObjectDataToControls()
        {
            lblCustomerID.Text = _Customer.ID.ToString();
            tbxName.Text=_Customer.Name;
            tbxPhone.Text=_Customer.Phone;
            tbxEmail.Text=_Customer.Email;
            tbxCreditLimit.Text = _Customer.CreditLimit.ToString();
            tbxAddress.Text = _Customer.Address;
            cbxBusinessType.SelectedIndex = _Customer.BusinessType;
            
        }
        private bool _FindObjectAndLoadDataToControls()
        {
            if ((_Customer = clsCustomer.FindCustomer(this._CustomerID)) != null)
            {
                _LoadObjectDataToControls();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void frmAddEditCustomer_Load(object sender, EventArgs e)
        {
            _SetHeaderLabelVisibility();
            cbxBusinessType.SelectedItem = "Doctor";

            if (_Mode == enMode.AddNewMode)
            {
                
                return;
            }

            if (!_FindObjectAndLoadDataToControls())
            {
                MessageBox.Show("Error In Loading Object Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void _CheckValidity(object sender,CancelEventArgs e)
        {
            My_Custom_control_Library.MyTextBox2 Temp = (My_Custom_control_Library.MyTextBox2)sender;

            if (!Temp.IsValid())
            {
                errorProvider1.SetError(Temp, "Fill The field with the Correct data");
                Temp.Focus();
                

            }
            else
            {
                errorProvider1.SetError(Temp, "");
            }
        }

        private void _LoadDataToObject()
        {
            _Customer.Name=tbxName.Text;
            _Customer.Phone=tbxPhone.Text;
            _Customer.Email=tbxEmail.Text;
            _Customer.Address=tbxAddress.Text;
            if (!string.IsNullOrEmpty(tbxCreditLimit.Text))
                _Customer.CreditLimit = Convert.ToDecimal(tbxCreditLimit.Text);
            else _Customer.CreditLimit = 0;
            _Customer.BusinessType = Convert.ToByte(cbxBusinessType.SelectedIndex);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show($"Are You Sure You Want to Save Changes ?", "Confirmation",
                 MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) == DialogResult.Yes)
            {

                _LoadDataToObject();
                if (_Customer.Save())
                {
                    MessageBox.Show("Saved Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblCustomerID.Text = _Customer.ID.ToString();
                    btnSave.Enabled = false;
                    gbxCustomer.Enabled = false;
                    return;
                }
                else
                {
                    MessageBox.Show("Not Saved Successfully :-(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Cancelled Operation :-(", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
    }
}
