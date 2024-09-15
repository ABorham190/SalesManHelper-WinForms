using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CollectionsDataLayer
    {
        public static int AddNewCollection(int?CustomerID,Decimal AmountPaid,byte CollectionType)
        {
            int InsertedID = 0;

            try
            {
                using (SqlConnection Connection=new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using(SqlCommand Command=new SqlCommand("SP_AddNewCollection", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        Command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
                        Command.Parameters.AddWithValue("@CollectionType", CollectionType);

                        SqlParameter OutPutParameter = new SqlParameter("@CollectionID", System.Data.SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        Command.Parameters.Add(OutPutParameter);

                        Command.ExecuteNonQuery();

                        InsertedID = (int)Command.Parameters["@CollectionID"].Value;
                    }
                }
            }catch (Exception ex)
            {
                InsertedID = 0;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in AddNewCollection Func " + ex.Message);
            }

            return InsertedID;
        }

        
    }
}
