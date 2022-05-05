using Microsoft.EntityFrameworkCore;
using StudentRegister.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegister.Models.Context
{
    public class LessonAssignmentContext : DbContext
    {
        public LessonAssignmentContext(DbContextOptions<LessonAssignmentContext> options) : base(options)
        {

        }

        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<StudentLesson> StudentLesson { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:StudentConnection");
            }
        }
    }
}
