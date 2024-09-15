using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProductDataLayer
    {
        public static int? AddNewProduct(string ProductName,string Brand,
            Int16 Unit,Byte Type,string ActiveIngrediant,Byte Concentration,string Company,
            string Notes,DateTime AdditionDate)
        {
            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_AddNewProduct", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ProductName", ProductName);
                        Command.Parameters.AddWithValue("@Brand", Brand);
                        if (Unit != 0)
                            Command.Parameters.AddWithValue("@Unit", Unit);
                        else
                            Command.Parameters.AddWithValue("@Unit", System.DBNull.Value);
                        Command.Parameters.AddWithValue("@Type", Type);
                        Command.Parameters.AddWithValue("@Activeingrediant", ActiveIngrediant);
                        if (Concentration != 0)
                            Command.Parameters.AddWithValue("@Concentration", Concentration);
                        else
                            Command.Parameters.AddWithValue("@Concentration", System.DBNull.Value);

                        Command.Parameters.AddWithValue("@Company", Company);

                        if (Notes != null)
                            Command.Parameters.AddWithValue("@Notes", Notes);
                        else
                            Command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
                        Command.Parameters.AddWithValue("@AdditionDate", AdditionDate);
                        SqlParameter NewProductID = new SqlParameter("@ProductID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(NewProductID);



                        Connection.Open();
                        Command.ExecuteNonQuery();

                        InsertedID = (int)Command.Parameters["@ProductID"].Value;


                    }

                }
            }
            catch (Exception ex)
            {
                InsertedID = null;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in AddNewProduct Func dataLayer");

            }

            return InsertedID;

        }


        public static DataTable GetProductStates()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command=new SqlCommand("SP_GetProductStates", Connection))
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
            }catch (Exception ex)
            {
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in GetProductStates func Product datalayer");
            }

            return dt;

        }

        public static bool IsProductExistsReturnIDAndBrand(string ProductName,
           ref string Brand, ref int ProductID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsProductExists", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ProductName", ProductName);
                        
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                IsFound = true;
                                ProductID = (int)Reader["ProductID"];
                                Brand = (string)Reader["Brand"];
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
                clsGeneralSettings.Add_ERROR_ToEventLog($"Error in IsProductExists func product datalayer {ex.Message}");
            }

            return IsFound;
        }

        public static bool GetProductInfoByProductID(int? ProductID,ref string ProductName,
            ref string Brand,ref Byte Type ,ref Int16 Unit,ref string ActiveIngrediant,
            ref Byte Concentration,ref string Company,ref string Notes,ref DateTime AdditionDate)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection=new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command =new SqlCommand("SP_GetProductInfoByProductID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ProductID", ProductID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                IsFound = true;
                                ProductName = (string)Reader["ProductName"];
                                Brand = (string)Reader["Brand"];
                                Unit = (Int16)Reader["Unit"];
                                Type = (Byte)Reader["Type"];
                                ActiveIngrediant = (string)Reader["ActiveIngrediant"];
                                Concentration = (Byte)Reader["Concentration"];
                                Company = (string)Reader["Company"];
                                Notes = (string)Reader["Notes"];
                                if (Reader["AdditionDate"]!=System.DBNull.Value)
                                    AdditionDate = (DateTime)Reader["AdditionDate"];
                                else
                                    AdditionDate=DateTime.MinValue;

                            }
                        }
                    }
                }
            }catch (Exception ex)
            {
                IsFound = false;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in GetProduct Info by ProductID Func Datalayer " + ex.Message);
            }
            return IsFound;
        }

        public static int UpdateProductInfo(int? ProductID,string ProductName,string Brand,Byte Type,
            Int16 Unit,string ActiveIngrediant,Byte Conc,string Company,string Notes)
        {
            int NumberOfAffectedRows = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_UpdateProductInfo", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ProductID", ProductID);
                        Command.Parameters.AddWithValue("@ProductName", ProductName);
                        Command.Parameters.AddWithValue("@Brand", Brand);
                        Command.Parameters.AddWithValue("@Type", Type);
                        Command.Parameters.AddWithValue("@Unit", Unit);
                        Command.Parameters.AddWithValue("@Activeingrediant", ActiveIngrediant);
                        Command.Parameters.AddWithValue("@Concentration", Conc);
                        Command.Parameters.AddWithValue("@Company", Company);
                        Command.Parameters.AddWithValue("@Notes", Notes);


                        NumberOfAffectedRows = Command.ExecuteNonQuery();

                    }
                }
            }catch (Exception ex)
            {
                NumberOfAffectedRows = 0;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in update product info Func DataLayer " + ex.Message);
            }

            return NumberOfAffectedRows;

        }

        public static bool IsAnotherProductHasTheSameNewProductName(int? ProductID,string ProductName)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection=new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command=new SqlCommand("SP_IsAnotherProductHasTheSameNewName", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ProductID", ProductID);
                        Command.Parameters.AddWithValue("@ProductName", ProductName);

                        using(SqlDataReader Reader = Command.ExecuteReader())
                        {
                            IsFound = Reader.HasRows;
                        }
                    }
                }
            }catch(Exception ex)
            {
                IsFound = false;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in IsAnotherProductHasTheSameNewProductName " + ex.Message);
            }
            return IsFound;
        }

        public static bool GetProductInfoByProductName(ref int ProductID,  ref string ProductName,
            ref string Brand, ref Byte Type, ref Int16 Unit, ref string ActiveIngrediant,
            ref Byte Concentration, ref string Company, ref string Notes, ref DateTime AdditionDate)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetProductInfoByProductName", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ProductName", ProductName);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                IsFound = true;
                                ProductID = (int)Reader["ProductID"];
                                ProductName = (string)Reader["ProductName"];
                                Brand = (string)Reader["Brand"];
                                Unit = (Int16)Reader["Unit"];
                                Type = (Byte)Reader["Type"];
                                ActiveIngrediant = (string)Reader["ActiveIngrediant"];
                                Concentration = (Byte)Reader["Concentration"];
                                Company = (string)Reader["Company"];
                                Notes = (string)Reader["Notes"];
                                if (Reader["AdditionDate"] != System.DBNull.Value)
                                    AdditionDate = (DateTime)Reader["AdditionDate"];
                                else
                                    AdditionDate = DateTime.MinValue;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in GetProduct Info by ProductID Func Datalayer " + ex.Message);
            }
            return IsFound;
        }

        public static DataTable GetAllProductsInTheSystem()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllProductsIntheSystemOrderedByName ", Connection))
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
            }
            catch (Exception ex)
            {
                
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in Get All Products in the system Datalayer  func" + ex.Message);
            }
            return dt;
        }
    }
}
