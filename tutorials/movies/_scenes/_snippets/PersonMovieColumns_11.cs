namespace MovieTutorial.MovieDB.Columns;

[ColumnsScript]
[BasedOnRow(typeof(MovieCastRow))]
public class PersonMovieColumns
{
    [Width(220)]
    public string? MovieTitle { get; set; }
    [Width(200)]
    public string? Character { get; set; }
}
