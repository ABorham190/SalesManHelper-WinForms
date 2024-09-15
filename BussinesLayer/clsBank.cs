using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class clsBank
    {
        public int ID {  get; set; }
        public string Name { get; set; }

        public static List<string> GetAllBanksNames()
        {
            return BanksDataLayer.GetAllBanksNames();
        }
    }
}
