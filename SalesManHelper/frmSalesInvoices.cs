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
    public partial class frmSalesInvoices : Form
    {
        DataTable TableContainAllSalesInvoices=new DataTable();
        List<Tuple<int, string, DateTime, Decimal,DateTime, byte>> SalesInvoices =
            new List<Tuple<int, string, DateTime, Decimal,DateTime, byte>>();
        List<Tuple<int, string, DateTime, Decimal, DateTime, byte>>
            DateFilterResult = new List<Tuple<int, string, DateTime, Decimal, DateTime, byte>>();
        public frmSalesInvoices()
        {
            InitializeComponent();
        }

        private void customControl21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadFormGeneralSettings()
        {
            cbxFilterBy.SelectedIndex = 0;
        }
        private void _LoadSalesInvoices()
        {

            //TableContainAllSalesInvoices = clsSalesInvoice.GetAllSalesInvoices();
            //dgvSalesInvoices.DataSource = TableContainAllSalesInvoices;
            //lblRecords.Text=dgvSalesInvoices.RowCount.ToString();

            SalesInvoices = clsSalesInvoice.GetAllSalesInvoices();
            dgvSalesInvoices.DataSource = null;
            dgvSalesInvoices.DataSource = SalesInvoices; 
            lblRecords.Text=SalesInvoices.Count.ToString();
            lblTotalSales.Text = SalesInvoices.Sum(S => S.Item4).ToString();

            dgvSalesInvoices.Columns[0].HeaderText = "Sales Inv. ID";
            dgvSalesInvoices.Columns[1].HeaderText = "Cust. Name"; 
            dgvSalesInvoices.Columns[2].HeaderText = "Inv. Date";
            dgvSalesInvoices.Columns[3].HeaderText = "Total Value";
            dgvSalesInvoices.Columns[4].HeaderText = "Due Date";
            dgvSalesInvoices.Columns[5].HeaderText = "Addit. DisCount";


            if(dgvSalesInvoices.Rows.Count > 0)
            {
                dgvSalesInvoices.Columns[1].Width = 200;
                dgvSalesInvoices.Columns[0].Width= 50;
            }



            _LoadFormGeneralSettings();

        }

        private void frmSalesInvoices_Load(object sender, EventArgs e)
        {
            _LoadSalesInvoices();
            
        }

        private void editSalesInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditSalesInvoice frm=new frmAddEditSalesInvoice((int)dgvSalesInvoices.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        private void _SettbxFilterBoxVisibility()
        {
            tbxFilterBox.Visible = (cbxFilterBy.SelectedIndex == 2);
        }

        private void SetDTPickersVisibility()
        {

            dtpDateFrom.Visible = (cbxFilterBy.SelectedIndex == 1|| cbxFilterBy.SelectedIndex == 3);
            dtpDateTo.Visible = (cbxFilterBy.SelectedIndex == 1|| cbxFilterBy.SelectedIndex == 3);
            lblFrom.Visible = (cbxFilterBy.SelectedIndex == 1|| cbxFilterBy.SelectedIndex == 3);
            lblTo.Visible = (cbxFilterBy.SelectedIndex == 1 || cbxFilterBy.SelectedIndex == 3);
            btnShow.Visible = (cbxFilterBy.SelectedIndex == 1|| cbxFilterBy.SelectedIndex == 3);

        }
        private void _FilterByDate()
        {
            DateTime DateFrom = dtpDateFrom.Value.AddDays(-1);//Here i distract one day from date 
            //because in filter it starts from the day after the detected date
            DateTime DateTo=dtpDateTo.Value;

            DateFilterResult = SalesInvoices.Where(S => S.Item3>=DateFrom && S.Item3<=DateTo).ToList();

            dgvSalesInvoices.DataSource=DateFilterResult;
            lblRecords.Text=DateFilterResult.Count.ToString();
            lblTotalSales.Text = DateFilterResult.Sum(S => S.Item4).ToString();
        }

        private void _FilterByCustomerName(string Name)
        {
            var FilteredResult = SalesInvoices.Where(S => S.Item2.StartsWith(Name)).ToList();
            dgvSalesInvoices.DataSource= FilteredResult;
            lblRecords.Text = FilteredResult.Count.ToString();
            lblTotalSales.Text = FilteredResult.Sum(S => S.Item4).ToString();
        }
        
        private void _SetTextBoxWithDateVisibility()
        {
            tbxCustName2.Visible = (cbxFilterBy.SelectedItem=="Date & Customer Name");
            lblCustName.Visible= (cbxFilterBy.SelectedItem == "Date & Customer Name");

        }

        private void cbxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDTPickersVisibility();
            _SettbxFilterBoxVisibility();
            _SetTextBoxWithDateVisibility();






            if (cbxFilterBy.SelectedItem == "None")
            {
                _LoadSalesInvoices();
            }


        }

        

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            _FilterByDate();
        }

        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            btnShow.Enabled = (dtpDateFrom.Value <= dtpDateTo.Value);
        }

        private void dtpDateTo_ValueChanged(object sender, EventArgs e)
        {
            btnShow.Enabled = (dtpDateFrom.Value <= dtpDateTo.Value);
        }

        private void tbxFilterBox_TextChanged(object sender, EventArgs e)
        {
            _FilterByCustomerName(tbxFilterBox.Text);

        }
        private void _FilterByCustomerNameWithDate(string Name)
        {

            
            var FilteredResult = DateFilterResult.Where(R => R.Item2.StartsWith(Name)).ToList();
            dgvSalesInvoices.DataSource = FilteredResult;
            lblRecords.Text = FilteredResult.Count.ToString();
            lblTotalSales.Text=FilteredResult.Sum(R=>R.Item4).ToString();
            lblRecords.Text=FilteredResult.Count.ToString();
        }

        private void tbxCustName2_TextChanged(object sender, EventArgs e)
        {
            _FilterByCustomerNameWithDate(tbxCustName2.Text);
        }
    }
}
