namespace MovieTutorial.MovieDB;

[EnumKey("MovieDB.MovieKind")]
public enum MovieKind
{
    [DescriptionText("Film")]
    Film = 1,
    [DescriptionText("TV Series")]
    TvSeries = 2,
    [DescriptionText("Mini Series")]
    MiniSeries = 3
}
