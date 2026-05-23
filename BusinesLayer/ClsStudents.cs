
using System;
using System.Data;
using DataLayer;



namespace BusinesLayer
{
    public class ClsStudents
    {
        public enum EnMode { AddNew=0,Update=1 }
        EnMode Mode = EnMode.AddNew;


        public int ID { get; set; }
        public string FirtName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBrith { get; set; }
        public DateTime CreatedIt { get; set; }


        
        public ClsStudents()
        {
            this.ID = -1;
            this.FirtName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.Phone = "";
            this.Email = "";
            this.DateOfBrith = DateTime.Now;
            this.CreatedIt = DateTime.Now;
            Mode = EnMode.AddNew;
        }

        public ClsStudents(int id,string firtname,string secondname,string thirdname,string phone,string email,DateTime dateofbrith,
            DateTime creat)
        {
            this.ID = id;
            this.FirtName = firtname;
            this.SecondName = secondname;
            this.ThirdName = thirdname;
            this.Phone = phone;
            this.Email = email;
            this.DateOfBrith = dateofbrith;
            this.CreatedIt = creat;
            Mode = EnMode.Update;
        }




        private bool _AddnewStudent()
        {
            this.ID = StudentData.InsertNewStudent(this.FirtName, this.SecondName, this.ThirdName, this.Phone, this.Email, this.DateOfBrith, this.CreatedIt);
            return (this.ID !=-1);
        }

        private bool _UpdateStudent()
        {
            return StudentData.UpdateStudnets(this.ID, this.FirtName, this.SecondName, this.ThirdName, this.Phone, this.Email, this.DateOfBrith, this.CreatedIt);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:
                    if (_AddnewStudent())
                    {
                        return true;
                        Mode = EnMode.Update;
                        break;
                    }
                    else
                        return false;
                case EnMode.Update:
                    return _UpdateStudent();

            }
            return false;
        }




        public static DataTable GetAll()
        {
            return StudentData.GetAllStudent();
        }


        public static bool DeleteStudent(int Id)
        {
            return StudentData.deleteStudnet(Id);
        }
    }
}
