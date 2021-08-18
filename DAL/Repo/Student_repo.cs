using DAL.Models;
using DAL.Std_DbContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repo
{
    public class Student_repo : IStudent_repo
    {
        private readonly Student_Context _context;

        public Student_repo(Student_Context context)
        {
            _context = context;
        }
        public void Add(object obj)
        {
            _context.Add(obj);
        }

        public void deleteStudent(int Id)
        {
            var result = _context.GetStudents.Find(Id);
            if (result != null)
            {
                _context.Remove(Id);
            }
        }

        public IEnumerable<Students> GetAllStudents()
        {
            return _context.GetStudents;
        }

        public Students GetUser(int Id)
        {
            var student =  _context.GetStudents.Find(Id);
            return student;
        }

        public bool saveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public void update(object obj)
        {
            _context.Update(obj);
        }
    }
}
