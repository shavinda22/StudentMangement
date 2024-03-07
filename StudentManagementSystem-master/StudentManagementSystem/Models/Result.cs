using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class Result
    {
        [Key]
        public int Id { get; set; }
        public int Studentid { get; set; }
        public string EE3305 { get; set; }
        public string EE3302 { get; set; }
        public string EE3301 { get; set; }
        public string IS3307 { get; set; }
        public string EE3250 { get; set; }
        public string IS3302 { get; set; }
        public string EE3203 { get; set; }
        public string EE3251 { get; set; }
    }
}
