using Blogging;
using System.Data.Entity;

namespace CodeFirstSample
{
    public class BloggingContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder model)
        {
            model.Entity<Blog>()
                .HasMany(b => b.Posts)
                .WithRequired()
                .HasForeignKey(p => p.BlogId);

            model.Entity<Post>();
        }
    }
}
