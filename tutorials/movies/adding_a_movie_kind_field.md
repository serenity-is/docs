# 添加一个影片类型字段

如果我们还想在影片表中保存电视剧和微电影，那我们就需要另一个字段（MovieKind）来存储它。

我们在创建影片（Movie）表时并没有添加 MovieKind 字段，现在我们用另一个迁移类把它添加到数据库中。

> 不要修改现有的迁移类，因为现有的迁移类不会再次运行。

在 *Modules/Common/Migrations/DefaultDB/ DefaultDB_20160519_145500_MovieKind.cs* 下面创建另一个迁移文件：

```cs
using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB
{
    [Migration(20160519145500)]
    public class DefaultDB_20160519_145500_MovieKind : Migration
    {
        public override void Up()
        {
            Alter.Table("Movie").InSchema("mov")
                .AddColumn("Kind").AsInt32().NotNullable()
                    .WithDefaultValue(1);
        }

        public override void Down()
        {
        }
    }
}
```


### 定义一个影片类型枚举

现在我们把 *Kind* 字段添加到影片（Movie）表中，我们需要一些影片类型作为值。让我们将它定义在 *MovieTutorial.Web/Modules/MovieDB/Movie/MovieKind.cs* 的枚举中：

```cs
using Serenity.ComponentModel;
using System.ComponentModel;

namespace MovieTutorial.MovieDB
{
    [EnumKey("MovieDB.MovieKind")]
    public enum MovieKind
    {
        [Description("Film")]
        Film = 1,
        [Description("TV Series")]
        TvSeries = 2,
        [Description("Mini Series")]
        MiniSeries = 3
    }
}
```


### 在 MovieRow 实体中添加 类型（Kind）字段

因为我们没有使用 Sergen ，所以我们需要在 MovieRow.cs 手工添加一个映射类型（*Kind*）属性。在 MovieRow.cs 的 *Runtime* 属性下面添加：

```cs
[DisplayName("Runtime (mins)")]
public Int32? Runtime
{
    get { return Fields.Runtime[this]; }
    set { Fields.Runtime[this] = value; }
}

[DisplayName("Kind"), NotNull]
public MovieKind? Kind
{
    get { return (MovieKind?)Fields.Kind[this]; }
    set { Fields.Kind[this] = (Int32?)value; }
}
```

我们还需要声明一个 Int32Field 对象，该对象用于 Serenity 实体系统。在 MovieRow.cs 的底部找到 RowFields 类并在 *Runtime* 字段后添加 *Kind* 字段：

```cs
public class RowFields : RowFieldsBase
{
    // ...
    public readonly Int32Field Runtime;
    public readonly Int32Field Kind;

    public RowFields()
        : base("[mov].Movie")
    {
        LocalTextPrefix = "MovieDB.Movie";
    }
}
```


### 为影片表单添加影片类型

如果我们现在生成并运行项目，尽管我们已经在 *MovieRow* 添加了 *Kind* 字段的映射，但在影片表单中还是看不到任何的变化。这是由于表单中字段的显示/编辑是在 MovieForm.cs 中控制的。

于是我们对 *MovieForm.cs* 做如下修改：

```cs

namespace MovieTutorial.MovieDB.Forms
{
    // ...
    [FormScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow))]
    public class MovieForm
    {
        // ...
        public MovieKind Kind { get; set; }
        public Int32 Runtime { get; set; }
    }
}
```

现在，生成并运行应用程序。当你尝试编辑或添加影片时，什么也不会发生。这是一个预料之中的情况。如果你打开浏览器的开发者工具（F12），在控制台中将出现一个错误：

```txt
Uncaught Can't find MovieTutorial.MovieDB.MovieKind enum type!
```

> 每当发生这样的事，请先检查浏览器控制台报告的错误信息。

这个错误是由于 MoveKind 枚举在客户端无效而导致的，因此，在这种情况下，我们应该在运行程序之前运行我们的 T4 模板。

现在在 Visual Studio 中再次点击 生成 -> 转换所有模板。

重新生成解决方案并运行它。现在就可以在表单中使用下拉列表选择影片类型了。

![Movie Kind Selection](img/mdb_movie_kindform.png)


### 为影片类型定义一个默认值

*Kind* 是一个必填字段，我们必须在 *新增 Movie* 对话框中填写该字段，否则将得到一个验证错误。

但是我们大部分影片都是故事片，所以应该把该值设为默认值。

若要为 *Kind* 属性添加默认值，需要像这样添加 *DefaultValue* 特性：

```cs
[DisplayName("Kind"), NotNull, DefaultValue(MovieKind.Film)]
public MovieKind? Kind
{
    get { return (MovieKind?)Fields.Kind[this]; }
    set { Fields.Kind[this] = (Int32?)value; }
}
```

现在，在*新增 Movie* 对话框中，*Kind* 字段的值将预设为 *Film*。