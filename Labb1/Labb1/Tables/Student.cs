using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Labb1.Tables
{
    public class Student
    {
       
        [Key]
        public int StudentID { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public int StudentAge { get; set; }


    }
}