using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstNamE { get; set; }
        public string LastNamE{ get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string AdresS { get; set; }
        public string EmaiL { get; set; }
        public string PhoneNumbeR { get; set; }
    }
}
