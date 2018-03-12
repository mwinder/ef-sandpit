using System.Collections.Generic;

namespace CodeFirstSample
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }

        internal protected virtual ICollection<Post> Posts { get; set; }
    }

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }

}
