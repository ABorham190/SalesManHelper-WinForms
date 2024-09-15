using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class clsSalesInvoice
    {
        public int? SalesInvoiceID {  get; set; }
        public int? CustomerID { get; set; }
        public DateTime? InvoiceDate {  get; set; }
        public Decimal? TotalValue { get; set; }
        public byte? AdditionalDiscount {  get; set; }
        public bool? IsCash { get; set; }
        public Decimal? AmountPaid { get; set; }
       
        public bool? IsDeleted {  get; set; }
        public DateTime? DueDate { get; set; }

        public byte? CollectionTypeID { get; set; }
        public DateTime?DeleteDate { get; set; }

        public clsCustomer Customer { get; set; }


        

        enum enMode { AddNew,Update}
        enMode _Mode=enMode.AddNew;
        public clsSalesInvoice()
        {
            
        }
        private clsSalesInvoice(int? salesInvoiceID, int? customerID, DateTime? invoiceDate,
            decimal? totalValue, byte? additionalDiscount, bool? isCash, decimal? amountPaid,
            bool? isDeleted, DateTime? dueDate,  DateTime? deleteDate)
        {
            SalesInvoiceID = salesInvoiceID;
            CustomerID = customerID;
            InvoiceDate = invoiceDate;
            TotalValue = totalValue;
            AdditionalDiscount = additionalDiscount;
            IsCash = isCash;
            AmountPaid = amountPaid;
            IsDeleted = isDeleted;
            DueDate = dueDate;
            
            DeleteDate = deleteDate;
            _Mode = enMode.Update;

            Customer = clsCustomer.FindCustomer(this.CustomerID);
        }

        public static clsSalesInvoice Find(int?SalesInvoiceID)
        {
            //there is no collection type because it is related to collection object

            int? customerid=null;
            Decimal? totalvalue=null, amountpaid=null;
            DateTime? invoicedate = null, duedate=null, deletedate=null;
            byte? additionaldiscount=null;
            bool? iscash=null, isdeleted = null;

            if(SalesInvoicesDataLayer.GetSalesInvoiceDetailsByID(SalesInvoiceID,ref customerid,ref invoicedate,
               ref totalvalue, ref additionaldiscount,ref iscash,ref amountpaid,ref isdeleted,ref duedate,ref deletedate))
            {
                return new clsSalesInvoice(SalesInvoiceID, customerid, invoicedate, totalvalue, additionaldiscount,
                    iscash, amountpaid, isdeleted, duedate,  deletedate);
            }
            else
            {
                return null;
            }


        }
        private bool _AddNewSalesInvoice()
        {
            this.SalesInvoiceID = SalesInvoicesDataLayer.AddNewSalesInvoice(this.CustomerID, this.InvoiceDate, this.TotalValue,
                this.AdditionalDiscount, this.IsCash,this.DueDate, this.AmountPaid,this.CollectionTypeID);

            return this.SalesInvoiceID > 0;
        }

        //detect add new or update acc to _Mode 
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (this._AddNewSalesInvoice())
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

        public static bool IsSalesInvoiceExists(int? SalesInvoiceID)
        {
            //Check if Sales Invoice found and not DELETED or not
            //Return false if Invoice is deleted
           

            return SalesInvoicesDataLayer.IsSalesInvoiceExists(SalesInvoiceID);

        }

        public static bool Delete(int?SalesInvoiceID)
        {
            //Check if Sales Invoice found and not DELETED or not
            //Return false if Invoice is deleted

            if (!clsSalesInvoice.IsSalesInvoiceExists(SalesInvoiceID))
            {
                return false;
            }
            
            return SalesInvoicesDataLayer.DeleteSalesInvoiceWithDependencies(SalesInvoiceID);
        }

        //public static DataTable GetAllSalesInvoices()
        //{
        //    return SalesInvoicesDataLayer.GetAllSalesInvoices();
        //}


        public static List<Tuple<int,string,DateTime,Decimal,DateTime,byte>> GetAllSalesInvoices()
        {
            return SalesInvoicesDataLayer.GetAllSalesInvoices();
        }
    }
}
