using BlazorPOC.Data.Mapping;
using BlazorPOC.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace BlazorPOC.Data.Context
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser,ApplicationRole,int>
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
               base.OnModelCreating(modelBuilder);

        public DbSet<Book> Books { get; set; }
    }
}
