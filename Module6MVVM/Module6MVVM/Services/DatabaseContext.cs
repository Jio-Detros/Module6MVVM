using System;
using System.Collections.Generic;
using System.Text;
using Module6MVVM.Model;

using Microsoft.EntityFrameworkCore;
using System.IO;


namespace Module6MVVM.Services
{
    public class DatabaseContext:DbContext
    {
        public DbSet<EmployeeModel> Employees { get; set; }

        public DatabaseContext() 
        { 
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Employee.db");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}
