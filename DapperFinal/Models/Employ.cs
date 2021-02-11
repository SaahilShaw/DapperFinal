using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DapperFinal.Models
{
    public class Employ
    {
        [Required]
        public int Empno { get; set; }

        [Required]
        public string Nam { get; set; }

        [Required]
        public int basic { get; set; }

    }
}