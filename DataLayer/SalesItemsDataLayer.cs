using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace DataLayer
{
    public class SalesItemsDataLayer
    {
        public static int? AddNewSalesItem(int?ProductID,int?SalesInvoiceID,int?NumberOfUnits,Decimal?UnitPrice
            )
        {
            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_AddNewSalesItem", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        if (ProductID.HasValue)
                            Command.Parameters.AddWithValue("@ProductID", ProductID);
                        else
                            Command.Parameters.AddWithValue("@ProductID", DBNull.Value);


                        


                        if (SalesInvoiceID.HasValue)
                            Command.Parameters.AddWithValue("@SalesInvoiceID", SalesInvoiceID);
                        else
                            Command.Parameters.AddWithValue("@SalesInvoiceID", DBNull.Value);


                        if (NumberOfUnits.HasValue)
                            Command.Parameters.AddWithValue("@NumberOfUnits", NumberOfUnits);
                        else
                            Command.Parameters.AddWithValue("@NumberOfUnits", DBNull.Value);


                        if (UnitPrice.HasValue)
                            Command.Parameters.AddWithValue("@UnitPrice", UnitPrice);
                        else
                            Command.Parameters.AddWithValue("@UnitPrice", DBNull.Value);


                       


                        SqlParameter OutPutParameter = new SqlParameter("@SalesItemID", System.Data.SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        Command.Parameters.Add(OutPutParameter);

                        Command.ExecuteNonQuery();

                        InsertedID = (int)Command.Parameters["@SalesItemID"].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                InsertedID = null;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in Add New SalesItem func " + ex.Message);
            }
            return InsertedID;
        }

        
        public static DataTable GetAllSalesItemsInSalesInvoice(int? SalesInvoiceID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection Connection=new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command=new SqlCommand("SP_GetAllSalesItemsInSalesInvoiceWithProductName", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@SalesInvoiceID", SalesInvoiceID);
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
                dt = null;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in GetAllSalesItemsInSalesInvoice Func " + ex.Message);
            }

            return dt;
        }

        public static bool DeleteSalesItemWithDependencies(int?SalesItemID,Decimal?TotalAmount,
            int?SalesInvoiceID, int? CustomerID)
        {
            int? NumberOfAffectedRows = null;

            try
            {
                using (SqlConnection Connection=new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command=new SqlCommand("SP_DeleteSalesItemWithDependencies", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@SalesItemID", SalesItemID);
                        Command.Parameters.AddWithValue("@TotalAmount",TotalAmount);
                        Command.Parameters.AddWithValue("@SalesInvoiceID",SalesInvoiceID);
                        Command.Parameters.AddWithValue("@CustomerID",CustomerID);

                        NumberOfAffectedRows = Command.ExecuteNonQuery();
                    }
                }
            }catch(Exception ex)
            {
                NumberOfAffectedRows=null;
                clsGeneralSettings.Add_ERROR_ToEventLog("Erro in DeleteSalesItemWithDependencies Func " + ex.Message);
            }
            return NumberOfAffectedRows > 0;
        }



        
    }
}
