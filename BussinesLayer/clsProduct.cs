using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BussinesLayer
{
    public class clsProduct
    {
        int? _ProductID;
        string _ProductName;
        string _Brand;
        Int16 _Unit;
        Byte _Type;
        string _ActiveIngrediant;
        Byte _Concentration;
        string _Notes;
        public DateTime AdditionDate;
        public string Company;
        enum enMode { Update=1,AddNew=2};
        enMode _Mode = enMode.AddNew;
        public int? ProductID { get { return _ProductID; }set { _ProductID = value; } }
        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }
        public string Brand
        {
            get { return _Brand; }
            set
            {
                _Brand = value;
            }
        }
        public Int16 Unit
        {
            get { return _Unit; }
            set { _Unit = value; }
        }
        public Byte Type { get { return _Type; } set { _Type = value; } }
        public string ActiveIngrediant
        {
            get { return _ActiveIngrediant; }
            set { _ActiveIngrediant = value; }
        }
        public Byte Concentration { get { return _Concentration; } set { _Concentration = value; } }
        public string Notes { get { return _Notes; } set { _Notes = value; } }

        public enum enProductType { InjectionSolution=1,OralSolution=2,InjectionPowder=3,OralPowder=4}
        
        public clsProduct()
        {
            this.ProductName = null;
            this.ProductID = 0;
            this.Brand = null;
            this.ActiveIngrediant = null;
            this.Concentration = 0;
            this.Notes = null;
            this.Unit = 0;
            this.Type = 0;

            this._Mode = enMode.AddNew;
        }
        clsProduct(int ?productID, string productName, string brand, short unit, byte type, string activeIngrediant, byte concentration,string company, string notes, DateTime additionDate)
        {
            ProductID = productID;
            ProductName = productName;
            Brand = brand;
            Unit = unit;
            Type = type;
            ActiveIngrediant = activeIngrediant;
            Concentration = concentration;
            Notes = notes;
            AdditionDate = additionDate;
            Company = company;
            _Mode = enMode.Update;

            
        }

        private bool AddNewProduct()
        {
            this._ProductID= ProductDataLayer.AddNewProduct(this.ProductName,this.Brand,
                this.Unit,this.Type,this.ActiveIngrediant,this.Concentration,this.Company,this.Notes,
                this.AdditionDate);
            

            return this.ProductID.HasValue ;
        }


        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (this.AddNewProduct())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    if (this.UpdateProductInfo())
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

       
        public static DataTable GetProductStates()
        {
            return ProductDataLayer.GetProductStates();
        }
        public static bool IsProductExists(string ProductName,ref int ProductID,
            ref string Brand)
        {
            return ProductDataLayer.IsProductExistsReturnIDAndBrand(ProductName,
                ref Brand, ref ProductID);
        }

        public static clsProduct FindProductByProductID(int? ProductID)
        {
            string ProductName = "", Brand = "", ActiveIng = "", Notes = "",Company="";
            Int16 Unit=0;
            Byte Type=0, Conc=0;
            DateTime AdditionDate=DateTime.MinValue;

            if(ProductDataLayer.GetProductInfoByProductID(ProductID,ref ProductName,ref Brand,
                ref Type,ref Unit,ref ActiveIng,ref Conc,ref Company,ref Notes,ref AdditionDate))
            {
                return new clsProduct(ProductID,ProductName,Brand,Unit,Type,ActiveIng,Conc,Company,Notes,
                    AdditionDate);
            }
            else
            {
                return null;
            }

        }

         bool UpdateProductInfo()
        {
            return ProductDataLayer.UpdateProductInfo(this.ProductID, this.ProductName, this.Brand,
                 this.Type, this.Unit, this.ActiveIngrediant, this.Concentration,this.Company, this.Notes) > 0;
            
        }

        public static bool IsAnotherProductHasTheSameNewProductName(int? ProductID,string ProductName)
        {
            return ProductDataLayer.IsAnotherProductHasTheSameNewProductName(ProductID, ProductName);
        }

        public static clsProduct FindProductByProductName(string ProductName)
        {
            int ProductID = 0;
            string Brand = "", ActiveIng = "", Notes = "", Company = "";
            Int16 Unit = 0;
            Byte Type = 0, Conc = 0;
            DateTime AdditionDate = DateTime.MinValue;

            if (ProductDataLayer.GetProductInfoByProductName(ref ProductID,ref  ProductName, ref Brand,
                ref Type, ref Unit, ref ActiveIng, ref Conc, ref Company, ref Notes, ref AdditionDate))
            {
                return new clsProduct(ProductID, ProductName, Brand, Unit, Type, ActiveIng, Conc, Company, Notes,
                    AdditionDate);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllProducts()
        {
            return ProductDataLayer.GetAllProductsInTheSystem();
        }

    }
}
