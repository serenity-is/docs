
# 添加影片流派（Movie Genres）


### 添加流派（Genre）字段

我们需要一个检索表来保存影片流派（Movie genres）。在影片类型中我们使用一个枚举，但这次流派可能不是 *静态* 的，不能再把它定义成枚举。

像往常一样，我们从迁移类开始：

*Modules/Common/Migrations/DefaultDB/ DefaultDB_20160519_154700_GenreTable.cs*:

```cs
using FluentMigrator;
using System;

namespace MovieTutorial.Migrations.DefaultDB
{
    [Migration(20160519154700)]
    public class DefaultDB_20160519_154700_GenreTable : Migration
    {
        public override void Up()
        {
            Create.Table("Genre").InSchema("mov")
                .WithColumn("GenreId").AsInt32().NotNullable()
                    .PrimaryKey().Identity()
                .WithColumn("Name").AsString(100).NotNullable();

            Alter.Table("Movie").InSchema("mov")
                .AddColumn("GenreId").AsInt32().Nullable()
                    .ForeignKey("FK_Movie_GenreId", "mov", "Genre", "GenreId");
        }

        public override void Down()
        {
        }
    }
}
```

我们也要在电影（*Movie*）表中添加 *GenreId* 字段。

> 实际上，一部电影可以属于多个流派，因此我们应该把它保存在一张单独的影片流派（*MovieGenres*）表中。但是现在，我们假设一部电影只属于一个流派。我们将在后面演示如何将它改为可属于多个少流派。


### 为影片流派表生成代码

再次使用程序包管理器控制台打开 sergen.exe，并为 *Genre* 表设置生成代码的参数，如下所示：

![Genre Code Generation](img/mdb_movie_genretable.png)


重新生成解决方案并运行项目，我们将得到这样的新页面：

![Genre Initial Page](img/mdb_genre_initial.png)

正如你在截图中看到，它在左侧导航菜单中重新生成 *MovieDB* 菜单，而不是生成到我们最近重命名的 Movie Database 菜单下。

这是由于 *Sergen* 不知道我们对 *Movie* 页面的定制化修改，所以我们需要手工把它移到 *Movie Database* 下面。

打开 *Modules/Movie/GenrePage.cs*，剪切下面的导航连接：

```cs
[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "MovieDB/Genre",
    typeof(MovieTutorial.MovieDB.Pages.GenreController))]

````

并把它移到 *Modules/Common/Navigation/NavigationItems.cs*：

```cs
//...
[assembly: NavigationMenu(2000, "Movie Database", icon: "icon-film")]
[assembly: NavigationLink(2100, "Movie Database/Movies", 
    typeof(MovieDB.MovieController), icon: "icon-camcorder")]
[assembly: NavigationLink(2200, "Movie Database/Genres", 
    typeof(MovieDB.GenreController), icon: "icon-pin")]
//...
```


### 添加多个流派的定义

现在，让我们添加一些流派示例。我将通过迁移类来完成，而不是在不同计算机中重复该操作，但是你可以通过影片流派页面手工添加。

```cs
using FluentMigrator;
using System;

namespace MovieTutorial.Migrations.DefaultDB
{
    [Migration(20160519181800)]
    public class DefaultDB_20160519_181800_SampleGenres : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Genre").InSchema("mov")
                .Row(new
                {
                    Name = "Action"
                })
                .Row(new
                {
                    Name = "Drama"
                })
                .Row(new
                {
                    Name = "Comedy"
                })
                .Row(new
                {
                    Name = "Sci-fi"
                })
                .Row(new
                {
                    Name = "Fantasy"
                })
                .Row(new
                {
                    Name = "Documentary"
                });
        }

        public override void Down()
        {
        }
    }
}
```


### 在 MovieRow 映射 GenreId 字段

像我们之前在添加 *Kind* 字段一样，*GenreId* 字段也需要在 *MovieRow.cs* 中映射。

```cs
namespace MovieTutorial.MovieDB.Entities
{
    // ...
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        [DisplayName("Kind"), NotNull, DefaultValue(1)]
        public MovieKind? Kind
        {
            get { return (MovieKind?)Fields.Kind[this]; }
            set { Fields.Kind[this] = (Int32?)value; }
        }

