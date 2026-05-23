using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinesLayer
{
    public class ClsCourses
    {
        public enum EnMode { AddNew=0, Update=1}
        EnMode Mode = EnMode.AddNew;

        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Hourse { get; set; }
        public float Price { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }


        public ClsCourses()
        {
            this.CourseID = -1;
            this.Title = "";
            this.Hourse = -1;
            this.Price = -1;
            this.StartDate = DateTime.Now;
            this.IsActive = false;

            Mode = EnMode.AddNew;


        }

        public ClsCourses(int id,string title,int hourse,float price,DateTime startdate,bool isactive)
        {
            this.CourseID = id;
            this.Title = title;
            this.Hourse = hourse;
            this.Price = price;
            this.StartDate = startdate;
            this.IsActive = isactive;
            Mode = EnMode.Update;
        }


        private bool _AddnewCourse()
        {
            this.CourseID = CoursesData.InsertNewCourse(this.Title, this.Hourse, this.Price, this.StartDate, this.IsActive);
            return (this.CourseID != -1);
        }

        private bool _updateCourses()
        {
            return CoursesData.UpdateCourse(this.CourseID, this.Title, this.Hourse, this.Price, this.StartDate, this.IsActive);

        }


        public  bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:
                    if (_AddnewCourse())
                    {
                        Mode = EnMode.Update;
                        return true;
                        break;
                    }
                    else
                        return false;


                case EnMode.Update:
                    return _updateCourses();
            }
            return false;
        }




        public static bool Delete(int id)
        {
            return CoursesData.DeleteCourse(id);
        }

        

    }
}
