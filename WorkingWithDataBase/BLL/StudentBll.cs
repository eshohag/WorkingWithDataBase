using System.Collections.Generic;
using WorkingWithDataBase.DAL;
using WorkingWithDataBase.Model;

namespace WorkingWithDataBase.BLL
{
    class StudentBll
    {
        public List<Student> GetMoreThenOneStudent()
        {
            StudentData aStudentData = new StudentData();

            if (aStudentData.GetAll().Count > 1)
            {
                return aStudentData.GetAll();
            }

            return null;
        }
    }
}