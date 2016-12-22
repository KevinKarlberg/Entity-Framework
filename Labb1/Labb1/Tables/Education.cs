using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Labb1.Tables
{
    public class Education
    {
        [Key]
        public int EducationID { get; set; }
        [Required]
        public string EducationName { get; set; }
        [Required]
        public DateTime EducationStart { get; set; }
        [Required]
        public DateTime EducationEnd { get; set; }
    }
}