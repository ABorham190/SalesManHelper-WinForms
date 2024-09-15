using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PaymentMethodsDataLayer
    {
        public static Dictionary<int,string> GetAllPaymentMethods()
        {
            Dictionary<int,string>PayMethods= new Dictionary<int,string>();

            try
            {
                string Querey = @"select * from CollectionTypes; ";
                using (SqlConnection Connection=new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command=new SqlCommand(Querey, Connection))
                    {
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                byte Key = (byte)Reader["CollectionTypeID"];
                                string Value = (string)Reader["CollectionTypeName"];

                                PayMethods.Add(Key, Value);
                            }
                        }
                    }
                }
            }catch (Exception ex)
            {
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in GetAllCollectionMethods Func " + ex.Message);
            }
            return PayMethods;
        }
    }
}
