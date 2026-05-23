
using Microsoft.Data.SqlClient;
using System;
using System.Data.Common;
using System.Runtime.InteropServices;



namespace DataLayer
{
    public class StudentData
    {

        public static int InsertNewStudent(string firstname,string secondname,string thirdname,string phone,string email,DateTime dateofbrith,DateTime createat)
        {
            int StudentId = -1;

            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);
            string qeury = @"insert into Students (FirstName,SecondName,ThirdName,phone,Email,DateoFBirth,CreatedAt) values(@FirstName,@SecondName,@ThirdName,@phone,@Email,@DateoFBirth,@CreatedAt);select SCOPE_IDENTITY();";

            SqlCommand comnd = new SqlCommand(qeury, connection);

            comnd.Parameters.AddWithValue("@FirstName", firstname);
            comnd.Parameters.AddWithValue("@SecondName", secondname);
            comnd.Parameters.AddWithValue("@ThirdName", thirdname);
            comnd.Parameters.AddWithValue("@phone", phone);
            comnd.Parameters.AddWithValue("@Email", email);
            comnd.Parameters.AddWithValue("@DateoFBirth", dateofbrith);
            comnd.Parameters.AddWithValue("@CreatedAt", createat);

            try
            {
                connection.Open();
                object result = comnd.ExecuteScalar();
                if(result!=null && int.TryParse(result.ToString(),out int ID))
                {
                    StudentId = ID;
                }




            }catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return StudentId;
        }

        public static bool UpdateStudnets(int id, string firstname, string secondname, string thirdname, string phone, string email, DateTime dateofbrith, DateTime createat)
        {
            int Effectnumber = -1;
            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);
            string qeury = @"update Students set 
                                    FirstName=@FirstName,
                                    SecondName=@SecondName,
                                    ThirdName=@ThirdName,
                                    phone=@phone,
                                    Email=@Email,
                                    DateoFBirth=@DateoFBirth,
                                    CreatedAt=@CreatedAt where StudentID=StudentID";

            SqlCommand comnd = new SqlCommand(qeury, connection);
            comnd.Parameters.AddWithValue("StudentID", id);
            comnd.Parameters.AddWithValue("@FirstName", firstname);
            comnd.Parameters.AddWithValue("@SecondName", secondname);
            comnd.Parameters.AddWithValue("@ThirdName", thirdname);
            comnd.Parameters.AddWithValue("@phone", phone);
            comnd.Parameters.AddWithValue("@Email", email);
            comnd.Parameters.AddWithValue("@DateoFBirth", dateofbrith);
            comnd.Parameters.AddWithValue("@CreatedAt", createat);

            try
            {
                connection.Open();
                Effectnumber = comnd.ExecuteNonQuery();



            }catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (Effectnumber > 0);

        }

        public static bool deleteStudnet(int ID)
        {
            int effectnumber = -1;
            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string query = "delete from Students where StudentID=@StudentID";
            SqlCommand commd = new SqlCommand(query, connection);
            commd.Parameters.AddWithValue("@StudentID", ID);
            try
            {

            }catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return (effectnumber > 0);
        }

        public static bool GetStudentByID(int ID, ref string firstname,ref string secondname,ref string thirdname,ref string phone, string email, DateTime dateofbrith, DateTime createat)
        {

            bool isfound = false;

            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string qeury = "select * from Students where StudentID=@StudentID";


            SqlCommand commd = new SqlCommand(qeury, connection);

            commd.Parameters.AddWithValue("@StudentID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = commd.ExecuteReader();
                {
                    isfound = true;
                    firstname = (string)reader["@FirstName"];
                    secondname = (string)reader["@SecondName"];
                    thirdname = (string)reader["@ThirdName"];
                    phone = (string)reader["@phone"];
                    email = (string)reader["@Email"];
                    dateofbrith = (DateTime)reader[" @DateoFBirth"];
                    createat = (DateTime)reader["@CreatedAt"];
                  
                }
            }catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();

            }
            return isfound;
        }
    }
}
