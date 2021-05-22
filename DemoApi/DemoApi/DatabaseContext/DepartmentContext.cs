using Microsoft.EntityFrameworkCore;
using DemoApi.Models;

namespace DemoApi.DatabaseContext
{
    public class DepartmentContext : DbContext
    {
        public DepartmentContext(DbContextOptions<DepartmentContext> options) : base(options)

        {
            
        }

        public DbSet<Department> Department { get; set; }

    }

}