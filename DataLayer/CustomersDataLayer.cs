using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataLayer
{
    public class CustomersDataLayer
    {
        public static int? AddNewCustomer(string Name,Int16 BusinessType,
            string Phone,string Email,string Address,Decimal? CreditLimit
            )
        {
            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection =new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command=new SqlCommand("SP_AddNewCustomer", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        if (!string.IsNullOrEmpty(Name))
                            Command.Parameters.AddWithValue("@Name", Name);
                        else
                            Command.Parameters.AddWithValue("@Name", DBNull.Value);


                        Command.Parameters.AddWithValue("@BusinessType", BusinessType);


                        if (!string.IsNullOrEmpty(Phone))
                            Command.Parameters.AddWithValue("@Phone", Phone);
                        else
                            Command.Parameters.AddWithValue("@Phone", DBNull.Value);


                        if (!string.IsNullOrEmpty(Email))
                            Command.Parameters.AddWithValue("@Email", Email);
                        else
                            Command.Parameters.AddWithValue("@Email", DBNull.Value);


                        if (!string.IsNullOrEmpty(Address))
                            Command.Parameters.AddWithValue("@Address", Address);
                        else
                            Command.Parameters.AddWithValue("Address", DBNull.Value);


                        if (CreditLimit.HasValue)
                            Command.Parameters.AddWithValue("@CreditLimit", CreditLimit);
                        else
                            Command.Parameters.AddWithValue("@CreditLimit", DBNull.Value);
                        

                        SqlParameter OutPutParameter = new SqlParameter("@CustomerID", System.Data.SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        Command.Parameters.Add(OutPutParameter);

                        Command.ExecuteNonQuery();

                        InsertedID = (int)Command.Parameters["@CustomerID"].Value;
                    }
                }
            }catch (Exception ex)
            {
                InsertedID=null;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in Add New Customer func " + ex.Message);
            }
            return InsertedID;
        }

        public static DataTable GetAllCustomersInSystem()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection Connection=new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command=new SqlCommand("SP_GetAllCustomersOnSystem", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                            {
                                dt.Load(Reader);
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in Get All Customers in the system func " + ex.Message);
            }
            return dt;
        }

        public static bool FindCustomerByCustomerID(int? CustomerID,ref string Name,
            ref byte BusinessType
            ,ref string Phone,
            ref string Email,ref string Address,ref Decimal? CreditLimit,ref Decimal? Debit,ref DateTime AdditionDate,
            ref bool IsDeleted)
        {
            bool IsFound=false;
            try
            {
                using (SqlConnection Connection=new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command=new SqlCommand("SP_FindCustomerByCustomerID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                IsFound=true;
                                Name = (string)Reader["Name"];
                                BusinessType = (byte)Reader["BusinessType"];
                                Phone = (string)Reader["Phone"];

                                if (Reader["Email"] != DBNull.Value)
                                    Email = (string)Reader["Email"];
                                else
                                    Email = null;

                                Address = (string)Reader["Address"];

                                if (Reader["CreditLimit"] != DBNull.Value)
                                    CreditLimit = Convert.ToDecimal(Reader["CreditLimit"]);
                                else
                                    CreditLimit = null;

                                if (Reader["Debit"] != DBNull.Value)
                                    Debit = Convert.ToDecimal(Reader["Debit"]);
                                else
                                    Debit = null;

                                AdditionDate = (DateTime)Reader["AdditionDate"];
                                IsDeleted = (bool)Reader["IsDeleted"];
                            }
                        }
                    }
                }
            }catch (Exception ex)
            {
                IsFound=false;
                clsGeneralSettings.Add_ERROR_ToEventLog("Erro in find Customer by CustomerID func" + ex.Message);
            }
            return IsFound;
        }


        public static bool FindCustomerByCustomerName(ref int? CustomerID,  string Name,
          ref byte BusinessType
          , ref string Phone,
          ref string Email, ref string Address, ref Decimal? CreditLimit, ref Decimal Debit, ref DateTime AdditionDate,
          ref bool IsDeleted)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_FindCustomerByCustomerName", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@Name",Name);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                IsFound = true;
                                CustomerID = (int)Reader["CustomerID"];
                                BusinessType = (byte)Reader["BusinessType"];
                                Phone = (string)Reader["Phone"];

                                Email = (string)Reader["Email"];
                                Address = (string)Reader["Address"];
                                CreditLimit = (Decimal)Reader["CreditLimit"];
                                Debit = (Decimal)Reader["Debit"];
                                AdditionDate = (DateTime)Reader["AdditionDate"];
                                IsDeleted = (bool)Reader["IsDeleted"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
                clsGeneralSettings.Add_ERROR_ToEventLog("Erro in find Customer by CustomerID func" + ex.Message);
            }
            return IsFound;
        }

        public static bool UpdateCustomerInfo(int? CustomerID,string Name, Int16 BusinessType,
            string Phone, string Email, string Address, Decimal? CreditLimit)
        {
            int? NumberOfAffectedRows = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_UpdateCustomerInfo", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);

                        if (!string.IsNullOrEmpty(Name))
                            Command.Parameters.AddWithValue("@Name", Name);
                        else
                            Command.Parameters.AddWithValue("@Name", DBNull.Value);


                        Command.Parameters.AddWithValue("@BusinessType", BusinessType);


                        if (!string.IsNullOrEmpty(Phone))
                            Command.Parameters.AddWithValue("@Phone", Phone);
                        else
                            Command.Parameters.AddWithValue("@Phone", DBNull.Value);


                        if (!string.IsNullOrEmpty(Email))
                            Command.Parameters.AddWithValue("@Email", Email);
                        else
                            Command.Parameters.AddWithValue("@Email", DBNull.Value);


                        if (!string.IsNullOrEmpty(Address))
                            Command.Parameters.AddWithValue("@Address", Address);
                        else
                            Command.Parameters.AddWithValue("Address", DBNull.Value);


                        if (CreditLimit.HasValue)
                            Command.Parameters.AddWithValue("@CreditLimit", CreditLimit);
                        else
                            Command.Parameters.AddWithValue("@CreditLimit", DBNull.Value);


                        NumberOfAffectedRows = Command.ExecuteNonQuery();

                       
                    }
                }
            }
            catch (Exception ex)
            {
                NumberOfAffectedRows = null;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in Add New Customer func " + ex.Message);
            }

            return NumberOfAffectedRows>0;
        }

        public static bool DeleteCustomerSoft(int? CustomerID)
        {
            int? NumberOfAffectedRows = null;
            try
            {
                using (SqlConnection Connection=new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command=new SqlCommand("SP_DeleteCustomerSoft", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);

                        NumberOfAffectedRows = Command.ExecuteNonQuery();
                    }
                }
            }catch (Exception ex)
            {
                NumberOfAffectedRows = null;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in Delete Customer Soft " + ex.Message);
            }
            return NumberOfAffectedRows>0;
        }

        public static bool IsCustomerNameExists(string CustomerName)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsCustomerNameExists", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@Name", CustomerName);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            IsFound = Reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound=false;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in IsCustomerNameExists " + ex.Message);
            }
            return IsFound;
        }

        public static int? GetCustomerIDUsingCustomerName(string CustomerName)
        {
            int?CustomerID = null;
            try
            {
                using (SqlConnection Connection=new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command=new SqlCommand("select dbo.GetCustomerIDByName(@CustomerName)", Connection))
                    {
                        Command.Parameters.AddWithValue("@CustomerName", CustomerName);

                        Object Result = Command.ExecuteScalar();
                        if(Result!=null && int.TryParse(Result.ToString(),out int ID))
                        {
                            CustomerID = ID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CustomerID=null;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in Get Customer ID Using Customer Name " + ex.Message);
            }

            return CustomerID;
        }

        public static bool IsCustomerDebitExceedsCreditLimit(Decimal InvoiceVlaue,int? CustomerID,
            ref Decimal CreditLimit,
           ref Decimal Debit)
        {
            bool IsFound = false;
            try
            {
                string Querey = "select CreditLimit,Debit from Customers Where Debit+@InvoiceValue>CreditLimit and" +
                    " CustomerID=@CustomerID;";
                using (SqlConnection Connection=new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command=new SqlCommand(Querey, Connection))
                    {
                        Command.Parameters.AddWithValue("@InvoiceValue", InvoiceVlaue);
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);


                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                IsFound = true;

                                CreditLimit = (Decimal)Reader["CreditLimit"];
                                Debit = (Decimal)Reader["Debit"];
                            }
                        }
                    }
                }
            }catch (Exception ex)
            {
                IsFound = false;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in IsCustomerDebitExceedsCreditLimit Func " + ex.Message);
            }
            return IsFound;
        }


        public static List<string> GetAllCustomersNames()
        {
            List<string>CustomersNames= new List<string>();
            try
            {
                string Querey = @"select Name from Customers;";
                using (SqlConnection Connection=new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command=new SqlCommand(Querey, Connection))
                    {
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                CustomersNames.Add((string)Reader["Name"]);
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in GetAllCustomersNames func " + ex.Message);
            }

            return CustomersNames;
        }
    }
}
