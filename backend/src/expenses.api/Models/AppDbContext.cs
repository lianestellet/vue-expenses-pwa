using Microsoft.EntityFrameworkCore;

namespace expenses.api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}