using System;
using WorkingWithDataBase.DAL;
using WorkingWithDataBase.Model;

namespace WorkingWithDataBase.BLL
{
    class StudentSave
    {
        public int Save(Student aStudent)
        {
            StudentDalSave aDalSave = new StudentDalSave();
            if (String.IsNullOrEmpty(aStudent.Name) || String.IsNullOrEmpty(aStudent.ContactNo))
            {
                return 0;
            }
            return aDalSave.Save(aStudent);

        }
    }
}
