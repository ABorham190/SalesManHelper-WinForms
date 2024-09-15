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
    public partial class frmGetAllCustomers : Form
    {
        static DataTable TableContainAllCustomersData = clsCustomer.GetAllCustomers();
        DataTable _CustomizedData = TableContainAllCustomersData.DefaultView.ToTable(false,"CustomerID",
            "Name","Phone","Email","Address","CreditLimit");
        public frmGetAllCustomers()
        {
            InitializeComponent();
        }

        private void frmGetAllCustomers_Load(object sender, EventArgs e)
        {
            dgvCustomersList.DataSource = _CustomizedData;
            if(dgvCustomersList.Rows.Count > 0 )
            {
                dgvCustomersList.Columns[1].Width = 200;
            }
        }
    }
}
