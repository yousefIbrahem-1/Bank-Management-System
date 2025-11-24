using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_DataAccess
{
    public class clsClientData
    {
        public static DataTable GetAllAccounts()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_GetAllAccountsAndCertificates", connection))
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
        public static DataTable GetAllClients()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_GetAllClients", connection))
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
        public static bool GetClientsByID(Nullable<int> ClientID,ref decimal AccountBalance,ref int AcountID,ref bool IsActive ,ref Nullable<int> PersonID)
        {
            bool IsFound=false;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_GetClientByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("ClientID", ClientID);


                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        IsFound = true;

                     AccountBalance  = (decimal)reader["AcountBalance"];
                      AcountID = (int)reader["AcountID"];
                      IsActive = (bool)reader["IsActive"];
                      PersonID = (int)reader["PersonID"];
                    }
                    else
                        IsFound = false;
                }
            }

            return IsFound;
        }

        public static bool IsClientExistByPersonID(Nullable<int> PersonID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_IsClientExistByPersonID", connection))
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


        public static Nullable<int> AddNewClient(decimal AccountBalance,int AccountID,Nullable<int>PersonID,Nullable <int>ResponsibleEmployeeID)
        {

            Nullable<int> ClientID = null;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_AddNewClient", connection))
            {
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.AddWithValue("@AccountBalance", AccountBalance);
                command.Parameters.AddWithValue("@AccountID", AccountID);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@ResponsibleEmployeeID", ResponsibleEmployeeID);

                connection.Open();

                object res = command.ExecuteScalar();
                if (res != null && int.TryParse(res.ToString(), out int insertedID))
                {
                    ClientID = insertedID;
                }
            }

                return ClientID;


            

        }

        public static Nullable<int> UpdateClient(decimal AccountBalance, int AccountID, Nullable<int> PersonID, Nullable<int> ResponsibleEmployeeID)
        {

            Nullable<int> ClientID = null;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_AddNewEmployee", connection))
            {
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.AddWithValue("@AccountBalance", AccountBalance);
                command.Parameters.AddWithValue("@AccountID", AccountID);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@ResponsibleEmployeeID", ResponsibleEmployeeID);

                connection.Open();

                object res = command.ExecuteScalar();
                if (res != null && int.TryParse(res.ToString(), out int insertedID))
                {
                    ClientID = insertedID;
                }
                return ClientID;


            }

        }

    }
}
