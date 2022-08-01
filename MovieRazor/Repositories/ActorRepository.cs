using MovieRazor.Repositories.Interfaces; 

namespace MovieRazor.Repositories
{
    public class ActorRepository : IActorRepository
    {
        // InvalidOperationException
        private readonly IMovieRepository _movieRepository;
        public ActorRepository(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
    }
}
