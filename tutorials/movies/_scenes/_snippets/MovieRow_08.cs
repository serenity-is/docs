namespace MovieTutorial.MovieDB;

[ConnectionKey("Default"), Module("MovieDB"), TableName("Movie")]
[DisplayText("Movies"), InstanceName("Movie")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class MovieRow : Row<MovieRow.RowFields>, IIdRow, INameRow
{
    const string jGenre = nameof(jGenre);

    [DisplayText("Movie Id"), Identity, IdProperty]
    public int? MovieId { get => fields.MovieId[this]; set => fields.MovieId[this] = value; }

    [DisplayText("Title"), NotNull, QuickSearch, NameProperty]
    public string? Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayText("Description"), Size(1000), QuickSearch]
    public string? Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayText("Storyline"), QuickSearch]
    public string? Storyline { get => fields.Storyline[this]; set => fields.Storyline[this] = value; }

    [DisplayText("Year"), QuickSearch(SearchType.Equals, numericOnly: 1)]
    public int? Year { get => fields.Year[this]; set => fields.Year[this] = value; }

    [DisplayText("Release Date")]
    public DateTime? ReleaseDate { get => fields.ReleaseDate[this]; set => fields.ReleaseDate[this] = value; }

    [DisplayText("Runtime (mins)")]
    public int? Runtime { get => fields.Runtime[this]; set => fields.Runtime[this] = value; }

    [DisplayText("Kind"), NotNull, DefaultValue(MovieKind.Film)]
    public MovieKind? Kind { get => fields.Kind[this]; set => fields.Kind[this] = value; }

    [DisplayText("Genre"), ForeignKey(typeof(GenreRow)), LeftJoin(jGenre)]
    [LookupEditor(typeof(GenreRow), InplaceAdd = true)]
    public int? GenreId { get => fields.GenreId[this]; set => fields.GenreId[this] = value; }

    [DisplayText("Genre"), Expression($"{jGenre}.Name")]
    public string? GenreName { get => fields.GenreName[this]; set => fields.GenreName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field MovieId = null!;
        public StringField Title = null!;
        public StringField Description = null!;
        public StringField Storyline = null!;
        public Int32Field Year = null!;
        public DateTimeField ReleaseDate = null!;
        public Int32Field Runtime = null!;
        public EnumField<MovieKind> Kind = null!;
        public Int32Field GenreId = null!;
        public StringField GenreName = null!;

    }
}