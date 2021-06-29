using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Student_Management.Business;

namespace Student_Management.Data
{
    public class Student_ManagementContext : DbContext
    {
        public Student_ManagementContext (DbContextOptions<Student_ManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Student_Management.Business.Course_Details> Course_Details { get; set; }

        public DbSet<Student_Management.Business.Student_Details> Student_Details { get; set; }

        public DbSet<Student_Management.Business.Tutor_Details> Tutor_Details { get; set; }

        public DbSet<Student_Management.Business.Student_Enrollment> Student_Enrollment { get; set; }
    }
}
