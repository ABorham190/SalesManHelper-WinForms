using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManHelper
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1(29));
            //Application.Run(new frmAddEditProductInfo());
            // Application.Run(new frmProductDetails("ZeleriS"));
            //Application.Run(new Main());
            //Application.Run(new frmAddEditSalesInvoice(54));
            //Application.Run(new ProductsList());
            //Application.Run(new frmAddEditSupplierInfo(15));
            //Application.Run(new frmAddEditCustomer());
            //Application.Run(new frmGetAllCustomers());
            Application.Run(new Main());


        }
    }
}
