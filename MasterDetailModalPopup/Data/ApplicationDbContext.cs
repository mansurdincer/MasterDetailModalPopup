using MasterDetailModalPopup.Models;
using Microsoft.EntityFrameworkCore;

namespace MasterDetailModalPopup.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Holding IT", Location = "Holding" },
                new Department { Id = 2, Name = "Dentaş IT", Location = "Dentaş" },
                new Department { Id = 3, Name = "Filidea IT", Location = "Filidea" }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Abdullah", Title = "Manager", Phone = "701", Email = "", DepartmentId = 1 },
                new Employee { Id = 2, Name = "Muhammer", Title = "Hardware Eng.", Phone = "702", Email = "", DepartmentId = 1 },
                new Employee { Id = 3, Name = "Mansur", Title = "Software Eng.", Phone = "703", Email = "", DepartmentId = 1 }

                );

        }


    }
}
