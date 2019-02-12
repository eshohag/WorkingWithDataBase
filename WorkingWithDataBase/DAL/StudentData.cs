using System.Collections.Generic;
using System.Linq;
using WorkingWithDataBase.Model;

namespace WorkingWithDataBase.DAL
{
    class StudentData
    {
        private ApplicationDbContext db = null;
        public StudentData()
        {
            db = new ApplicationDbContext();

        }
        public List<Student> GetAll()
        {
            return db.Students.ToList();
        }
    }
}
