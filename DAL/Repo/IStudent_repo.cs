using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repo
{
    public interface IStudent_repo
    {
        void Add(object obj);
        void update(object obj);
        Students GetUser(int Id);
        IEnumerable<Students> GetAllStudents();
        bool saveChanges();
        void deleteStudent(int Id);

    }
}
