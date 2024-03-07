using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class DataContext : DbContext
    {
        public DbSet<User> DbUsers { get; set; }
        public DbSet<Module> DbModules { get; set; }
        public DbSet<Student> DbStudents { get; set; }
        public DbSet<Result> DbResult { get; set; }

        private readonly string _path = @"D:\Visual Studio\StudentManagementSystem\Database.db";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"DataSource = {_path}");
        }

    }
}
