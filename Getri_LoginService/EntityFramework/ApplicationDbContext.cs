using Getri_LoginService.Models;
using Microsoft.EntityFrameworkCore;

namespace Getri_LoginService.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        { 
        }

        public DbSet<User> Users { get; set; }
    }
}
