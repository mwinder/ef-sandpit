using System.Collections.Generic;

namespace Blogging
{
    public class Blog
    {
        protected Blog() { } // EF
        public Blog(string name)
        {
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }

        internal virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
    }

    public class Post
    {
        private Post() { } // EF
        public Post(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public int Id { get; set; }
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
