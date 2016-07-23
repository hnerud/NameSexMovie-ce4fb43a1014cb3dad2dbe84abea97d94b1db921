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
                        name = "Heidi Nerud",
                        gender = "Female",
                        movie = "Princess Bride",
                        book = "The Moon is a Harsh Mistress",
                        music = "Black Sabbath",
                        food = "Guacomole and Margaritas",
                        age = 41

                    },
                    new Information
                    {
                        name = "Timothy Nerud",
                        gender = "Male",
                        movie = "Star Wars Episode IV",
                        book = "Temple of Elemental Evil",
                        music = "Judas Priest",
                        food= "pizza",
                        age = 45

                    },
                   new Information
                   {
                       name = "Sarah Nerud",
                       gender = "Female",
                       movie = "The Hobbit",
                       book="Lunar Chronicles",
                       music = "Blackmore's Knight",
                       food = "seafood",
                       age = 13
                   },

                   new Information
                   {
                       name = "Katrina Nerud",
                       gender = "Female",
                       movie = "Godzilla",
                       book= "Raindrop Plop",
                       music = "Blackmore's Knight",
                       food = "Grilled Cheese",
                       age = 5

                   },

                   new Information
                   {
                       name = "Nicole Nerud",
                       gender = "Female",
                       movie = "Chronicles of Narnia",
                       book = "Kane Chronicles",
                       music = "Enya",
                       food = "Mushroom Swiss Burger",
                       age = 10

                   }


                    );
                context.SaveChanges();
            }
        }
    }
}

