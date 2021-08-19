using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repo
{
    public interface IStudent_repo
    {
        void Add(object obj);
        void Update(object obj);
        Student GetUser(int Id);
        IEnumerable<Student> GetAllStudents();
        bool SaveChanges();
        void DeleteStudent(int Id);

    }
}
