using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_management_software_webapi.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string RegisterationNo { get; set; }
        public string TestMarks { get; set; }
        public string InterviewMarks { get; set; }
        public string TotalMarks { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }


    }
}
