using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Movie4Free.Data;
using System;
using System.Linq;


namespace Movie4Free.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context =  new Movie4FreeContext (
            serviceProvider.GetRequiredService<
                DbContextOptions<Movie4FreeContext>>()))
        {
            if (context.Movie.Any())
            {
                return;
            }

            context.Movie.AddRange (
                new Movie
                {
                    Title="When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy"
                },
                
                new Movie
                {
                    Title = " Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy"
                },
                
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy"
                },
                
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse ("1959-4-15"),
                    Genre = "Western"
                });

            context.SaveChanges();
        }
    }
}
