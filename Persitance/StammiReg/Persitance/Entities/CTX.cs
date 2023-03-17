using Microsoft.EntityFrameworkCore;

namespace Persitance.StammiReg.Persitance.Entities;

public class CTX
{
    public class BloggingContext : DbContext
    {
        public DbSet<Reg> Regs { get; set; }
        public DbSet<Meet> Meets { get; set; }

        public string DbPath { get; }

        public BloggingContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySQL();
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Meet>(entity =>
            {
                entity.HasKey(e => e.MeetID);
                entity.Property(e => e.MeetName).IsRequired();
            });

          //  modelBuilder.Entity<Book>(entity =>
           // {
          //      entity.HasKey(e => e.ISBN);
           //     entity.Property(e => e.Title).IsRequired();
            //    entity.HasOne(d => d.Publisher)
             //       .WithMany(p => p.Books);
           // });
        }
    }
}