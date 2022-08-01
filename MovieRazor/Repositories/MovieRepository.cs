using MovieRazor.Repositories.Interfaces;
using MovieRazor.Services.Interface;
using MovieRazor.Models;

namespace MovieRazor.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ICustomLogger _logger;

        public MovieRepository (ICustomLogger logger)
        {
            _logger = logger;
        }

        public List<Movie> GetAll()
        {
            return new List<Movie>()
                {
                    new Movie()
                    {
                        Id = 1,
                        Title = "Avatar",
                        ReleaseDate = new DateOnly(2017, 12, 31),
                        RuntimeMinute = 365,
                        Director = "J. Cemeron"
                    },
                    new Movie()
                    {
                        Id = 2,
                        Title = "Matrix",
                        ReleaseDate = new DateOnly(2000, 02, 15),
                        RuntimeMinute = 244,
                        Director = "Br. Vachevsky"
                    },
                    new Movie()
                    {
                        Id = 3,
                        Title = "Titanik",
                        ReleaseDate = new DateOnly(2015, 06, 06),
                        RuntimeMinute = 124,
                        Director = "J. Cemeron"
                    },
                    new Movie()
                    {
                        Id = 4,
                        Title = "Jhon Wick",
                        ReleaseDate = new DateOnly(2020, 01, 11),
                        RuntimeMinute = 200,
                        Director = "Anyway"
                    },
                    new Movie()
                    {
                        Id = 5,
                        Title = "Левый фильм",
                        ReleaseDate = new DateOnly(2022, 2, 22),
                        RuntimeMinute = 222,
                        Director = "Правый режиссер"
                    }

                };
        }

        public Movie GetById(int id)
        {
            var allMovies = GetAll();
            return allMovies.First(x=>x.Id == id);
        }
    }
}
