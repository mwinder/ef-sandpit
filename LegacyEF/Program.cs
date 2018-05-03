using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyEF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create();

            using (var db = new HolidaysContext())
            {
                var item = db.Set<HolidayRequest>().Find(new Guid("8419E33E-4210-40AA-AA9C-A33F7B44A4F7"));

                item.Approve();

                db.SaveChanges();
            }
        }

        private static void Create()
        {
            using (var db = new HolidaysContext())
            {
                db.Set<HolidayRequest>().Add(new HolidayRequest()
                {
                    Id = Guid.NewGuid(),
                    Date = new DateTime(2018, 3, 16),
                    Notes = "Me day",
                });

                db.SaveChanges();
            }
        }
    }

    public class HolidaysContext : DbContext
    {
        public HolidaysContext() : base("name=Holidays") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HolidayRequest>();
        }
    }
}
