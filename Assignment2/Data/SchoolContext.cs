using System;
using Microsoft.EntityFrameworkCore;
using Assignment3.Models;
namespace Assignment3.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<LearningOutcome> LearningOutcomes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("DBCourse");
            modelBuilder.Entity<LearningOutcome>().ToTable("DBLearningOutcome");
        }
    }
}
