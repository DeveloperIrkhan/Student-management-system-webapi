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

        [HttpGet]
        [Route("GetStudents")]
        public JsonResult GetStudents()
        {
            var result = _repo.GetAllStudents();
            return new JsonResult(result);
        }
        [HttpPost]
        [Route("Add")]
        public JsonResult AddStudents(Student student)
        {
            _repo.Add(student);
            _repo.SaveChanges();
            return new JsonResult(student);
        }
    }
}
