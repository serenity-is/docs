# 添加海报（Primary）和简介（Gallery）图片

分别给人员（Person）和影片（Movie）记录添加一张海报和多张简介图片。从迁移类开始：

```cs
using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB
{
    [Migration(20160603205900)]
    public class DefaultDB_20160603_205900_PersonMovieImages : Migration
    {
        public override void Up()
        {
            Alter.Table("Person").InSchema("mov")
                .AddColumn("PrimaryImage").AsString(100).Nullable()
                .AddColumn("GalleryImages").AsString(int.MaxValue).Nullable();

            Alter.Table("Movie").InSchema("mov")
                .AddColumn("PrimaryImage").AsString(100).Nullable()
                .AddColumn("GalleryImages").AsString(int.MaxValue).Nullable();
        }

        public override void Down()
        {
        }
    }
}
```

然后修改 MovieRow.cs 和 PersonRow.cs： 

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

我们指定这些字段将由 *ImageUploadEditor* 和 *MultipleImageUploadEditor* 类型处理。

FilenameFormat 指定上传文件的命名方式。例如，人员海报图片将上传到 App_Data/upload/Person/PrimaryImage/ 目录下面。

> 你可以通过  web.config 文件的 appSettings 节点下 *UploadSettings* 的配置，把保存上传文件的根目录 (*App_Data/upload*)修改为任意文件目录。

`~`  FilenameFormat 的末尾是自动命名方案的快捷方式 `{1:00000}/{0:00000000}_{2}`。

在这里，参数 {0} 替换为记录的标识，如，PersonID。

参数 {1} 是 1000 以内的整数标识。 这对保存在一个目录中的文件数进行限制是很有帮助的。

参数 {2} 是一个唯一的字符串，例如 6l55nk6v2tiyi，它用于为每个上传文件生成一个新的文件名，这有助于避免客户端缓存所造成的问题。

> 它还提供了一些安全措施，因此在没有链接的情况下不能知道文件名称。

因此，我们把上传的人员海报图片文件存放在如下路径：

```
> App_Data\upload\Person\PrimaryImage\00000\00000001_6l55nk6v2tiyi.jpg
```

> 你不必遵守此命名方案，你可以指定你自己的格式，如 `PersonPrimaryImage_{0}_{2}`。

下一步，把这些字段添加到表单（MovieForm.cs 和 PersonForm.cs）：

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

我也修改了人员对话框的css，让其有更多的空间：

```css
.s-MovieDB-PersonDialog {
    > .size { width: 700px; height: 600px; }
    .caption { width: 150px; }
    .s-PersonMovieGrid > .grid-container { height: 500px; }
}
```

这就是我们现在的窗体：

![Person with Images](img/mdb_person_keanu.png)

> ImageUploadEditor 直接在一个字符串字段中存储文件名，而 MultipleImageUpload 编辑器将文件名使用 JSON 数组格式存储在字符串字段中。


### 删除 Northwind 和 其他 示例 

我认为我们的项目达到了良好的状态，我现在要从 MovieTutorial 项目中删除 Northwind 和其他示例。

请参见如下帮助主题：

[如何删除 Northwind 和 其他 示例](../../howto/removing_northwind.md)



