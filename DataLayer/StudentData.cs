
using System;
using Microsoft.Data.SqlClient;



namespace DataLayer
{
    public class StudentData
    {

        public static int InsertNewStudent(string firstname,string secondname,string thirdname,string phone,string email,DateTime dateofbrith,DateTime createat)
        {
            int StudentId = -1;

            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

        }






    }
}
