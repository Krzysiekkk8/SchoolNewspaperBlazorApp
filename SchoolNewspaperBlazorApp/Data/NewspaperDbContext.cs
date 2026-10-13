    using Microsoft.EntityFrameworkCore;

    namespace SchoolNewspaperBlazorApp.Data
    {
        public class NewspaperDbContext : DbContext
        {
            public NewspaperDbContext(DbContextOptions<NewspaperDbContext> options)
                : base(options) {}
            public DbSet<Article> Articles { get; set; }
            public DbSet<MediaFile> Files { get; set; }
        public object User { get; internal set; }

        protected override void OnModelCreating(ModelBuilder mb)
            {
            mb.Entity<MediaFile>()
                 .Property(x => x.Id)
                 .ValueGeneratedNever();
            }
        

        }
    }
