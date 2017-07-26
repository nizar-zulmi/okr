using Microsoft.EntityFrameworkCore;

namespace okr.Models.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<User> User  {get; set;}
    }
}