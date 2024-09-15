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
    public partial class frmOutStandingCheques : Form
    {
        List<Tuple<int, string, Decimal, string, DateTime, string>> OutStandingChequesList =
            clsCheque.GetAllOutStandingChequesFromDataLayer();
        List<Tuple<int, string, Decimal, string, DateTime, string>> DateFilteredOutStandingChequesList =
            new List<Tuple<int, string, Decimal, string, DateTime, string>>();



    public frmOutStandingCheques()
        {
            InitializeComponent();
        }

        private void _LoadOutStandingChequesList()
        {
            dgvOutStandingCheques.DataSource = OutStandingChequesList;
            dgvOutStandingCheques.Columns[0].HeaderText = "Cheque ID";
            dgvOutStandingCheques.Columns[1].HeaderText = "Cheque Num";
            dgvOutStandingCheques.Columns[2].HeaderText = "Chq. Value";
            dgvOutStandingCheques.Columns[3].HeaderText = "Cust. Name";
            dgvOutStandingCheques.Columns[4].HeaderText = "Due Date";
            dgvOutStandingCheques.Columns[5].HeaderText = "Bank Name";






            if (dgvOutStandingCheques.RowCount > 0 )
            {
                dgvOutStandingCheques.Columns[3].Width = 200;
                dgvOutStandingCheques.Columns[5].Width = 120;

                lblRecords.Text=OutStandingChequesList.Count.ToString();
                lblTotalValue.Text = OutStandingChequesList.Sum(C => C.Item3).ToString();

            }


        }

        private void frmOutStandingCheques_Load(object sender, EventArgs e)
        {
            _LoadOutStandingChequesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime DateFrom = dtpFrom.Value.AddDays(-1);
            DateTime DateTo=dtpTo.Value;

            DateFilteredOutStandingChequesList = OutStandingChequesList.Where(C => C.Item5 >= DateFrom &&
            C.Item5 <= DateTo).ToList();
            dgvOutStandingCheques.DataSource= DateFilteredOutStandingChequesList;
            lblRecords.Text=DateFilteredOutStandingChequesList.Count().ToString();
            lblTotalValue.Text = DateFilteredOutStandingChequesList.Sum(C => C.Item3).ToString();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            _LoadOutStandingChequesList();
            DateFilteredOutStandingChequesList.Clear();
        }

        private void tbxCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (DateFilteredOutStandingChequesList.Count == 0)
            {
                var FilteredResult = OutStandingChequesList.Where(C => C.Item4.StartsWith(tbxCustomerName.Text)).ToList();
                dgvOutStandingCheques.DataSource = FilteredResult;

                lblRecords.Text = FilteredResult.Count().ToString();
                lblTotalValue.Text = FilteredResult.Sum(C => C.Item3).ToString();

            }
            else
            {
                var FilteredResult = DateFilteredOutStandingChequesList.Where(C => C.Item4.StartsWith(tbxCustomerName.Text)).ToList();
                dgvOutStandingCheques.DataSource = FilteredResult;

                lblRecords.Text = FilteredResult.Count().ToString();
                lblTotalValue.Text = FilteredResult.Sum(C => C.Item3).ToString();
            }
        }
    }
}
