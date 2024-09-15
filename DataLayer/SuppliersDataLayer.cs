using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Security.Permissions;

namespace DataLayer
{
    public class SuppliersDataLayer
    {
        public static int AddNewSupplier(string Name,string Phone,string Email,string Address,
            string ImagePath,
            string CompanyName,string TaxIDCard,
            string CommercialRegister)
        {
            int InsertedID = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_AddNewSupplier", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;
                        if (!String.IsNullOrEmpty(Name))
                            Command.Parameters.AddWithValue("@Name", Name);
                        else
                            Command.Parameters.AddWithValue("@Name", System.DBNull.Value);
                        if (!String.IsNullOrEmpty(Phone))
                            Command.Parameters.AddWithValue("@Phone", Phone);
                        else
                            Command.Parameters.AddWithValue("@Phone", System.DBNull.Value);
                        if (!String.IsNullOrEmpty(Email))
                            Command.Parameters.AddWithValue("@Email", Email);
                        else
                            Command.Parameters.AddWithValue("@Email", System.DBNull.Value);
                        if (!String.IsNullOrEmpty(Address))
                            Command.Parameters.AddWithValue("@Address", Address);
                        else
                            Command.Parameters.AddWithValue("@Address", System.DBNull.Value);
                        if (!string.IsNullOrEmpty(ImagePath))
                            Command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            Command.Parameters.AddWithValue("ImagePath", System.DBNull.Value);

                        Command.Parameters.AddWithValue("@CompanyName", CompanyName);
                       if(!string.IsNullOrEmpty(TaxIDCard))
                            Command.Parameters.AddWithValue("@TaxIDCard", TaxIDCard);
                        else
                            Command.Parameters.AddWithValue("@TaxIDCard", System.DBNull.Value);
                       if(!string.IsNullOrEmpty(CommercialRegister))
                        Command.Parameters.AddWithValue("@CommercialRegister", CommercialRegister);
                       else
                            Command.Parameters.AddWithValue("@CommercialRegister", System.DBNull.Value);


                        SqlParameter OutPutParameter = new SqlParameter();
                        OutPutParameter.ParameterName = "@SupplierID";
                        OutPutParameter.SqlDbType = System.Data.SqlDbType.Int;
                        OutPutParameter.Direction=System.Data.ParameterDirection.Output;
                        Command.Parameters.Add(OutPutParameter);

                    
                        Connection.Open();
                        Command.ExecuteNonQuery();

                        InsertedID =(int) OutPutParameter.Value;


                    }

                }
            }
            catch (Exception ex)
            {
                InsertedID = 0;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in AddNewProduct Func dataLayer");

            }

            return InsertedID;


        }

        public static bool IsThisCompanyNameExistsInDataBase(string CompanyName,ref  string Name)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command=new SqlCommand("SP_IsThisComanyNameExists", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@CompanyName", CompanyName);
                        using (SqlDataReader Reader=Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                IsFound = true;
                                Name = (string)Reader["Name"];
                            }
                        }
                    }
                }

            }catch(Exception ex)
            {
                IsFound = false;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in IsCompany Exists Func Suppliers Datalayer" + ex.Message);
            }

            return IsFound;
        }

        public static bool FindSupplierBySupplierID(int SupplierID,ref string Name,ref string Phone,ref string Email,
            ref string CompanyName,ref string TaxCard,ref string CommercialRegister,
            ref string Address,ref string ImagePath)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection=new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command =new SqlCommand("SP_GetSupplierInfoBySupplierID", Connection))
                    {
                        Command.CommandType=System.Data.CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@SupplierID", SupplierID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                IsFound = true;
                                Name = (string)Reader["Name"];
                                Phone = (string)Reader["Phone"];
                                if (Reader["Email"]!=System.DBNull.Value)
                                    Email = (string)Reader["Email"];
                                else
                                    Email = "";
                                CompanyName = (string)Reader["CompanyName"];
                                if (Reader["TaxIDCard"] != System.DBNull.Value)
                                    TaxCard = (string)Reader["TaxIDCard"];
                                else
                                    TaxCard = "";
                                if (Reader["CommercialRegister"] != System.DBNull.Value)
                                    CommercialRegister = (string)Reader["CommercialRegister"];
                                else
                                    CommercialRegister = "";
                                Address = (string)Reader["Address"];
                                if (Reader["ImagePath"] != System.DBNull.Value)
                                    ImagePath = (string)Reader["ImagePath"];
                                else
                                    ImagePath = "";
                            }
                        }
                    }
                }
            }catch (Exception ex)
            {
                IsFound = false;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in find Supplier by ID " + ex.Message);
            }
            return IsFound; 
        }

        public static bool UpdateSupplierInfo(int SupplierID, string Name, string Phone, string Email, string Address,
            string ImagePath,
            string CompanyName, string TaxIDCard,
            string CommercialRegister)
        {
            int? NumberOfAffectedRows = null;
            try
            {
                using (SqlConnection Connection=new SqlConnection(clsGeneralSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command=new SqlCommand("SP_UpdateSupplierInfo", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@SupplierID", SupplierID);
                        Command.Parameters.AddWithValue("@Name", Name);
                        Command.Parameters.AddWithValue("@Phone", Phone);
                        if (!string.IsNullOrEmpty(Email))
                            Command.Parameters.AddWithValue("@Email", Email);
                        else
                            Command.Parameters.AddWithValue("@Email", System.DBNull.Value);


                        Command.Parameters.AddWithValue("@Address", Address);
                        if (!string.IsNullOrEmpty(ImagePath))
                            Command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

                        if (!string.IsNullOrEmpty(TaxIDCard))
                            Command.Parameters.AddWithValue("@TaxIDCard", TaxIDCard);
                        else
                            Command.Parameters.AddWithValue("@TaxIDCard", System.DBNull.Value);

                        if (!string.IsNullOrEmpty(CommercialRegister))
                            Command.Parameters.AddWithValue("@CommercialRegister", CommercialRegister);
                        else
                            Command.Parameters.AddWithValue("@CommercialRegister", System.DBNull.Value);

                        Command.Parameters.AddWithValue("@CompanyName", CompanyName);

                        NumberOfAffectedRows = Command.ExecuteNonQuery();


                    }
                }
            }catch (Exception ex)
            {
                NumberOfAffectedRows=null;
                clsGeneralSettings.Add_ERROR_ToEventLog("Error in Update supplier Func " + ex.Message);
            }

            return NumberOfAffectedRows.HasValue;
        }
    }
}
