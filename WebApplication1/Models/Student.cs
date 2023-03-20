using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string name { get; set; }
        public DateTime DOB { get; set; }

    }
    public class StudentDBContext : DbContext 
    {
    public DbSet<Student> Students { set; get; }
    }
}