using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SamsonBookStore.Data;
using System;
using System.Linq;

namespace SamsonBookStore.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SamsonBookStoreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SamsonBookStoreContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "Pro ASP.NET Core MVC 2",
                        Author = "Freeman, Adam",
                        ReleaseDate = DateTime.Parse("2017-10-25"),
                        Genre = "Web Application",
                        Price = 48.83M,
                        Page = 1011
                    },

                    new Book
                    {
                        Title = "Programming Razor: Tools for Templates in ASP.NET MVC or WebMatrix",
                        Author = "Jess Chadwick",
                        ReleaseDate = DateTime.Parse("2011-9-25"),
                        Genre = "Web Application",
                        Price = 12.3M,
                        Page = 118
                    },

                    new Book
                    {
                        Title = "ASP.NET Core 2 and Angular 5: Full-Stack Web Development with .NET Core and Angular",
                        Author = "Valerio De Sanctis",
                        ReleaseDate = DateTime.Parse("2017-11-24"),
                        Genre = "Web Application",
                        Price = 68.75M,
                        Page = 550
                    },

                    new Book
                    {
                        Title = "iOS Development with Swift",
                        Author = "Apple Education",
                        ReleaseDate = DateTime.Parse("2017-12-1"),
                        Genre = "Mobile Application",
                        Price = 47.86M,
                        Page = 1024
                    }
                );
                context.SaveChanges();
            }
        }

    }
}
