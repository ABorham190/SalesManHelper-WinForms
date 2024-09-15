using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLayer;
using My_Custom_control_Library;
using System.Diagnostics.Eventing.Reader;

namespace MyControlLib_SMH_
{
    public partial class ctrAddEditProductInfo: UserControl
    {
        clsProduct _Product;
        
        
        public ctrAddEditProductInfo()
        {
            InitializeComponent();
            
        }
        public class ProductArgs
        {
            public int? ProductID { get; set; }

            public ProductArgs(int? productid)
            {
                ProductID = productid;
            }
        }

        public event EventHandler<ProductArgs> OnAddNewProduct;

        public void RaiseOnAddNewProductComplete(int? productID)
        {
            RaiseOnAddNewProductComplete(new ProductArgs(productID));
        }

        protected virtual void RaiseOnAddNewProductComplete(ProductArgs e)
        {
            OnAddNewProduct?.Invoke(this, e);
        }

        private void _GetProductStatesToCBXState()
        {
            DataTable dt = clsProduct.GetProductStates();
            foreach (DataRow row in dt.Rows)
            {
                cbxProductType.Items.Add(row["Name"]);
            }
            cbxProductType.SelectedItem = "Injection(Solution)";
        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {
            _GetProductStatesToCBXState();
        }

        public void CheckValidity(object sender,CancelEventArgs e)
        {
            My_Custom_control_Library.MyTextBox2 tbox = (MyTextBox2)sender;
            if (!tbox.IsValid())
            {
                errorProvider1.SetError(tbox, "Please Insert A Valid Value");
                tbox.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(tbox, "");
            }
            
        }

        private void _LoadProductInfoToObject()
        {
            try
            {
                _Product.ProductName = tbxProductName.Text;
                _Product.Brand = tbxBrandName.Text;

                if (tbxConc.Text.Trim().Length > 0)
                    _Product.Concentration = Convert.ToByte(tbxConc.Text);
                else
                    _Product.Concentration = 0;

                if (tbxUnit.Text.Trim().Length > 0)
                    _Product.Unit = Convert.ToInt16(tbxUnit.Text);
                else
                    _Product.Unit = 0;
                _Product.ActiveIngrediant = tbxActiveIng.Text;
                _Product.Notes = tbxNotes.Text;
                _Product.Type = Convert.ToByte(cbxProductType.SelectedIndex + 1);
                _Product.Company= tbxCompany.Text;
                _Product.AdditionDate = DateTime.Now;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        public void AddNewProduct(string WhatToDo)
        {
            if (!this.ValidateChildren())
            {

                return;
            }
            if (MessageBox.Show($"Are you sure you want to {WhatToDo} this product to the system?",
                $"{WhatToDo}ing Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                string brand = null;
                int productID = 0;
                if (!clsProduct.IsProductExists(tbxProductName.Text, ref productID, ref brand))
                {
                    _Product = new clsProduct();
                    _LoadProductInfoToObject();
                    if (_Product.Save())
                    {
                        MessageBox.Show($"{_Product.ProductName.ToUpper()} Saved Successfully",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RaiseOnAddNewProductComplete(_Product.ProductID);
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"{_Product.ProductName.ToUpper()} NOT Saved Successfully",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                }
                else
                {
                    MessageBox.Show("There is a Product has the same Name in the system !!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Cancelled Operation", "Aborted", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);

            }


            return;
        }
       
        public bool LoadObjectInfoToControls(int? ProductID)
        {
            if ((_Product = clsProduct.FindProductByProductID(ProductID)) != null)
            {

                tbxProductName.Text = _Product.ProductName;
                tbxBrandName.Text = _Product.Brand;
                tbxUnit.Text = _Product.Unit.ToString();
                tbxConc.Text = _Product.Concentration.ToString();
                tbxNotes.Text = _Product.Notes;
                cbxProductType.SelectedIndex = _Product.Type - 1;
                tbxActiveIng.Text = _Product.ActiveIngrediant;
                tbxCompany.Text = _Product.Company;

                return true;

            }
            else
            {
                return false;
            }

            

        }

        public void UpdateProduct(int? ProductID,string WhatToDo)
        {

            if (!this.ValidateChildren())
            {

                return;
            }
            if (clsProduct.IsAnotherProductHasTheSameNewProductName(ProductID, tbxProductName.Text))
            {
                MessageBox.Show("There is another Product on the system has the same Name :-(",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to {WhatToDo} this product to the system?",
                $"{WhatToDo}ing Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
               
                
                
                    _LoadProductInfoToObject();
                    if (_Product.Save())
                    {
                        MessageBox.Show($"{_Product.ProductName.ToUpper()} Saved Successfully",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"{_Product.ProductName.ToUpper()} NOT Saved Successfully",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
               
            }
            else
            {
                MessageBox.Show("Cancelled Operation", "Aborted", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);

            }


            return;


        }

       
    }
}
