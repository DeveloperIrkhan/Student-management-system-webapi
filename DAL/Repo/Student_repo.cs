using DAL.Models;
using DAL.Std_DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class Student_repo : IStudent_repo
    {
        private readonly Student_Context _context;

        public Student_repo(Student_Context context)
        {
            _context = context;
        }

        #region Add Student
        public async Task<Student> Add(Student student)
        {
            var model = new Student()
            {
                FirstName = student.FirstName,
                MiddleName = student.MiddleName,
                LastName = student.LastName,
                RegisterationNo = student.RegisterationNo,
                PhoneNo = student.PhoneNo,
                Address = student.Address,
                Department = student.Department

            };
            _context.Add(model);
            await _context.SaveChangesAsync();
            return model;
        } 
        #endregion

        #region Delete Student
        public async Task DeleteStudent(int Id)
        {
            var result = await _context.GetStudents.FindAsync(Id);
            if (result != null)
            {
                _context.Remove(result);
            }
        } 
        #endregion

        #region Get All Student Record
        public async Task<List<Student>> GetAllStudents()
        {
            var record = await _context.GetStudents
                                .Select(x => new Student()
                                {
                                    ID = x.ID,
                                    FirstName = x.FirstName,
                                    MiddleName = x.MiddleName,
                                    LastName = x.LastName,
                                    RegisterationNo = x.RegisterationNo,
                                    PhoneNo = x.PhoneNo,
                                    Address = x.Address,
                                    Department = x.Department
                                }).ToListAsync();

            return record;
        } 
        #endregion

        #region Get Student by Id
        public async Task<Student> GetStudent(int Id)
        {
            //var student =  _context.GetStudents.Find(Id);
            var student = await _context.GetStudents.Where(x => x.ID == Id)
                .Select(x => new Student()
                {
                    ID = x.ID,
                    FirstName = x.FirstName,
                    MiddleName = x.MiddleName,
                    LastName = x.LastName,
                    RegisterationNo = x.RegisterationNo,
                    PhoneNo = x.PhoneNo,
                    Address = x.Address,
                    Department = x.Department
                }).FirstOrDefaultAsync();
            return student;
        } 
        #endregion

        #region Save Chages
        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        #endregion

        #region Gerneric update
        public void Update(object obj)
        {
            _context.Update(obj);
        } 
        #endregion

        #region Update Student

        public async Task UpdateStudentAsync(int StudentId, Student student)
        {
            var record = await _context.GetStudents.FindAsync(StudentId);
            if (record != null)
            {
                record.FirstName = student.FirstName;
                record.MiddleName = student.MiddleName;
                record.LastName = student.LastName;
                record.RegisterationNo = student.RegisterationNo;
                record.PhoneNo = student.PhoneNo;
                record.Address = student.Address;
                record.Department = student.Department;
                await _context.SaveChangesAsync();
            }
        } 
        #endregion


    }
}
