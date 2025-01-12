using Authentication.Models;
using Microsoft.EntityFrameworkCore;

namespace Authentication.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {  }
        
        public DbSet<User> User { get; set; }
    }
}