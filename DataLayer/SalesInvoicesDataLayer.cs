using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SalesInvoicesDataLayer
    {
        public static int? AddNewSalesInvoice(int? CustomerID,DateTime?InvoiceDate,Decimal?TotalValue,byte?AdditionalDiscount
            ,bool?IsCash,DateTime? DueDate,Decimal?AmountPaid,byte?CollectionTypeID)
        {
            int? InsertedID= null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_AddAnInvoiceAndDetails", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        if (CustomerID.HasValue)
                            Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        else
                            Command.Parameters.AddWithValue("@CustomerID", DBNull.Value);


                        if (InvoiceDate.HasValue)
                            Command.Parameters.AddWithValue("@InvoiceDate", InvoiceDate);
                       


                        if (TotalValue.HasValue)
                            Command.Parameters.AddWithValue("@TotalValue", TotalValue);
                        else
                            Command.Parameters.AddWithValue("@TotalValue", DBNull.Value);


                        if (AdditionalDiscount.HasValue)
                            Command.Parameters.AddWithValue("@AdditionalDiscount", AdditionalDiscount);
                        else
                            Command.Parameters.AddWithValue("@AdditionalDiscount", 0);

                        if (IsCash.HasValue)
                            Command.Parameters.AddWithValue("@IsCash", IsCash);


                        if (DueDate.HasValue)
                            Command.Parameters.AddWithValue("@DueDate", DueDate);
                        else
                            Command.Parameters.AddWithValue("@DueDate", DBNull.Value);

                        if (AmountPaid.HasValue)
                            Command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
                        else
                            Command.Parameters.AddWithValue("@AmountPaid", 0);

                        if (CollectionTypeID.HasValue)
                            Command.Parameters.AddWithValue("@CollectionType", CollectionTypeID);
                        else 
                            Command.Parameters.AddWithValue("@CollectionType", 1);




                        SqlParameter OutPutParameter = new SqlParameter("@SalesInvoiceID", System.Data.SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        Command.Parameters.Add(OutPutParameter);

                        Command.ExecuteNonQuery();

                        InsertedID = (int)Command.Parameters["@SalesInvoiceID"].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                InsertedID = null;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in Add New Sales Invoice func " + ex.Message);
            }
            return InsertedID;
        }

        public static bool DeleteSalesInvoiceWithDependencies(int? SalesInvoiceID)
        {
            int? NumberOfAffectedRows = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_DeleteSalesInvoiceWithDependencies", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@SalesInvoiceID", SalesInvoiceID);

                        NumberOfAffectedRows = Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                NumberOfAffectedRows=null;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in DeleteSalesInvoiceWithDependencies func " + ex.Message);

            }

            return NumberOfAffectedRows > 0;
        }

        public static bool IsSalesInvoiceExists(int? SalesInvoiceID)
        {
            bool IsFound=false; 
          try
          {
                using (SqlConnection Connection = new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsSalesInvoiceExists", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@SalesInvoiceID", SalesInvoiceID);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            IsFound = Reader.HasRows;
                        }
                    }
                }
           }
           catch (Exception ex)
           {
                IsFound = false;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in Is SalesInvoiceExists Func " + ex.Message);
            }

            return IsFound;
        }

        public static bool GetSalesInvoiceDetailsByID(int? SalesInvoiceID,ref int?CustomerID,ref DateTime?InvoiceDate,
            ref Decimal?TotalValue,ref byte?AdditionalDiscount,ref bool?IsCash,ref Decimal?AmountPaid,
            ref bool? isDeleted,ref DateTime?DueDate,ref DateTime?DeleteDate)
        {
            bool IsFound=false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetSalesInvoiceInfoByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@SalesInvoiceID", SalesInvoiceID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                IsFound = true;
                                CustomerID = (int)Reader["CustomerID"];
                                InvoiceDate = (DateTime)Reader["InvoiceDate"];
                                TotalValue = (Decimal)Reader["TotalValue"];
                                AdditionalDiscount = (byte)Reader["AdditionalDiscount"];
                                IsCash = (bool)Reader["IsCash"];
                                AmountPaid = (Decimal)Reader["AmountPaid"];
                                isDeleted = (bool)Reader["IsDeleted"];

                                if ((bool)Reader["IsDeleted"] == true)
                                    DeleteDate = (DateTime)Reader["DeleteDate"];

                                DueDate = (DateTime)Reader["DueDate"];

                                

                            }
                        }
                    }
                }
            } catch (Exception ex)
            {
                IsFound=false;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in GetSalesInvoiceDetailsByID Func " + ex.Message);
            }

            return IsFound;

        }

        //public static DataTable GetAllSalesInvoices()
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        using (SqlConnection Connection=new SqlConnection(clsGeneralSettings.ConnectionString))
        //        {
        //            Connection.Open();
        //            using (SqlCommand Command=new SqlCommand("SP_GetAllSalesInvoices", Connection))
        //            {
        //                Command.CommandType = CommandType.StoredProcedure;

        //                using (SqlDataReader Reader = Command.ExecuteReader())
        //                {
        //                    if (Reader.HasRows)
        //                    {
        //                        dt.Load(Reader);
        //                    }
        //                }
        //            }
        //        }
        //    }catch (Exception ex)
        //    {
        //        clsGeneralSettings.Add_ERROR_ToEventLog("Error in GetAllSalesInvoices Func " + ex.Message);
        //    }
        //    return dt;
        //}
        public static List<Tuple<int,string,DateTime,Decimal,DateTime,byte>> GetAllSalesInvoices()
        {
            List<Tuple<int,string,DateTime,Decimal,DateTime,byte>> SalesInvoises = 
                new List<Tuple<int,string,DateTime,Decimal,DateTime,byte>>();
           
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllSalesInvoices", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                int SalesInvoiceID = (int)Reader["SalesInvoiceID"];
                                string CustomerName = (string)Reader["Name"];
                                DateTime SalesInvoiceDate = (DateTime)Reader["InvoiceDate"];
                                Decimal TotalValue = (Decimal)Reader["TotalValue"];
                                DateTime DueDate = (DateTime)Reader["DueDate"];
                                byte AdditionalDiscount = (byte)Reader["AdditionalDiscount"];
                                


                                SalesInvoises.Add(Tuple.Create(SalesInvoiceID, CustomerName,SalesInvoiceDate ,TotalValue, DueDate,AdditionalDiscount));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in GetAllSalesInvoices Func " + ex.Message);
            }
            

            return SalesInvoises;
        }
    }
}
