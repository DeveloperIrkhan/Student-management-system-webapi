using DAL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student_management_software_webapi.Models
{
    public class StudentModels
    {
        
        [JsonProperty(PropertyName = "FirstName")]
        [Required]
        public string FirstName { get; set; }
        
        [JsonProperty(PropertyName = "MiddleName")]
        public string MiddleName { get; set; }
        
        [JsonProperty(PropertyName = "LastName")]
        [Required] 
        public string LastName { get; set; }
        
        [JsonProperty(PropertyName = "RegisterationNo")]
        [Required] 
        public string RegisterationNo { get; set; }
        
        [JsonProperty(PropertyName = "PhoneNo")]
        [Required] 
        public string PhoneNo { get; set; }
        
        [JsonProperty(PropertyName = "Address")]
        [Required]
        public string Address { get; set; }
        
        [JsonProperty(PropertyName = "Department")]
        [Required] 
        public Department Department { get; set; }
    }
}
