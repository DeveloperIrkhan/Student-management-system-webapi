using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    [Table("Student_Tbl")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }
        
        [Required]
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }
        
        
        [JsonProperty(PropertyName = "middleName")]
        public string MiddleName { get; set; }
        
        
        [Required]
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }
        
        
        [Required]
        [JsonProperty(PropertyName = "registerationNo")]
        public string RegisterationNo { get; set; }
        
        
        [Required]
        [JsonProperty(PropertyName = "phoneNo")]
        public string PhoneNo { get; set; }
        
        
        [Required]
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }
        
        
        [Required]
        [JsonProperty(PropertyName = "department")]
        public string Department { get; set; }
    }
}
