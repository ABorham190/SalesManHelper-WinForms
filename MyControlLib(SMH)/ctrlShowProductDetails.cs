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

namespace MyControlLib_SMH_
{
    public partial class ctrlShowProductDetails : UserControl
    {
        clsProduct _Product;
        string _MeasureUnit;
        public ctrlShowProductDetails()
        {
            InitializeComponent();
        }
       public class clsProductEventArgs
        {
            public int? ProductID {  get; set; }
            public clsProductEventArgs(int? productID)
            {
                ProductID = productID;
            }
        }
        public event EventHandler<clsProductEventArgs> OnShowProductDetails;

        public void RaiseOnShowProductDetails(int? ProductID)
        {
            RaiseOnShowProductDetails(new clsProductEventArgs(ProductID));
        }
        protected virtual void RaiseOnShowProductDetails(clsProductEventArgs e)
        {
            OnShowProductDetails?.Invoke(this, e);
        }
        private string _ProductType()
        {
            switch ((clsProduct.enProductType)_Product.Type)
            {
                case clsProduct.enProductType.InjectionSolution:
                    _MeasureUnit = "ml";
                    return "Injection (Solution)";
                case clsProduct.enProductType.OralSolution:
                    _MeasureUnit = "ml";
                    return "Oral (Solution)";
                case clsProduct.enProductType.InjectionPowder:
                    _MeasureUnit = "gm";
                    return "Injection (Powder)";
                case clsProduct.enProductType.OralPowder:
                    _MeasureUnit = "gm";
                    return "Oral (Powder)";
                default:
                    return "Unknown";
            }
        }

        private void _LoadObjectDataToControls()
        {
            lblProductName.Text = _Product.ProductName;
            lblProductID.Text=_Product.ProductID.ToString();
            lblBrand.Text = _Product.Brand;
            lblCompany.Text = _Product.Company;
            lblActiveIng.Text = _Product.ActiveIngrediant;
            lblType.Text=_ProductType();
            lblUnit.Text = _Product.Unit.ToString()+" "+_MeasureUnit;
            lblAdditionDate.Text = _Product.AdditionDate.ToString("d");
            lblConcentration.Text = _Product.Concentration.ToString()+"%";
            lblNotes.Text = _Product.Notes;
        }

        public bool LoadProductInfo(int? ProductID)
        {
            string SearchItem = "ID"; 

            if ((_Product = clsProduct.FindProductByProductID(ProductID)) != null)
            {
                _LoadObjectDataToControls();
                return true;
            }
            else
            {
                MessageBox.Show($"There is no Product With this {SearchItem}","Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

        }

        public bool LoadProductInfo(string ProductName)
        {
            string SearchItem = "Name";
            if ((_Product = clsProduct.FindProductByProductName(ProductName)) != null)
            {
                _LoadObjectDataToControls();
                RaiseOnShowProductDetails(_Product.ProductID);
                return true;
            }
            else
            {
                MessageBox.Show($"There is no Product With this {SearchItem}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

        }

       
    }
}
