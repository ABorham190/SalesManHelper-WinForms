using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinesLayer
{
    public class clsCustomer
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public byte BusinessType { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public Decimal? CreditLimit { get; set; }
        public decimal? Debit { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime AdditionDate { get; set; }




        enum enMode { AddNew, Update }
        enMode _Mode = enMode.AddNew;

        public clsCustomer() { }
        private clsCustomer(int? iD, string name, byte businessType, string phone, string address, string email, decimal? creditLimit, decimal? debit, bool isDeleted, DateTime additionDate)
        {
            ID = iD;
            Name = name;
            BusinessType = businessType;
            Phone = phone;
            Address = address;
            Email = email;
            CreditLimit = creditLimit;
            Debit = debit;
            IsDeleted = isDeleted;
            AdditionDate = additionDate;
            _Mode = enMode.Update;
        }

        public static DataTable GetAllCustomers()
        {
            return CustomersDataLayer.GetAllCustomersInSystem();
        }
        private bool _IsCustomerExists()
        {
            return CustomersDataLayer.IsCustomerNameExists(this.Name);
        }

        public static clsCustomer FindCustomer(int? CustomerID)
        {
            string Name = "", Phone = "", Email = "", Address = "";
            byte BusinessType = 0;
            Decimal? CreditLimit = null;
            Decimal? Debit = 0;
            DateTime AdditionDate = DateTime.MinValue;
            bool IsDeleted = false;

            if (CustomersDataLayer.FindCustomerByCustomerID(CustomerID, ref Name, ref BusinessType,
                ref Phone, ref Email, ref Address, ref CreditLimit, ref Debit, ref AdditionDate, ref IsDeleted))
            {
                return new clsCustomer(CustomerID, Name, BusinessType, Phone, Address, Email, CreditLimit,
                    Debit, IsDeleted, AdditionDate);
            }
            else
            {
                return null;
            }


        }
        public static clsCustomer FindCustomer(string CustomerName)
        {
            int? CustomerID = null;
            string Phone = "", Email = "", Address = "";
            byte BusinessType = 0;
            Decimal? CreditLimit = null;
            Decimal Debit = 0;
            DateTime AdditionDate = DateTime.MinValue;
            bool IsDeleted = false;

            if (CustomersDataLayer.FindCustomerByCustomerName(ref CustomerID, CustomerName, ref BusinessType,
                ref Phone, ref Email, ref Address, ref CreditLimit, ref Debit, ref AdditionDate, ref IsDeleted))
            {
                return new clsCustomer(CustomerID, CustomerName, BusinessType, Phone, Address, Email, CreditLimit,
                    Debit, IsDeleted, AdditionDate);
            }
            else
            {
                return null;
            }

        }
        private bool _IsRequiredFieldEmpty()
        {
            if (string.IsNullOrEmpty(this.Name) || string.IsNullOrEmpty(this.Address)
                || string.IsNullOrEmpty(this.Phone))
            {
                return true;
            }
            return false;
        }
        private bool _AddNew()
        {
            if (_IsRequiredFieldEmpty()||_IsCustomerExists())
            {
                return false;
            }
            this.ID = CustomersDataLayer.AddNewCustomer(this.Name,this.BusinessType ,this.Phone, this.Email, this.Address,
                this.CreditLimit);
            return this.ID.HasValue;
        }
        private bool _Update()
        {
            if (_IsRequiredFieldEmpty())
            {
                return false;
            }
            return CustomersDataLayer.UpdateCustomerInfo(this.ID, this.Name, this.BusinessType, this.Phone,
                this.Email, this.Address, this.CreditLimit);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (this._AddNew())
                    {
                        this._Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    
                case enMode.Update:
                    if (this._Update())
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

        public static bool DeleteCustomer(int CustomerID)
        {
            return CustomersDataLayer.DeleteCustomerSoft(CustomerID);
        }

        public static int? GetCustomerIDUsingCustomerName(string CustomerName)
        {

            return CustomersDataLayer.GetCustomerIDUsingCustomerName(CustomerName);

        }

        public static List<string> GetAllCustomersNames()
        {
            return CustomersDataLayer.GetAllCustomersNames();
        }



    }
}
