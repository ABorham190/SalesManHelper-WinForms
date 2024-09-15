using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class Groups
    {
        public static DataTable GetSalesAndCollectionsInAPeriod()
        {
            return GroupsDataLayer.GetTotalSalesAndCollectionsInAPeriod();
        }
    }
}
