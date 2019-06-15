using MVC_Core_test.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Core_test.Models
{
    public class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Pies.Any())
            {
                context.AddRange
                    (
                          new Pie { Name = "Apple pie", Price = 3.50M, LongDescription = "nothing", ShortDescription = "nothing much", ImageUrl = "#", ImageThumbnailUrl = "#", IsPieOfTheWeek = true },
                          new Pie { Name = "Pear pie", Price = 7M, LongDescription = "nothing", ShortDescription = "nothing much", ImageUrl = "#", ImageThumbnailUrl = "#", IsPieOfTheWeek = true },
                          new Pie { Name = "Kiwi pie", Price = 1.20M, LongDescription = "nothing", ShortDescription = "nothing much", ImageUrl = "#", ImageThumbnailUrl = "#", IsPieOfTheWeek = true }
                    );

                context.SaveChanges();
            }
        }
    }
}
