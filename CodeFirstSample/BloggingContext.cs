using System.Data.Entity;

namespace CodeFirstSample
{
    public class BloggingContext : DbContext
    {
        public BloggingContext()
        {
            Database.SetInitializer<BloggingContext>(null);
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
