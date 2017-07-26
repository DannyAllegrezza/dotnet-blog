using dannyallegrezza.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace dannyallegrezza.DAL
{
    public class BlogDbContext : DbContext
    {
        /// <summary>
        /// Optional constructor, used to pass in BlogDbContext options (such as connection strings) via dependency injection
        /// </summary>
        /// <param name="options"></param>
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            : base(options) { }

        public BlogDbContext()
        {

        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql("User ID=postgres;Password=D@nny336!;Host=localhost;Port=5432;Database=dannyallegrezzaBlog;Pooling=False;CommandTimeout=0;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<PostTag>()
                .HasKey(t => new { t.PostId, t.TagId });

            builder.Entity<PostTag>()
                .HasOne(pt => pt.Post)
                .WithMany(p => p.PostTags)
                .HasForeignKey(pt => pt.PostId);

            builder.Entity<PostTag>()
                .HasOne(pt => pt.Tag)
                .WithMany(t => t.PostTags)
                .HasForeignKey(pt => pt.TagId);
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
