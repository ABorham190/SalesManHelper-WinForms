using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class GroupsDataLayer
    {
        public static DataTable GetTotalSalesAndCollectionsInAPeriod()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection Connection =new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command=new SqlCommand("SP_GetTotalSalesAndCollectionInAPeriod", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@StartDate", DBNull.Value);
                        Command.Parameters.AddWithValue("@EndDate", DBNull.Value);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                            {
                                dt.Load(Reader);
                            }
                        }
                    }
                }
            }catch (Exception ex)
            {
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in GetTotalSalesAndCollectionInAPeriod Func " + ex.Message);
            }

            return dt;
        }
    }
}
