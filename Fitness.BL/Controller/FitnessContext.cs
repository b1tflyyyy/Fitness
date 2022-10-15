using Fitness.BL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System;

namespace Fitness.BL.Controller
{
    public class FitnessContext : DbContext
    {
        public DbSet<Activity> Activities { get; set; }

        public DbSet<Eating> Eatings { get; set; }

        public DbSet<Exercise> Exercises { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Gender> Genders { get; set; }

        public DbSet<User> Users { get; set; }

        public FitnessContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=fitness.db");
        }
    }
}
