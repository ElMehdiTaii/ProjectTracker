using Microsoft.EntityFrameworkCore;
using ProjectTracker.Entities.Models;

namespace ProjectTracker.Entities.DBContext
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) { }
        public DbSet<Boards> Boards { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Companies> Companies { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
    }
}
