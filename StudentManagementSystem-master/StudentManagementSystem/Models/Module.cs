using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class Module
    {
        [Key]
        public string ModuleID { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public int NoOfCreadits { get; set; }
    }
}
