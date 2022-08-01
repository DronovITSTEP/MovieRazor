namespace MovieRazor.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public int RuntimeMinute { get; set; }
        public string Director { get; set; }
    }
}
