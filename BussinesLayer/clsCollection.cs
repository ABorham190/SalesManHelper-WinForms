using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataLayer;

namespace BussinesLayer
{
    public class clsCollection
    {
        public int CollectionID { get; set; }
        public int? CustomerID { get; set; }
        public Decimal Amount {  get; set; }
        public clsCustomer Customer { get; set; }
        public DateTime CollectionDate {  get; set; }
        public byte CollectionType {  get; set; }


        private bool _AddNewCollection()
        {
            this.CollectionID = CollectionsDataLayer.AddNewCollection(this.CustomerID, this.Amount, this.CollectionType);

            return this.CollectionID > 0;

        }

        public bool Save()
        {
            if (this._AddNewCollection())
            {
                return true;
            }

            return false;
        }

        public static bool IsPaymentMoreThanDebit(Decimal Payment,Decimal? Debit)
        {
            return Payment > Debit;
        }

    }
}
