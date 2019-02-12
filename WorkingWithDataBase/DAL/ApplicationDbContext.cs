using System.Data.Entity;
using WorkingWithDataBase.Model;

namespace WorkingWithDataBase.DAL
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("WindowsFormsDb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
    }
}
