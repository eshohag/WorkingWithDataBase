using WorkingWithDataBase.Model;

namespace WorkingWithDataBase.DAL
{
    class StudentDalSave
    {
        private ApplicationDbContext db = null;
        public StudentDalSave()
        {
            db = new ApplicationDbContext();

        }
        public int Save(Student aStudent)
        {
            db.Students.Add(aStudent);
            return db.SaveChanges();
        }
    }
}
