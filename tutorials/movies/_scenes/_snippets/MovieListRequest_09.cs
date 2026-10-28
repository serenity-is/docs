namespace MovieTutorial.MovieDB;

public class MovieListRequest : ListRequest
{
    public List<int>? Genres { get; set; }
}
