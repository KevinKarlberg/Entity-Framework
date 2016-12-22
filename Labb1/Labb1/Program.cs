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
    public class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolDBContext())
            {
                Student student = new Student() { StudentName = "New Student", StudentAge = 45 };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
        }
    }
}