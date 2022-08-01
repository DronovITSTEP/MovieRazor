using MovieRazor.Services.Interface;

namespace MovieRazor.Services
{
    public class CustomLogger : ICustomLogger
    {
        public void Log(string message)
        {
            throw new NotImplementedException();
        }

        public void Log(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}
