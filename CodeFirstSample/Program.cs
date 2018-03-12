using System;
using System.Linq;

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

                //var blog = new Blog { Name = name };
                //db.Blogs.Add(blog);
                //db.SaveChanges();

                // Display all Blogs from the database 
                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query.ToList())
                {
                    Console.WriteLine(item.Name);
                    foreach (var post in item.Posts)
                    {
                        Console.WriteLine($" - Post: {post.Title}");
                    }
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
