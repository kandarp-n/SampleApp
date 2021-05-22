using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoApi.Models;

namespace DemoApi.Data
{
    public class DemoApiContext : DbContext
    {
        public DemoApiContext (DbContextOptions<DemoApiContext> options)
            : base(options)
        {
        }

        public DbSet<DemoApi.Models.Department> Department { get; set; }

        public DbSet<DemoApi.Models.Employee> Employee { get; set; }
    }
}
