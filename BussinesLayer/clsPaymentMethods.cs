using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinesLayer
{
    public class clsPaymentMethods
    {
        public int PaymentMethodId {  get; set; }
        public string PaymentMethodName { get; set;}


        public static Dictionary<int,string> GetPaymentMethods()
        {
            return PaymentMethodsDataLayer.GetAllPaymentMethods();
        }
    }
}
