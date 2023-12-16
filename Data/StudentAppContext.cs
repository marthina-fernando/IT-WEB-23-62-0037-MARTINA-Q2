using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentApp.Model;

namespace StudentApp.Data
{
    public class StudentAppContext : DbContext
    {
        public StudentAppContext (DbContextOptions<StudentAppContext> options)
            : base(options)
        {
        }

        public DbSet<StudentApp.Model.Students> Students { get; set; } = default!;
        public DbSet<StudentApp.Model.Courses> Courses { get; set; } = default!;
    }
}
