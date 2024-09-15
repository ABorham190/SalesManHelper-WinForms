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
    public partial class frmCustomersList : Form
    {
        public frmCustomersList()
        {
            InitializeComponent();
        }

        private void _LoadCustomersToDataGridView()
        {
            DataTable dt = new DataTable();
            dt = clsCustomer.GetAllCustomers();
            string[] Columns = {"CustomerID","Name","BusinessType","Phone","Email","Address","CreditLimit","Debit" };
            DataTable TableContainRequiredData = dt.DefaultView.ToTable(false,Columns);
            dgvCustomersList.DataSource = TableContainRequiredData;

            Decimal Counter = 0; 
            foreach(DataRow Row in TableContainRequiredData.Rows)
            {
                Counter +=(Decimal) Row["Debit"];
            }

            lblTotalDebit.Text = Counter.ToString();
        }

        private void frmCustomersList_Load(object sender, EventArgs e)
        {
            _LoadCustomersToDataGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
