using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Director = "Alin",
                        Description = "It is about a romantic couple"
                        
                    },
                  
                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                         Director = "Mihaela",
                        Description = "A comedy with ghosts"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Director = "Mihaela",
                        Description = "The next part of the first"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Director = "Alex",
                        Description = "It has horses"
                    },
                     new Movie
                     {
                         Title = "Matrix",
                         ReleaseDate = DateTime.Parse("1999-9-10"),
                         Genre = "Action, Sci-Fi",
                         Price = 6.99M,
                         Director = "Simona",
                         Description = "With piu-piu"
                     },

                    new Movie
                    {
                        Title = "The Shawshank Redemption",
                        ReleaseDate = DateTime.Parse("1994-10-14"),
                        Genre = "Drama",
                        Price = 5.99M,
                        Director = "Mihai",
                        Description = "It's a drama queen"
                    },

                    new Movie
                    {
                        Title = "The Dark Knight",
                        ReleaseDate = DateTime.Parse("2008-6-25"),
                        Genre = "Action,Crime,Drama",
                        Price = 8.99M,
                        Director = "Claudiu",
                        Description = "It's Batman"
                    },

                    new Movie
                    {
                        Title = "Inception",
                        ReleaseDate = DateTime.Parse("2010-7-30"),
                        Genre = "Action,Adventure, Sci-Fi",
                        Price = 4.99M,
                        Director = "Alina",
                        Description = "It's interesting"
                    }

                   

                );
                context.SaveChanges();
            }
        }
    }
}