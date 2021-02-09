using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DapperFinal.Models
{
    public class StudentSub
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Subject_name { get; set; }
    }
}