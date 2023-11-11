using Microsoft.EntityFrameworkCore;
using RazorPageMovie.Data;

namespace RazorPageMovie.Models
{
    public static class SeedData
    {
        public static void Inizialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPageMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPageMovieContext>>())) 
            {
                //En caso de contexto nulo, se envia un mensaje de error

                if (context == null || context.Movie == null) 
                { 
                throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                if (context.Movie.Any())
                {
                    //Base de datos muestra todo lo que contiene esta clase
                    return;
                }

                //Es donde se va a carga toda la informacion de los datos de las peliculas 
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry meet Sally",
                        RealeseDate = DateTime.Parse("1989-02-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99

                    },

                    new Movie
                    {
                        Title = "Ghostbusters",
                        RealeseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99

                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        RealeseDate = DateTime.Parse("1989-2-23"),
                        Genre = "Comedy",
                        Price = 9.99

                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        RealeseDate = DateTime.Parse("1954-4-15"),
                        Genre = "Western",
                        Price = 3.99

                    }


                );
                context.SaveChanges();
            }
        }

    }
}
