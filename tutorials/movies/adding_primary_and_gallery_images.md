# Adding Primary and Gallery Images

To add a primary image and multiple gallery images to both Movie and Person records, need to start with a migration:

```cs
using FluentMigrator;
using System;

namespace MovieTutorial.Migrations.DefaultDB
{
    [Migration(20151115202100)]
    public class DefaultDB_20151115_202100_PrimaryGalleryImages : Migration
    {
        public override void Up()
        {
            Alter.Table("Person").InSchema("mov")
                .AddColumn("PrimaryImage").AsString(100).Nullable()
                .AddColumn("GalleryImages").AsString(Int32.MaxValue).Nullable();

            Alter.Table("Movie").InSchema("mov")
                .AddColumn("PrimaryImage").AsString(100).Nullable()
                .AddColumn("GalleryImages").AsString(Int32.MaxValue).Nullable();
        }

        public override void Down()
        {
        }
    }
}
```

Then modify MovieRow.cs and PersonRow.cs:

```cs
namespace MovieTutorial.MovieDB.Entities
{
    // ...
    public sealed class PersonRow : Row, IIdRow, INameRow
    {

        [DisplayName("Primary Image"), Size(100), 
         ImageUploadEditor(FilenameFormat = "Person/PrimaryImage/~")]
        public string PrimaryImage
        {
            get { return Fields.PrimaryImage[this]; }
            set { Fields.PrimaryImage[this] = value; }
        }

        [DisplayName("Gallery Images"), 
         MultipleImageUploadEditor(FilenameFormat = "Person/GalleryImages/~")]
        public string GalleryImages
        {
            get { return Fields.GalleryImages[this]; }
            set { Fields.GalleryImages[this] = value; }
        }

        // ...
        
        public class RowFields : RowFieldsBase
        {
            // ...
            public readonly StringField PrimaryImage;
            public readonly StringField GalleryImages;
            // ...
        }
    }
}
```

```cs
namespace MovieTutorial.MovieDB.Entities
{
    // ...
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        [DisplayName("Primary Image"), Size(100), 
         ImageUploadEditor(FilenameFormat = "Movie/PrimaryImage/~")]
        public string PrimaryImage
        {
            get { return Fields.PrimaryImage[this]; }
            set { Fields.PrimaryImage[this] = value; }
        }

        [DisplayName("Gallery Images"), 
         MultipleImageUploadEditor(FilenameFormat = "Movie/GalleryImages/~")]
        public string GalleryImages
        {
            get { return Fields.GalleryImages[this]; }
            set { Fields.GalleryImages[this] = value; }
        }

        // ...
        public class RowFields : RowFieldsBase
        {
            // ...
            public readonly StringField PrimaryImage;
            public readonly StringField GalleryImages;
            // ...
        }
    }
}
```

Here we specify that these fields will be handled by *ImageUploadEditor* and *MultipleImageUploadEditor* types.

FilenameFormat specifies the naming of uploaded files. For example, Person primary image will be uploaded to a folder under *App_Data/upload/Person/PrimaryImage/*.

`~` at the end of FilenameFormat is a shortcut for the automatic naming scheme `{1:00000}/{0:00000000}_{2}`.

Here, parameter {0} is replaced with identity of the record, e.g. PersonID.

Parameter {1} is identity / 1000. This is useful to limit number of files that stored in one directory.

Parameter {2} is a unique string like *6l55nk6v2tiyi*, which is used to generate a new file name on every upload. This helps to avoid problems caused by caching on client side.

Thus, a file we upload for person primary image will be located at a path like this:

```
> App_Data\upload\Person\PrimaryImage\00000\00000001_6l55nk6v2tiyi.jpg
```

> You don't have to follow this naming scheme. You can specify your own format like `PersonPrimaryImage_{0}_{2}`.

Next step is to add these fields to forms (MovieForm.cs and PersonForm.cs):

```cs
namespace MovieTutorial.MovieDB.Forms
{
    //...
    public class PersonForm
    {
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String PrimaryImage { get; set; }
        public String GalleryImages { get; set; }
        public DateTime BirthDate { get; set; }
        public String BirthPlace { get; set; }
        public Gender Gender { get; set; }
        public Int32 Height { get; set; }
    }
}
```

```cs

namespace MovieTutorial.MovieDB.Forms
{
    //...
    public class MovieForm
    {
        public String Title { get; set; }
        [TextAreaEditor(Rows = 3)]
        public String Description { get; set; }
        [MovieCastEditor]
        public List<Entities.MovieCastRow> CastList { get; set; }
        public String PrimaryImage { get; set; }
        public String GalleryImages { get; set; }
        [TextAreaEditor(Rows = 8)]
        public String Storyline { get; set; }
        public Int32 Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Int32 Runtime { get; set; }
        public Int32 GenreId { get; set; }
        public MovieKind Kind { get; set; }
    }
}
```

I also modified Person dialog css a bit to have more space:

```css
.s-PersonDialog {
    > .size { .widthAndMin(700px); .heightAndMin(600px); }
    .dialog-styles(@h: auto, @l: 150px, @e: 450px);
    .s-PropertyGrid .categories { height: 460px; }
    .ui-dialog-content { overflow: hidden; }
    .tab-pane.s-TabMovies { padding: 5px; }
    .s-PersonMovieGrid > .grid-container { height: 515px; }
}
```

This is what we get now:

![Person with Images](img/movies_person_keanu_images.png)

> ImageUploadEditor stores file name directly in a string field, while MultipleImageUpload editor stores file names in a string field with JSON array format.