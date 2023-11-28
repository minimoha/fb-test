using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using Test.API.Models;

namespace Test.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Industry> Industry { get; set; }
        public DbSet<CustomerOtherInfo> CustomerOtherInfo { get; set; }
    }
}
