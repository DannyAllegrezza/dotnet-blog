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

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
