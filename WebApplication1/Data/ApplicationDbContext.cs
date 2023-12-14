using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder
                .Entity<NoteList>()
                .HasMany(n => n.Notes)
                .WithOne(l => l.NoteList)
                .OnDelete(DeleteBehavior.NoAction);

                base.OnModelCreating(builder);
        }

        public DbSet<WebApplication1.Data.NoteList>? NoteList { get; set; }
        public DbSet<WebApplication1.Data.Note>? Note { get; set; }
    }
}
