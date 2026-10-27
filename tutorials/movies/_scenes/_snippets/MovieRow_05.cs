namespace MovieTutorial.MovieDB;

[ConnectionKey("Default"), Module("MovieDB"), TableName("Movie")]
[DisplayText("Movies"), InstanceName("Movie")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class MovieRow : Row<MovieRow.RowFields>, IIdRow, INameRow
{
    [DisplayText("Movie Id"), Identity, IdProperty]
    public int? MovieId { get => fields.MovieId[this]; set => fields.MovieId[this] = value; }

    [DisplayText("Title"), NotNull, QuickSearch, NameProperty]
    public string? Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayText("Description")]
    public string? Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayText("Storyline")]
    public string? Storyline { get => fields.Storyline[this]; set => fields.Storyline[this] = value; }

    [DisplayText("Year")]
    public int? Year { get => fields.Year[this]; set => fields.Year[this] = value; }

    [DisplayText("Release Date")]
    public DateTime? ReleaseDate { get => fields.ReleaseDate[this]; set => fields.ReleaseDate[this] = value; }

    [DisplayText("Runtime (mins)")]
    public int? Runtime { get => fields.Runtime[this]; set => fields.Runtime[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field MovieId = null!;
        public StringField Title = null!;
        public StringField Description = null!;
        public StringField Storyline = null!;
        public Int32Field Year = null!;
        public DateTimeField ReleaseDate = null!;
        public Int32Field Runtime = null!;

    }
}