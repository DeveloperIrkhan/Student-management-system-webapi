using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public interface IStudent_repo
    {
        Task<Student> Add(Student student);
        void Update(object obj);
        Task UpdateStudentAsync(int StudentId, Student student);
        public Task<Student> GetStudent(int Id);
        public Task<List<Student>> GetAllStudents();
        bool SaveChanges();
        void DeleteStudent(int Id);

    }
}
