using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_DataAccess
{
    public class clsEmployeeData
    {

        public static bool GetEmployeeByID(Nullable<int> EmployeeID , ref string UserName, ref string Password, ref bool IsActive, ref int Permissions, ref Nullable<int> PersonID)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_GetEmployeeByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("EmployeeID", EmployeeID);


                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        IsFound = true;

                        UserName = (string)reader["UserName"];
                        Password = (string)reader["Password"];
                        IsActive = (bool)reader["IsActive"];
                        Permissions = (int)reader["Permissions"];
                        PersonID = (int)reader["PersonID"];
                    }
                    else
                        IsFound = false;
                }
            }
            return IsFound;
        }

        public static DataTable GetAllEmployees()
        {

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_GetAllEmployees", connection))
            {
                command.CommandType = CommandType.StoredProcedure;



                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dt.Load(reader);


                    }


                }


            }
            return dt;

        }
        public static bool GetEmployeeByUsernameAndPassword(ref Nullable <int> EmployeeID , string UserName, string Password, ref bool IsActive, ref int Permissions, ref Nullable<int> PersonID)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_GetEmployeeByUsernameAndPassword", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("UserName", UserName);
                command.Parameters.AddWithValue("Password", Password);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        IsFound = true;

                        EmployeeID = (int)reader["EmployeeID"];
                        IsActive = (bool)reader["IsActive"];
                        Permissions = (int)reader["Permissions"];
                        PersonID = (int)reader["PersonID"];
                    }
                    else
                        IsFound = false;
                }
            }
            return IsFound;
        }
        public static bool ChangePassword(Nullable<int> EmployeeID, string NewPassword)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_ChangePassword", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("EmployeeID", EmployeeID);
                command.Parameters.AddWithValue("NewPassword", NewPassword);

                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public static bool IsEmployeeExistByUserName(string UserName)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_IsEmployeeExistByUserName", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserName", UserName);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    isFound = reader.HasRows;

                }

            }
            return isFound;
        }

        public static bool IsEmployeeExistByEmployeeID(int EmployeeID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_IsEmployeeExistByEmployeeID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    isFound = reader.HasRows;

                }

            }
            return isFound;
        }

        public static bool IsEmployeeExistByPersonID(Nullable<int> PersonID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_IsEmployeeExistByPersonID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", PersonID);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    isFound = reader.HasRows;

                }

            }
            return isFound;
        }
        public static Nullable<int> AddNewEmployee(string UserName, string Password, Nullable<int> PersonID, int Permissions, bool IsActive, Nullable<int> ResponsibleEmployeeID)
        {

            Nullable<int> EmployeeID = null;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_AddNewEmployee", connection))
            {
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@Permissions", Permissions);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@ResponsibleEmployeeID", ResponsibleEmployeeID);

                connection.Open();

                object res = command.ExecuteScalar();
                if (res != null && int.TryParse(res.ToString(), out int insertedID))
                {
                    EmployeeID = insertedID;
                }
                return EmployeeID;


            }

        }
        public static bool UpdateEmployee(Nullable<int> EmployeeID, string UserName, string Password, Nullable<int> PersonID, int Permissions, bool IsActive, Nullable<int> ResponsibleEmployeeID)
        {

            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_UpdateEmployeeByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@Permissions", Permissions);
                command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                command.Parameters.AddWithValue("@ResponsibleEmployeeID", ResponsibleEmployeeID);


                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }


            return (rowsAffected > 0);

        }
        public static bool DeleteEmployee(int EmployeeID, Nullable<int> ResponsibleEmployeeID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_DeleteEmployeeByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                command.Parameters.AddWithValue("@ResponsibleEmployeeID", ResponsibleEmployeeID);

                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }


            return (rowsAffected > 0);
        }

        public static bool ActiveEmployee(int EmployeeID, Nullable<int> ResponsibleEmployeeID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_ActiveEmployeeByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                command.Parameters.AddWithValue("@ResponsibleEmployeeID", ResponsibleEmployeeID);

                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }


            return (rowsAffected > 0);
        }


       
    }
}
