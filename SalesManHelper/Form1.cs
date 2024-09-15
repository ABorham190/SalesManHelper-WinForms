using BussinesLayer;
using SalesManHelper.Properties;
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
    public partial class Form1 : Form
    {
        int? _SalesInvoiceID;
        public Form1(int? SalesInvoiceID)
        {
            InitializeComponent();
            _SalesInvoiceID = SalesInvoiceID;
        }

        private void customControl24_Click(object sender, EventArgs e)
        {
            MessageBox.Show(clsCustomer.GetCustomerIDUsingCustomerName("Ahmad Borham").ToString(), "CustomerID");
        }

        private void customControl21_Click(object sender, EventArgs e)
        {
            clsSalesInvoice SalesInvoice;
            if ((SalesInvoice = clsSalesInvoice.Find(this._SalesInvoiceID)) == null)
            {
                MessageBox.Show("No Sales Invoice with this ID");
            }
            else
            {
                MessageBox.Show($"ID = {SalesInvoice.SalesInvoiceID} , Cust.Name : {SalesInvoice.Customer.Name} " +
                    $", Total Value : {SalesInvoice.TotalValue} , Additional discount : {SalesInvoice.AdditionalDiscount} ," +
                    $" IsCash : {SalesInvoice.IsCash} , Amount Paid : {SalesInvoice.AmountPaid} , " +
                    $"Is Deleted : {SalesInvoice.IsDeleted} , DueDate {SalesInvoice.DueDate.ToString()} " +
                    $"Delete Date {SalesInvoice.DeleteDate}", "Info");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt=new DataTable();
            dt=clsSalesItem.GetSalesItemsInSalesInvoice(this._SalesInvoiceID);
            dataGridView1.DataSource= dt;
        }
    }
}
