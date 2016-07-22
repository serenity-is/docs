
# 自定义快速检索

### 添加几条影片记录

在下面的章节中，我们需要一些示例数据，可以从 IMDB 复制一些数据过来。

如果你不想浪费时间输入这些示例数据，可以从下面的链接中获取迁移类：

> https://github.com/volkanceylan/MovieTutorial/blob/master/MovieTutorial/MovieTutorial.Web/Modules/Common/Migrations/DefaultDB/DefaultDB_20160519_135200_SampleMovies.cs


![7 Movies Entered](img/mdb_sample_movies.png)

如果我们在搜索框中输入 *go* ，我们会看到两部影片被筛选出来：*The Good, the Bad and the Ugly* 和 *The Godfather*。

如果我们输入 *Gandalf*，则不会找到任何影片。

默认情况下，Sergen 把表的第一个文本字段作为 *名称* 字段。在电影（movies）表中是标题（*Title*），该字段有一个 *QuickSearch* 特性，它表示应该在此字段中执行文本搜索。

> 名称字段还决定初始的排序顺序和编辑对话框显示的标题。

有时候，第一个文本列可能不是名称字段。如果想更改为搜索另一个字段，你应该在 *MovieRow.cs* 中修改：

```cs

namespace MovieTutorial.MovieDB.Entities
{
    //...
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        //...
        StringField INameRow.NameField
        {
            get { return Fields.Title; }
        }
}
```

代码生成器决定表的第一个文本（string）字段是标题。所以它添加一个 INameRow 接口到 MovieRow 类，并通过返回标题（Title）字段实现该接口。如果想要使用描述（Description）作为名称字段，我们只须做对应的替换即可。

在这里，实际上 *Title* 是 name 字段，所以我们让它保持原样。但若想让 Serenity 对 *Description* 和 *Storyline* 字段搜索，我们需要对这两个字段添加 *QuickSearch* 特性，如下所示：

```
namespace MovieTutorial.MovieDB.Entities
{
    //...
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        //...
        [DisplayName("Title"), Size(200), NotNull, QuickSearch]
        public String Title
        {
            get { return Fields.Title[this]; }
            set { Fields.Title[this] = value; }
        }

        [DisplayName("Description"), Size(1000), QuickSearch]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Storyline"), QuickSearch]
        public String Storyline
        {
            get { return Fields.Storyline[this]; }
            set { Fields.Storyline[this] = value; }
        }
        //...
    }
}
```

现在，如果搜索 *Gandalf*，我们将得到 *The Lord of the Rings* 实体：

![Movies Search Gandalf](img/mdb_movie_gandalf.png)

默认情况下，QuickSearch 特性以 *包含* 的形式进行过滤。它有一些选项设置其匹配 StartsWith 过滤器或只匹配精确值。

如果我们希望它只显示 *StartsWith* 输入文本的过滤结果行，我们将特性更改为：

```cs
[DisplayName("Title"), Size(200), NotNull, QuickSearch(SearchType.StartsWith)]
public String Title
{
    get { return Fields.Title[this]; }
    set { Fields.Title[this] = value; }
}
```

> 在这里，这种快速搜索功能不是非常有用，但对于像 SSN、序列号、身份证号码、电话号码等类型的值将很有效。

如果我们还想在 year 列进行搜索，但只限于确切的整数年份值(匹配 1999，不匹配 19)：

```
[DisplayName("Year"), QuickSearch(SearchType.Equals, numericOnly: 1)]
public Int32? Year
{
    get { return Fields.Year[this]; }
    set { Fields.Year[this] = value; }
}
```

> 你可能已经注意到，我们不用为这些基本特性的工作写任何 C# 或 SQL 代码。我们只需指定我们想要的东西，而不是如何实现，这是就是声明式的编程。

也可以由用户决定搜索字段。

打开 *MovieTutorial.Web/Modules/MovieDB/Movie/MovieGrid.ts* ，并做如下修改：

```ts

namespace MovieTutorial.MovieDB {
    
    @Serenity.Decorators.registerClass()
    export class MovieGrid extends 
          Serenity.EntityGrid<MovieRow, any> {
        //...
        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickSearchFields():
              Serenity.QuickSearchField[] {
            return [
                { name: "", title: "all" },
                { name: "Description", title: "description" },
                { name: "Storyline", title: "storyline" },
                { name: "Year", title: "year" }
            ];
        }
    }
}
```

一旦你保存该文件，我们的快速搜索将变成以下拉列表的形式输入：

![Movies Quick Search Fields](img/mdb_movie_quicksearchfield.png)

> 与之前我们修改服务器端代码的示例不同，这一次我们在客户端仅修改 Javascript（TypeScript）代码。


### 运行 T4 模板（.tt 文件）

我们在之前的示例中硬编码 *Description*、*Storyline* 等字段，如果我们忘了属性的名称或属性在服务器端的大小写（javascript 区分大小写），就可能导致输入错误。

Serene 包含一些 T4(.tt) 文件，可以将此类信息从服务器端（C# 中的 rows 等）转移到客户端 （TypeScript） 用于智能提示。

运行这些模板之前，请确保你的解决方案能成功生成，以便模板可使用项目输出的 DLL 文件（*MovieTutorial.Web.dll*）生成代码。

在生成解决方案之后，点击 *生成* 菜单，然后选择 *转换所有模板*。

现在，我们可以使用智能提示的输入方式来替代硬编码字段名称，并在编译时检查版本：

```ts
namespace MovieTutorial.MovieDB
{
    //...
    public class MovieGrid extends EntityGrid<MovieRow, any>
    {
        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickSearchFields(): Serenity.QuickSearchField[]
        {
            let fld = MovieRow.Fields;
            return [
                { name: "", title: "all" },
                { name: fld.Description, title: "description" },
                { name: fld.Storyline, title: "storyline" },
                { name: fld.Year, title: "year" }
            ];
        }
    }
    ///...
}
```

字段标题呢？作为字段名称，它并不那么重要，但可用于本地化（如果我们以后决定翻译它）：

```ts
namespace MovieTutorial.MovieDB
{
    //...
    public class MovieGrid extends EntityGrid<MovieRow, any>
    {
        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickSearchFields(): Serenity.QuickSearchField[] {
            let fld = MovieRow.Fields;
            let txt = (s) => Q.text("Db." + 
                MovieRow.localTextPrefix + "." + s).toLowerCase();
            return [
                { name: "", title: "all" },
                { name: fld.Description, title: txt(fld.Description) },
                { name: fld.Storyline, title: txt(fld.Storyline) },
                { name: fld.Year, title: txt(fld.Year) }
            ];
        }
    }
    ///...
}
```

我们使用了在客户端可用的本地文本字典（翻译）。如：

```json
{
   // ...
   "Db.MovieDB.Movie.Description": "Description",
   "Db.MovieDB.Movie.Storyline": "Storyline",
   "Db.MovieDB.Movie.Year": "Year"
   // ...
}
```

行字段的本地文本唯一键由 *"Db." + (LocalTextPrefix for Row) + "." + FieldName* 组成。

它们的值从字段的 [DisplayName] 特性生成，但也可能是另一种语言的翻译。

LocalTextPrefix 默认情况下相当于 *ModuleName + "." + RowClassName *，但是可以在 Row 构造函数中修改。


