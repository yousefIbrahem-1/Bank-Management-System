using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_DataAccess
{
    public class clsPersonData
    {
        public static bool GetPersonInfoByID(Nullable<int> PersonID,ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName
            , ref string HomePhone, ref string Phone, ref DateTime BirthOfDate,ref short Age,ref short Gender,ref string Address,ref string Email,ref string ImagePath)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_GetPersonByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", PersonID);


                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // The record was found
                        isFound = true;

                        FirstName = (string)reader["FirstName"];
                        SecondName = (string)reader["SecondName"];
                        ThirdName = (string)reader["ThirdName"];
                        LastName = (string)reader["LastName"];
                        if (reader["HomePhone"] != DBNull.Value)
                        {
                            HomePhone = (string)reader["HomePhone"];
                        }
                        else
                        {
                            HomePhone = "";
                        }
                        Phone = (string)reader["Phone"];
                        BirthOfDate = (DateTime)reader["BirthOfDate"];
                        Age = (short)reader["Age"];
                        Gender = (short)reader["Gender"];
                        Address = (string)reader["Address"];
                        Email=(string)reader["Email"];
                        if (reader["ImagePath"] != DBNull.Value)
                        {
                            ImagePath = (string)reader["ImagePath"];
                        }
                        else
                        {
                            ImagePath = "";
                        }
                      
                    }
                    else
                    {
                        // The record was not found
                        isFound = false;
                    }

                }


            }

            return isFound;
        }


        public static DataTable GetPeople()
        {
           
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_GetPeople", connection))
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


        public static Nullable<int> AddNewPerson( string FirstName, string SecondName, string ThirdName, string LastName
          , string HomePhone, string Phone, DateTime BirthOfDate, short Age, short Gender, string Address, string Email, string ImagePath)
        {

           Nullable <int>  PersonID = null;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_AddNewPerson", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

             
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@SecondName", SecondName);
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
                command.Parameters.AddWithValue("@LastName", LastName);
                if (HomePhone != "" && HomePhone != null)
                    command.Parameters.AddWithValue("@HomePhone", HomePhone);
                else
                    command.Parameters.AddWithValue("@HomePhone", System.DBNull.Value);
                command.Parameters.AddWithValue("@Phone", Phone);
                command.Parameters.AddWithValue("@BirthOfDate", BirthOfDate);
                command.Parameters.AddWithValue("@Age", Age);
                command.Parameters.AddWithValue("@Gender", Gender);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Email", Email);
                if (ImagePath != "" && ImagePath != null)
                    command.Parameters.AddWithValue("@ImagePath", ImagePath);
                else
                    command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


                connection.Open();
              
                object res=command.ExecuteScalar();
                if(res != null && int.TryParse(res.ToString(),out int insertedID)){
                    PersonID=insertedID;
                }
                return PersonID;
               

            }
           
        }


        public static bool UpdatePersonInfoByID(Nullable<int> PersonID,  string FirstName,  string SecondName, string ThirdName, string LastName
           , string HomePhone, string Phone,DateTime BirthOfDate, short Age,  short Gender, string Address,  string Email, string ImagePath)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_UpdatePersonByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@SecondName", SecondName);
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
                command.Parameters.AddWithValue("@LastName", LastName);
                if (HomePhone != "" && HomePhone != null)
                    command.Parameters.AddWithValue("@HomePhone", HomePhone);
                else
                    command.Parameters.AddWithValue("@HomePhone", System.DBNull.Value);
                command.Parameters.AddWithValue("@Phone", Phone);
                command.Parameters.AddWithValue("@BirthOfDate", BirthOfDate);                
                command.Parameters.AddWithValue("@Age", Age);
                command.Parameters.AddWithValue("@Gender", Gender);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Email", Email);
                if (ImagePath != "" && ImagePath != null)
                    command.Parameters.AddWithValue("@ImagePath", ImagePath);
                else
                    command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


                connection.Open();
              rowsAffected=command.ExecuteNonQuery();
               


            }
            return (rowsAffected > 0);
        }

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound=false;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_IsPersonExist", connection))
            {
               command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", PersonID);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    isFound=reader.HasRows;

                }

            }
            return isFound;
        }
    }
}
