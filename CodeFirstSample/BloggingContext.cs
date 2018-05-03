using Blogging;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirstSample
{
    public class BloggingContext : DbContext
    {
        public BloggingContext() : base("name=Blogging")
        {

        }

        protected override void OnModelCreating(DbModelBuilder model)
        {
            model.Configurations.Add(new BlogMappings());
            model.Configurations.Add(new PostMappings());
        }
    }

    public class BlogMappings : EntityTypeConfiguration<Blog>
    {
        public BlogMappings()
        {
            HasMany(b => b.Posts)
               .WithRequired()
               .HasForeignKey(p => p.BlogId);
        }
    }

    public class PostMappings : EntityTypeConfiguration<Post>
    {
        public PostMappings()
        {
            Property(x => x.BlogId);
        }
    }
}
