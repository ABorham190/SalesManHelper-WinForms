using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Collections;
using System.Data;
namespace BussinesLayer
{
    public class clsSalesItem
    {
        public int? SalesItemID {  get; set; }
        public int? ProductID { get; set; }
        public int? SalesInvoiceID { get; set; }
        public int? NumberOfUnits { get; set; }
        public Decimal? UnitPrice { get; set; }
        public Decimal? TotalAmount { get; set; }

        enum enMode { AddNew,Update}
        enMode _Mode= enMode.AddNew;
       
       
        public clsSalesItem(int?ProductID,int?NumberOfUnits,int?SalesInvoiceID,Decimal?UnitPrice,Decimal?TotalAmount)
        {
           
            this.SalesInvoiceID =SalesInvoiceID;
            this.ProductID=ProductID;
            this.NumberOfUnits=NumberOfUnits;
            this.UnitPrice=UnitPrice;
            this.TotalAmount=TotalAmount;
            
        }
        public static void AddSalesItemToList(List<clsSalesItem>SalesItemsList, int?productid,
            int?numberofunits,int?salesinvoiceid,Decimal?unitprice,Decimal?totalamount)
        {
            SalesItemsList.Add(new clsSalesItem(productid, numberofunits, salesinvoiceid, unitprice, totalamount));

        }
        public static void EditSaleseInvoiceIDInSalesItem(List<clsSalesItem> SalesItemsList, int? SalesInvoiceID)
        {
            foreach(clsSalesItem item in SalesItemsList)
            {
                item.SalesInvoiceID = SalesInvoiceID;
            }
        }
        public static void EditSalesInvoiceIDInSalesItems(List<clsSalesItem> SalesItemsList,int?salesinvoiceid)
        {
            foreach(clsSalesItem item in SalesItemsList)
            {
                item.SalesInvoiceID=salesinvoiceid;
            }
        }
        private bool _AddNewSalesItem()
        {
            this.SalesItemID = SalesItemsDataLayer.AddNewSalesItem(this.ProductID, this.SalesInvoiceID, this.NumberOfUnits,
                this.UnitPrice);

            return this.SalesItemID > 0;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if(this._AddNewSalesItem())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }

            return false;
        }

        public static DataTable GetSalesItemsInSalesInvoice(int? SalesInvoiceID)
        {
            return SalesItemsDataLayer.GetAllSalesItemsInSalesInvoice(SalesInvoiceID);
        }

        public static bool DeleteSalesItem(int?SalesItemID,Decimal?TotalAmount,int?SalesInvoiceID,
            int? CustomerID)
        {
            return SalesItemsDataLayer.DeleteSalesItemWithDependencies(SalesItemID, TotalAmount, SalesInvoiceID,
                CustomerID);
        }

    }
}
