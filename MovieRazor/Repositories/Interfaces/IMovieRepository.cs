using MovieRazor.Models;

namespace MovieRazor.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
        Movie GetById (int id);
    }
}
