namespace MovieRazor.Services.Interface
{
    public interface ICustomLogger
    {
        void Log(string message);
        void Log(Exception exception);
    }
}
