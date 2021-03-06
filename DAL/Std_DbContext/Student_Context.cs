using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Std_DbContext
{
    public class Student_Context:DbContext
    {
        public Student_Context(DbContextOptions<Student_Context> options)
        :base(options)
        {

        }
        public DbSet<Student> GetStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Student>().ToTable("Student_Tbl");
        }
    }
}
