using StudentManagement.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentManagement
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }

    }
}
