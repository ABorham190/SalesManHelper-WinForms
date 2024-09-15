using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class clsCheque
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public int CollectionID { get; set; }
        public Decimal Value { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsBounce { get; set; }
        public byte BankNameID {  get; set; }


        private bool _AddNew()
        {
            this.ID = ChequesDataLayer.AddCheque(this.CollectionID, this.Number, this.Value, this.DueDate,this.BankNameID);
            return this.ID > 0;
        }

        public bool Save()
        {
            if(this._AddNew())
            {
                return true;
            }
            return false;
        }

        public static List<Tuple<int, string, Decimal, string, DateTime, string>> GetAllOutStandingChequesFromDataLayer()
        {
            return ChequesDataLayer.GetAllOutStandingCheques();
        }
    }
}
