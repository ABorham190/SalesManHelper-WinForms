using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace BussinesLayer
{
    public class clsSupplier
    {
        public int SupplierID {  get; set; }
        public string Name {  get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public string Address {  get; set; }
        public string ImagePath {  get; set; }

        public string CompanyName {  get; set; }
        public string TaxIDCard { get; set; }
        public string CommeercialRegister {  get; set; }

        enum enMode { UpdateMode,AddNewMode}
        enMode _Mode = enMode.AddNewMode;
        public clsSupplier()
        {

        }
        clsSupplier(int supplierID, string name, string phone, string email, string address, 
            string imagePath, string companyName, string taxIDCard, string commeercialRegister)
        {
            SupplierID = supplierID;
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            ImagePath = imagePath;
            CompanyName = companyName;
            TaxIDCard = taxIDCard;
            CommeercialRegister = commeercialRegister;
            _Mode = enMode.UpdateMode;
        }

        private bool _IsThereEmptyRequiredFields()
        {
            if (string.IsNullOrEmpty(this.Name) || string.IsNullOrEmpty(this.Phone) || string.IsNullOrEmpty(this.Address)
               || string.IsNullOrEmpty(this.CompanyName))
            {
                return true;
            }
            return false;
        }

        private bool _AddNewSupplier()
        {
            if (_IsThereEmptyRequiredFields())
            {
                return false;
            }
            string Name = null;
            if(SuppliersDataLayer.IsThisCompanyNameExistsInDataBase(this.CompanyName,ref Name))
            {
                return false;
            }

            this.SupplierID = SuppliersDataLayer.AddNewSupplier(this.Name,this.Phone,
                this.Email,this.Address,this.ImagePath, this.CompanyName, this.TaxIDCard,
                this.CommeercialRegister);
            return this.SupplierID > 0;

        }
        public static clsSupplier FindSupplier(int SupplierID)
        {
            string Name = "", Phone = "", Email = "", CompanyName = "", TaxIDCard = "", CommercialRegister = "",
                Address = "", ImagePath = "";
            if(SuppliersDataLayer.FindSupplierBySupplierID(SupplierID,ref Name,ref Phone,ref Email,ref CompanyName,
                ref TaxIDCard,ref CommercialRegister,ref Address,ref ImagePath))
            {
                return new clsSupplier(SupplierID, Name, Phone, Email, Address, ImagePath, CompanyName,
                    TaxIDCard, CommercialRegister);
            }
            else
            {
                return null;
            }
        }
        private bool _UpdateSupplier()
        {
            if (_IsThereEmptyRequiredFields())
            {
                return false;
            }

            return SuppliersDataLayer.UpdateSupplierInfo(this.SupplierID, this.Name, this.Phone, this.Email,
                this.Address, this.ImagePath, this.CompanyName, this.TaxIDCard, this.CommeercialRegister);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNewMode:
                    if (this._AddNewSupplier())
                    {
                        return true;
                    }
                    break;
                case enMode.UpdateMode:
                    if(this._UpdateSupplier())
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }


    }
}
