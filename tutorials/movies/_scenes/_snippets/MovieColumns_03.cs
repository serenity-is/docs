namespace MovieTutorial.MovieDB.Columns;

[ColumnsScript("MovieDB.Movie")]
[BasedOnRow(typeof(MovieRow), CheckNames = true)]
public class MovieColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int? MovieId { get; set; }
    [EditLink]
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Storyline { get; set; }
    public int? Year { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public int? Runtime { get; set; }
}
