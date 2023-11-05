using Microsoft.EntityFrameworkCore;
using webCrud.Models.Domain;

namespace webCrud.Data
{
    public class WebDbContext : DbContext
    {
        public WebDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
