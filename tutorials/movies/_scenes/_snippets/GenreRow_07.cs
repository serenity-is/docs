namespace MovieTutorial.MovieDB;

[ConnectionKey("Default"), Module("MovieDB"), TableName("Genre")]
[DisplayText("Genre"), InstanceName("Genre")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class GenreRow : Row<GenreRow.RowFields>, IIdRow, INameRow
{
    [DisplayText("Genre Id"), Identity, IdProperty]
    public int? GenreId { get => fields.GenreId[this]; set => fields.GenreId[this] = value; }

    [DisplayText("Name"), NotNull, QuickSearch, NameProperty]
    public string? Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field GenreId = null!;
        public StringField Name = null!;

    }
}