        [DisplayName("Genre"), ForeignKey("[mov].Genre", "GenreId"), LeftJoin("g")]
        public Int32? GenreId
        {
            get { return Fields.GenreId[this]; }
            set { Fields.GenreId[this] = value; }
        }

        [DisplayName("Genre"), Expression("g.Name")]
        public String GenreName
        {
            get { return Fields.GenreName[this]; }
            set { Fields.GenreName[this] = value; }
        }

        // ...

        public class RowFields : RowFieldsBase
        {
            // ...
            public readonly Int32Field Kind;
            public readonly Int32Field GenreId;
            public readonly StringField GenreName;

            public RowFields()
                : base("[mov].Movie")
            {
                LocalTextPrefix = "MovieDB.Movie";
            }
        }
    }
}
```

在这里，我们映射 *GenreId* 字段并使用 *ForeignKey* 特性定义它与 *[mov].Genre* 表中的 *GenreId* 有外键关系。

> 如果我们在添加流派表之后为电影表生成代码，Sergen 通过在数据库中检查外键定义来理解这种关系，并为我们生成类似的代码。

我们还添加了另一个字段，实际上，*GenreName* 并不是电影表（*Movie*）中的字段，而是流派（*Genre*）表中字段的。

Serenity 实体更像是 SQL 视图。你可以使用关联（joins）获取其他表的字段。

可在 MovieId 属性中添加 *LeftJoin("g")* 特性。每当流派（Genre）表需要被关联时，我们定义它的别名为 *g*。

因此，当 Serenity 需要从电影（*Movies*）表查询时，它生成这样的 SQL 查询：

```sql
SELECT t0.MovieId, t0.Kind, t0.GenreId, g.Name as GenreName 
FROM Movies t0
LEFT JOIN Genre g on t0.GenreId = g.GenreId 
```

> 该关联（join）操作只在需要流派（Genre）表字段时才执行，如在网格列表需要显示流派信息时。

通过在 *GenreName* 属性上面添加 *Expression("g.Name")*，指定该字段有一个 *g.Name* 的 SQL 表达式，表明这是一个来自 g 的关联字段。

### 为影片窗体添加流派选择

让我们把 GenreId 字段添加到 MovieForm.cs：

```cs
namespace MovieTutorial.MovieDB.Forms
{
    //...
    [FormScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow))]
    public class MovieForm
    {
        //...
        public Int32 GenreId { get; set; }
        public MovieKind Kind { get; set; }
    }
}
```

现在，如果我们生成并运行应用程序，我们将在表单中看到一个 Genre 字段。现在的问题是 Genre 允许输入整型数值，而我们想使用下拉列表。

很显然，我们需要为 GenreId 字段修改编辑器类型。


### 为流派（Genres）声明一个检索脚本（Lookup Script）

若要为流派（Genre）字段显示一个编辑器，在客户端列出数据库中的流派列表应该是可行的做法。

如果是枚举值，我们只需简单地运行 T4 模板就可以把枚举定义复制到客户端脚本。

但我们不能在这里用同样的方法。流派列表是基于数据库的动态列表。

Serenity 有 *动态脚本（Dynamic scripts）* 的概念，将动态数据在运行时以生成脚本的形式提供给脚本端。

> 动态脚本类似于 Web 服务，但是它们产出的是可以在客户端缓存的动态 javascript 脚本。
> 
> 这里的 *动态* 对应于它们包含的数据，而不是它们的行为。不像 Web 服务，动态脚本不能授受任何参数，并且网站的所有用户都共享动态脚本产生的数据，动态脚本更像是单例或静态变量。
> 
> 你不应该试图写像 Web 服务行为(例如，检索)那样的动态脚本。

为流派（Genre）表声明一个动态检索脚本（dynamic lookup script），打开 *GenreRow.cs* 并作做下修改：

```cs
namespace MovieTutorial.MovieDB.Entities
{
    // ...

