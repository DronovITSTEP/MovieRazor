using Microsoft.AspNetCore.Mvc.RazorPages;

using MovieRazor.Models;
using MovieRazor.Repositories.Interfaces;

namespace MovieRazor.Pages
{
    public class MoviesPageModel : PageModel
    {
        private readonly IMovieRepository _movieRepo;
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public MoviesPageModel(IMovieRepository movieRepo)
        {
            _movieRepo = movieRepo;
        }

        public void OnGet()
        {
            Movies = _movieRepo.GetAll();
        }
    }
}
