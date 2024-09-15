using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.CompilerServices;

namespace DataLayer
{
    public class ChequesDataLayer
    {
        public static int AddCheque(int CollectionID,string ChequeNumber,Decimal ChequeValue,DateTime DueDate,
            byte BankNameID)
        {
            int InsertedID = 0;
            try
            {
                using (SqlConnection Connection=new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();

                    using (SqlCommand Command=new SqlCommand("SP_AddNewCheque", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@ChequeNumber", ChequeNumber);
                        Command.Parameters.AddWithValue("@CollectionID", CollectionID);
                        Command.Parameters.AddWithValue("@ChequeValue", ChequeValue);
                        Command.Parameters.AddWithValue("@DueDate", DueDate);
                        Command.Parameters.AddWithValue("@BankNameID", BankNameID);

                        SqlParameter OutPutParameter = new SqlParameter("@ID", System.Data.SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output

                        };

                        Command.Parameters.Add(OutPutParameter);
                        Command.ExecuteNonQuery();

                        InsertedID = (int)Command.Parameters["@ID"].Value;
                    }
                }
            }catch (Exception ex)
            {
                InsertedID = 0;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in Add New Cheque Func " + ex.Message);
            }

            return InsertedID;
        }

        public static List<Tuple<int,string,Decimal,string,DateTime,string>> GetAllOutStandingCheques()
        {
            List<Tuple<int, string, Decimal, string, DateTime, string>> OutStandingChequeList =
                new List<Tuple<int, string, Decimal, string, DateTime, string>>();
            try
            {
                using (SqlConnection Connection=new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command=new SqlCommand("SP_GetAllOutStandingChequesDetails", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                int ID = (int)Reader["ID"];
                                string ChequeNumber = (string)Reader["ChequeNumber"];
                                Decimal ChequeValue = (Decimal)Reader["ChequeValue"];
                                string CustomerName = (string)Reader["CustomerName"];
                                DateTime DueDate = (DateTime)Reader["DueDate"];
                                string BankName = (string)Reader["BankName"];

                                OutStandingChequeList.Add(Tuple.Create(ID,ChequeNumber,ChequeValue,CustomerName,
                                    DueDate,BankName));
                            }
                        }
                    }
                }
            }catch (Exception ex)
            {
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in Get all outstanding cheques Func " + ex.Message);
            }
            return OutStandingChequeList;
        }

    }
}
