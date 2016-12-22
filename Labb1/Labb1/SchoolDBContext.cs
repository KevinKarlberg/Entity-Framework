using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using Labb1.Tables;

namespace Labb1
{
    public class SchoolDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Education> Educations { get; set; }
    }
}