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
    public partial class ProductsList : Form
    {
        static private DataTable _TableContainlAllProductDetails = clsProduct.GetAllProducts();
        private DataTable _ProductTable = _TableContainlAllProductDetails.DefaultView.ToTable(false,"ProductId",
            "ProductName","Brand","Company","Prod_Type","ActiveIngrediant","Concentration","Notes");

        public ProductsList()
        {
            InitializeComponent();
        }
        private void _RefreshProductList()
        {
              _TableContainlAllProductDetails = clsProduct.GetAllProducts();
              _ProductTable = _TableContainlAllProductDetails.DefaultView.ToTable();

            if (_ProductTable != null)
            {
                dgvProductList.DataSource = _ProductTable;
                lblRecords.Text=dgvProductList.RowCount.ToString();

                dgvProductList.Columns[6].HeaderText = "Conc";

                dgvProductList.Columns[0].Width = 60;
                dgvProductList.Columns[2].Width = 80;
                dgvProductList.Columns[3].Width = 120;
                dgvProductList.Columns[4].Width = 60;
                dgvProductList.Columns[5].Width = 110;
                dgvProductList.Columns[6].Width = 50;






            }

        }
    
    

        private void ProductsList_Load(object sender, EventArgs e)
        {
            cbxFilterBy.SelectedIndex = 0;
            _RefreshProductList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _FilterProducts()
        {
           
            string FilterColumnName = "";

            switch (cbxFilterBy.Text)
            {
                case "Product Name":
                    FilterColumnName = "ProductName";
                    break;
                case "Brand":
                    FilterColumnName = "Brand";
                    break;
                case "Company":
                    FilterColumnName = "Company";
                    break;
                default:
                    FilterColumnName = "None";
                    break;
            }


            if (cbxFilterBy.Text.Trim() == "" || FilterColumnName == "None")
            {

                _ProductTable.DefaultView.RowFilter = "";
                lblRecords.Text = dgvProductList.RowCount.ToString();
                return;
            }

            _ProductTable.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", FilterColumnName, txtFilterValue.Text);
            dgvProductList.DataSource = _ProductTable.DefaultView;
            lblRecords.Text=dgvProductList.Rows.Count.ToString();

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterProducts();
        }

        private void cbxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbxFilterBy.SelectedIndex != 0);
            if( cbxFilterBy.SelectedIndex != 0)
            {
                txtFilterValue.Focus();
            }
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditProductInfo frmAdd = new frmAddEditProductInfo();
            frmAdd.ShowDialog();
            _RefreshProductList();

        }

        private void showProductDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductDetails frm = new frmProductDetails((int)dgvProductList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditProductInfo frm= new frmAddEditProductInfo((int)dgvProductList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshProductList();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAddEditProductInfo frm = new frmAddEditProductInfo();
            frm.ShowDialog();
            _RefreshProductList();
        }
    }
}
