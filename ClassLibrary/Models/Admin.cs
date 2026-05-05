using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Admin
    {
        [Key]
        public int AdmId { get; set; }
        [Required]
        public string AdmUserName { get; set; }
        [Required]
        public string AdmPassword { get; set;}
    }
}
