using System;
using System.Linq;
using System.Data.Entity;
using Blogging;

namespace CodeFirstSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                // Create and save a new Blog 
                //Console.Write("Enter a name for a new Blog: ");
                //var name = Console.ReadLine();

                //var blog = new Blog(name);
                //db.Set<Blog>().Add(blog);
                //db.SaveChanges();

                //Display all Blogs from the database
                //var query = from b in db.Set<Blog>()//.Include(x => x.Posts)
                //            orderby b.Name
                //            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in db.Set<Blog>())
                {
                    Console.WriteLine(item.Name);
                    foreach (var post in item.Posts)
                    {
                        Console.WriteLine($" - Post: {post.Title}");
                    }
                }

                //var ret = db.Set<Blog>().Find(1);
                //ret.Posts.Add(new Post("Hello world!", "This is my first post"));
                //db.SaveChanges();

                //Console.WriteLine("Press any key to exit...");
                //Console.ReadKey();
            }
        }
    }
}
