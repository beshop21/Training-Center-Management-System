using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class CoursesData
    {

        public static int InsertNewCourse(string title, int hourse, float price, DateTime startdate, bool isactive)
        {
            int CourseId = -1;

            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string query = @"insert into Courses (Title,Hourse,Price,StartDate,IsActive) 
                     VALUES (@Title,@Hourse,@Price,@StartDate,@IsActive);
                     SELECT SCOPE_IDENTITY();";

            SqlCommand comnd = new SqlCommand(query, connection);

            comnd.Parameters.AddWithValue("@Title", title);
            comnd.Parameters.AddWithValue("@Hourse", hourse);
            comnd.Parameters.AddWithValue("@Price", price);
            comnd.Parameters.AddWithValue("@StartDate", startdate);
            comnd.Parameters.AddWithValue("@IsActive", isactive);

            try
            {
                connection.Open();

                object result = comnd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    CourseId = ID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return CourseId;
        }

        public static bool UpdateCourse(int id, string title, int hours, float price, DateTime startdate, bool isactive)
        {
            int Effectnumber = -1;

            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string qeury = @"update Courses set 
                          Title=Title,
                          Hourse=Hourse,
                          Price=Price,
                          StartDate=StartDate,
                          IsActive=IsActive CourseID=CourseID";

            SqlCommand comnd = new SqlCommand(qeury, connection);

            comnd.Parameters.AddWithValue("@CourseID", id);
            comnd.Parameters.AddWithValue("@Title", title);
            comnd.Parameters.AddWithValue("@Hours", hours);
            comnd.Parameters.AddWithValue("@Price", price);
            comnd.Parameters.AddWithValue("@StartDate", startdate);
            comnd.Parameters.AddWithValue("@IsActive", isactive);

            try
            {
                connection.Open();

                Effectnumber = comnd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return (Effectnumber > 0);
        }


        public static bool DeleteCourse(int id)
        {
            int effectnumber = -1;
            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string query = "delete from Courses where CourseID=CourseID";
            SqlCommand commd = new SqlCommand(query, connection);
            commd.Parameters.AddWithValue("@StudentID", id);
            try
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return (effectnumber > 0);
        }


        public static bool GetCourseByname(string Title, ref int Hourse,
    ref float Price, ref DateTime StartDate, ref bool IsActive)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string qeury = "select * from Courses where Title=@Title";

            SqlCommand commd = new SqlCommand(qeury, connection);

            commd.Parameters.AddWithValue("@Title", Title);

            try
            {
                connection.Open();

                SqlDataReader reader = commd.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;

                    Hourse = (int)reader["Hourse"];
                    Price = Convert.ToSingle(reader["Price"]);
                    StartDate = (DateTime)reader["StartDate"];
                    IsActive = (bool)reader["IsActive"];
                }

                reader.Close();
            }
            catch (Exception ex)
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
