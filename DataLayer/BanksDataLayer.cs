using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BanksDataLayer
    {
        public static List<string> GetAllBanksNames()
        {
            List<string>BankNamesList = new List<string>();
            try
            {
                string Querey = @"select Name from Banks;";
                using (SqlConnection Connection=new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command=new SqlCommand(Querey, Connection))
                    {
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                BankNamesList.Add((string)Reader["Name"]);
                            }
                        }
                    }
                }
            }catch (Exception ex)
            {
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in Get BanksNames " + ex.Message);
            }

            return BankNamesList;
        }
    }
}
