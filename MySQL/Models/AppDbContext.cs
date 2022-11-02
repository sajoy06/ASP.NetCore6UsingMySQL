using Microsoft.EntityFrameworkCore;

namespace MySQL.Models
{
    public class AppDbContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Mark",
                    Department = Dept.HR.ToString(),
                    Email = "mark@pragimtech.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Arif",
                    Department = Dept.IT.ToString(),
                    Email = "Arif@pragimtech.com"
                }
            );

        }
    }
}
