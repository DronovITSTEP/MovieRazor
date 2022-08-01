using MovieRazor.Repositories;
using MovieRazor.Repositories.Interfaces;

namespace MovieRazor.Extensions
{
    public static class ServiceExtention
    {
        public static void RegisterRepos
            (this IServiceCollection collection)
        {
            collection.AddTransient<IMovieRepository, MovieRepository>();
            // добавление других репозиториев
        }

        public static void RegisterLogging (this IServiceCollection collection)
        {
            // регистрация логгирования
        }

        public static void RegisterAuth (this IServiceCollection collection)
        {
            // регистрация сервисов аутентификации
        }
    }
}
