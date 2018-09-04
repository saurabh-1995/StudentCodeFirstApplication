namespace StudentCodeFirstApplication
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StudentDBContext : DbContext
    {
        
        public StudentDBContext()
            : base("name=StudentDBContext")
        {

        }

        public DbSet<Courses> Course
        {
            get; set;
        }
        public DbSet<Students> Student
        {
            get; set;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
