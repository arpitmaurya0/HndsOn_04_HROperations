using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        public string EmpName { get; set; }
        [Required]
        [EmailAddress]
        public string EmpEmail { get; set; }
        [Required]
        public string Empdept { get; set; }
        [Required]
        public string EmpContact { get; set; }
    }
}
