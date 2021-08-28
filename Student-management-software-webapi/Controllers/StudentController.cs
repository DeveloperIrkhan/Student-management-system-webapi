using DAL.Models;
using DAL.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Student_management_software_webapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_management_software_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudent_repo _repo;

        public StudentController(IStudent_repo repo)
        {
            _repo = repo;
        }

        #region Get All Students
        [HttpGet]
        [Route("Students")]
        public JsonResult Students()
        {
            var result = _repo.GetAllStudents();
            return new JsonResult(result);
        }
        [HttpGet]
        [Route("GetStudents")]
        public async Task<IActionResult> GetStudents()
        {
            var result = await _repo.GetAllStudents();
            return Ok(result);
        }
        #endregion

        #region Add Student
        [HttpPost]
        [Route("AddStudent")]
        public async Task<IActionResult> AddStudents(StudentModels student)
        {
            var model = new Student()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                MiddleName = student.MiddleName,
                RegisterationNo = student.RegisterationNo,
                Address = student.Address,
                PhoneNo = student.PhoneNo,
                Department = student.Department
            };
            await _repo.Add(model);
            return Ok();
        }
        #endregion

        #region Delete Student
        [HttpDelete]
        [Route("DeleteStudent/{Id}")]
        public async Task<IActionResult> DeleteStudent(int Id)
        {
            await _repo.DeleteStudent(Id);
            _repo.SaveChanges();
            return Ok();
        }

        #endregion

        #region Get Student by Id
        [HttpGet]
        [Route("GetStudent/{Id}")]
        public async Task<IActionResult> GetStudent(int Id)
        {
            var student = await _repo.GetStudent(Id);
            //try
            //{
            //    var model = new StudentModels()
            //    {
            //        FirstName = student.FirstName,
            //        LastName = student.LastName,
            //        MiddleName = student.MiddleName,
            //        RegisterationNo = student.RegisterationNo,
            //        Address = student.Address,
            //        PhoneNo = student.PhoneNo,
            //        Department = student.Department
            //    };
            //}
            //catch (Exception exp)
            //{
            //    throw new Exception(exp + "no record found");
            //}
            if (student != null)
            {
                return Ok(student);
            }
            return NotFound();
        }
        #endregion

        #region Update Existing Student
        [HttpPut]
        [Route("UpdateStudent/{Id}")]
        public async Task<IActionResult> UpdateStudent(int Id,StudentModels studentModels)
        {
            var student = new Student
            {
                
                FirstName = studentModels.FirstName,
                MiddleName = studentModels.MiddleName,
                LastName = studentModels.LastName,
                RegisterationNo = studentModels.RegisterationNo,
                Department = studentModels.Department,
                Address = studentModels.Address,
                PhoneNo = studentModels.PhoneNo
            };
            await _repo.UpdateStudentAsync(Id, student);
            return Ok();
        }
        #endregion
    } 
}