    [ConnectionKey("Default"), DisplayName("Genre"), InstanceName("Genre"), 
        TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    [JsonConverter(typeof(JsonRowConverter))]
    [LookupScript("MovieDB.Genre")]
    public sealed class GenreRow : Row, IIdRow, INameRow
    {
        // ...
    }
```

我们只添加了一行代码：*[LookupScript("MovieDB.Genre")]*。

重新生成并启动项目，在登录系统之后，使用 *F12* 打开开发者工具的控制台标签：

输入 *Q.getLookup('MovieDB.Genre')*：

你会得到一些像这样的信息：

![Movies Genre Lookup from Console](img/mdb_genre_getlookup.png)

这里，我们在声明 LookupScript 特性时为其指定 *MovieDB.Genre* 参数：

> [LookupScript("MovieDB.Genre")]

这一步骤只是为了演示如何检查一个检索脚本在客户端是否可用。

> "*MovieDB.Genre*" 的检索键（Lookup key）是区分大小写的，所以请确保你输入大小写一致的参数。

### 对流派表字段使用 LookupEditor

这里有两个地方为 GenreId 字段设置编辑器类型：一是在 MovieForm.cs，另一个是 MovieRow.cs。

我更喜欢后者，因为它是核心组件类。但如果编辑器类型仅应用于表单，你可以选择在表单类上设置它。

>定义在表单中的信息不能被重用。例如，网格列表使用 XYZColumn.cs / XYZRow.cs，而对话框使用 XYZForm.cs / XYZRow.cs。由此可见，把可重用信息定义在 XYZRow.cs 更好。

打开 MovieRow.cs 并为 *GenreId* 属性添加 *LookupEditor* 特性：

```cs
    [DisplayName("Genre"), ForeignKey("[mov].Genre", "GenreId"), LeftJoin("g")]
    [LookupEditor("MovieDB.Genre")]
    public Int32? GenreId
    {
        get { return Fields.GenreId[this]; }
        set { Fields.GenreId[this] = value; }
    }

```

在我们生成和启动项目之后，在 Genre 字段中，我们现在有一个可搜索的（Select2.js）下拉列表。

![Movie Form With Genre Editor](img/mdb_genre_dropdown.png)

在定义 [LookupEditor] 时，我们硬编码检索键。我们还可以使用 GenreRow 进行信息重用：

```cs
    [DisplayName("Genre"), ForeignKey("[mov].Genre", "GenreId"), LeftJoin("g")]
    [LookupEditor(typeof(GenreRow))]
    public Int32? GenreId
    {
        get { return Fields.GenreId[this]; }
        set { Fields.GenreId[this] = value; }
    }

```

它们在功能上是等效的，但我更喜欢后者。后面这种方式，Serenity 将在 GenreRow 中找到 [LookupScript] 特性，并从中获取检索键信息。如果我们的 GenreRow 没有 [LookupScript] 特性，在应用程序启动时，你会得到错误：

```
Server Error in '/' Application.

'MovieTutorial.MovieDB.Entities.GenreRow' type doesn't have a 
[LookupScript] attribute, so it can't be used with a LookupEditor!

Parameter name: lookupType
```

> 在应用程序启动时扫描表单，因此没有修复该问题时，是没有办法处理这个错误的。

### 在影片表格中显示流派

目前，影片流派可以在表单中编辑，但没有显示在影片列表。我们可以通过编辑 MovieColumns.cs 来显示 GenreName（而不是 GenreId）。


```cs
namespace MovieTutorial.MovieDB.Columns
{
    // ...
    public class MovieColumns
    {
        //...
        [Width(100)]
        public String GenreName { get; set; }
        [DisplayName("Runtime in Minutes"), Width(150), AlignRight]
        public Int32 Runtime { get; set; }
    }
}
```

现在 GenreName 可以在网格列表中显示了。

![Movie Gid With Genre Column](img/mdb_genre_incolumn.png)


### 让就地定义新的流派成为可能

当为我们为示例影片设置流派时，我们注意到 影片《黄金三镖客》（*The Good, the Bad and the Ugly*）是属于西部片（*Western*），但在流派下拉列表中还没有该选项（所以我不得不把流派选为 剧情）。

要为该影片添加正确的流派，其中一个做法是打开流派页面，添加该当流派，并再次回到影片表单……然而这并不是很好的操作体验。

幸运的是，Serenity 集成了就地为编辑器声明新内容的能力。

打开 MovieRow.cs，并对 *LookupEditor* 特性做如下修改：

```cs
[DisplayName("Genre"), ForeignKey("[mov].Genre", "GenreId"), LeftJoin("g")]
[LookupEditor(typeof(GenreRow), InplaceAdd = true)]
public Int32? GenreId
{
    get { return Fields.GenreId[this]; }
    set { Fields.GenreId[this] = value; }
}

```

现在，我们可以点击流派（Genre）字段旁边的图标添加新的流派。

![Defining Genre Inplace](img/mdb_genre_inplace.png)

> 在这里，我们可看到，可以在电影页面打开一个对话框，并在对话框中打开另一个页面（GenreDialog）。在 Serenity 应用程序中，所有的客户端对象（对话框、网格列表、编辑器、格式化器等）都是自包含的可重用组件（部件），它们并没有绑定到任何页面。

还可以在流派编辑器中输入内容，它将为你提供一个选项来添加一个新的流派。

![Defining Genre By Searching](img/movies_genre_search_add.png)

### 它是如何确定要使用的对话框类型

你可能还没有注意到这个细节：在我们想就地添加一个新的流派时，我们的流派检索编辑器（lookup editor）为选择流派而自动打开一个新的 *流派对话框（GenreDialog）*。

在这里，我们的检索编辑器使用了一项约定。因为它的检索键是 *MovieDB.Genre*，所以它使用下面的完整名称搜索对话框类：

```
MovieDB.GenreDialog
MovieTutorial.MovieDB.GenreDialog
...
...
```

幸运的是，我们有一个流派对话框（GenreDialog），它定义在 *Modules/Genre/GenreDialog.ts* ，并且它的完整名称是 *MovieTutorial.MovieDB.GenreDialog*。

```ts
namespace MovieTutorial.MovieDB {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class GenreDialog extends Serenity.EntityDialog<GenreRow, any> {
        protected getFormKey() { return GenreForm.formKey; }
        protected getIdProperty() { return GenreRow.idProperty; }
        protected getLocalTextPrefix() { return GenreRow.localTextPrefix; }
        protected getNameProperty() { return GenreRow.nameProperty; }
        protected getService() { return GenreService.baseUrl; }

        protected form = new GenreForm(this.idPrefix);
    }
}
```

如果 *GenreRow* 的检索键和其对话框类不匹配，当我们单击就地添加按钮时，我们会在浏览器控制台得到一个错误：

```
Uncaught MovieDB.GenreDialog dialog class is not found!
```

在名称不匹配的情况下，你可使用一个兼容的检索键，如 "*ModuleName.RowType*"，或者显式指定对话框类型：

```cs
[DisplayName("Genre"), ForeignKey("[mov].Genre", "GenreId"), LeftJoin("g")]
[LookupEditor(typeof(GenreRow), InplaceAdd = true, DialogType = "MovieDB.Genre")]
public Int32? GenreId
{
    get { return Fields.GenreId[this]; }
    set { Fields.GenreId[this] = value; }
}
```

> 你不应该把 *Dialog* 作为对话框的后缀，也不能有完整的命名空间，如 *MovieTutorial.MovieDB.Genre*，因为 Serenity 会自动搜索它们。


### 为网格列表添加流派的快速过滤

随着我们影片列表数据变得越来越多，除了快速搜索功能，我们可能还需要基于某字段值来筛选影片。

Serenity 有几个过滤方法，快速过滤器（Quick Filter）就是其中之一。我们将其应用到流派（Genre）字段。

编辑 *Modules/MovieDB/Movie/MovieColumns.cs* 文件，在 GenreName 属性上面添加一个 [QuickFilter] 特性：

```cs
public class MovieColumns
{
    //...
    public DateTime ReleaseDate { get; set; }
    [Width(100), QuickFilter]
    public String GenreName { get; set; }
    [DisplayName("Runtime in Minutes"), Width(150), AlignRight]
    public Int32 Runtime { get; set; }
}
```

生成并导航到影片页面。你可以通过流派（Genre）字段的下拉列表快速过滤：

![Genre Quick Filter](img/mdb_movie_genrequick.png)

被过滤的字段实际上是 *GenreId* ，而不是我们附加 QuickFilter 特性的 *GenreName*。Serenity 足够聪明能理解这种关系，并通过查看 GenreRow.cs 的 GenreId 属性确定使用编辑器的类型。


### 重新运行 T4 模板

由于我们在应用程序中添加了一个新实体，我们应该在生成解决方案之后运行 T4 模板。
