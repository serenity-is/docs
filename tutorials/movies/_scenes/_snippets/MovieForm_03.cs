namespace MovieTutorial.MovieDB.Forms;

[FormScript("MovieDB.Movie")]
[BasedOnRow(typeof(MovieRow), CheckNames = true)]
public class MovieForm
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Storyline { get; set; }
    public int? Year { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public int? Runtime { get; set; }
}
