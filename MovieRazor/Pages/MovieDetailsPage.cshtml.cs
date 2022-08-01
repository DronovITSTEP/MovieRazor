using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using MovieRazor.Repositories.Interfaces;
using MovieRazor.Services.Interface;
using MovieRazor.Models;

namespace MovieRazor.Pages
{
    public class MovieDetailsPageModel : PageModel
    {
        private readonly IMovieRepository _movieRepo;
        private readonly ICustomLogger _logger;

        public Movie Movie = new();
      
        public MovieDetailsPageModel(IMovieRepository movieRepo,
            ICustomLogger logger)
        {
            _movieRepo = movieRepo;
            _logger = logger;
        }

        public void OnGet(int id)
        {
            Movie = _movieRepo.GetById(id);
            _logger.Log("GET action field!");
        }

        public void OnPost()
        {
            _logger.Log("POST action field!");
        }
    }
}
