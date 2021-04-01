using Microsoft.EntityFrameworkCore;
using RecordBookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecordBookAPI.DataContext
{
    public class RecordBookContext: DbContext
    {
        public RecordBookContext(DbContextOptions options) : base(options)
        {
            if (!this.Database.CanConnect())
            {
                this.Database.Migrate();
            }
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<ExamType> Exam_Types { get; set; }
        public DbSet<ExamBook> Exam_Books { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
