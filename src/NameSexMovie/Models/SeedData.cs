using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NameSexMovie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NameSexMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Information.Any())
                {
                    return;
                }
                context.Information.AddRange(
                    new Information
                    {
                        ID = 1,
                        name = "Heidi Nerud",
                        gender = "Female",
                        movie = "Princess Bride"

                    },
                    new Information
                    {
                        ID = 2,
                        name = "Timothy Nerud",
                        gender = "Male",
                        movie = "Star Wars Episode IV"

                    },
                   new Information
                   {
                       ID = 3,
                       name = "Sarah Nerud",
                       gender = "Female",
                       movie = "The Hobbit"
                   },

                   new Information
                   {
                       ID = 4,
                       name = "Katrina Nerud",
                       gender = "Female",
                       movie = "Godzilla"

                   },

                   new Information
                   {
                       ID = 5,
                       name = "Nicole Nerud",
                       gender = "Female",
                       movie = "Chronicles of Narnia"

                   }


                    );
                context.SaveChanges();
            }
        }
    }
}

