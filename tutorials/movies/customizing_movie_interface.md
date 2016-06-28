
# 自定义影片界面


### 自定义字段标题

在我们影片列表和表单中，有一个叫 *Runtime* 的字段。该字段需要一个整数，表示影片时长（*minutes*），但在其标题没有提示信息。让我们把其标题改为 Runtime (mins)。 

有几种方法可以做到这一点：修改服务器端表单的定义；修改服务器端列的定义；修改网格列表的脚本代码等。但让我们在核心的位置做修改，即修改实体本身，这样实体的标题在所有使用的地方都将得到修改。

当 Sergen 为电影（Movie）表生成代码时，创建了一个叫 MovieRow 的实体类，你可以在 *Modules/MovieDB/Movie/MovieRow.cs* 找到它。

这是在摘自源文件的 Runtime 属性：

```cs
namespace MovieTutorial.MovieDB.Entities
{
    // ...
    [ConnectionKey("Default"), DisplayName("Movie"), 
     InstanceName("Movie"), TwoLevelCached]
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        // ...
        [DisplayName("Runtime")]
        public Int32? Runtime
        {
            get { return Fields.Runtime[this]; }
            set { Fields.Runtime[this] = value; }
        }
        //...
    }
}
```

我们会在后面讨论 entities（或 rows），现在让我们把注意力集中在更改字段名称的目标上。我们把 Runtime 属性的 DisplayName 特性的值修改为 \*Runtime (mins)：

```cs
namespace MovieTutorial.MovieDB.Entities
{
    // ...
    [ConnectionKey("Default"), DisplayName("Movie"), InstanceName("Movie"), 
     TwoLevelCached]
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        // ...
        [DisplayName("Runtime (mins)")]
        public Int32? Runtime
        {
            get { return Fields.Runtime[this]; }
            set { Fields.Runtime[this] = value; }
        }
        //...
    }
}
```

现在生成并运行应用程序，你会在网格列表和对话框中看到字段标题的变化。 

> 在列不够宽时，列标题有 "..."，但是它会在提示信息中显示完整的标题。我们很快就会看到这是如何处理的。

![Movies Runtime (Mins)](img/mdb_runtime_mins.png)


### 重写列的标题和宽度 


到目前为止，一切看起来都还不错，如果我们想在网格列表（columns）或对话框（form）中显示另一个标题。我们可以重写它对应的定义文件。

我们先从 columns 开始，在 *MovieRow.cs* 旁边，你可以找到名为 *MovieColumns.cs* 的文件：

```cs
namespace MovieTutorial.MovieDB.Columns
{
    // ...

    [ColumnsScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow))]
    public class MovieColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MovieId { get; set; }
        //...
        public Int32 Runtime { get; set; }
    }
}
```

你可能会注意到这个 columns 的定义是基于电影实体（BasedOnRow 特性）。

任何写在这里的特性都将重写定义在实体类中的特性。

让我们把 DisplayName 特性添加到 *Runtime* 属性：

```cs
namespace MovieTutorial.MovieDB.Columns
{
    // ...

    [ColumnsScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow))]
    public class MovieColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MovieId { get; set; }
        //...
        [DisplayName("Runtime in Minutes"), Width(150), AlignRight]
        public Int32 Runtime { get; set; }
    }
}
```

现在，我们可以把列标题设置为 "Runtime in Minutes"。 

实际上，我们添加了更多的特性。 

其中，重写列的宽度为150px。

> Serenity 将根据字段类型和字符串长度自动设置列的宽度，除非你显式设置宽度。

并且把列设为右对齐（还可设为居中对齐，左对齐）

再次生成并运行项目，我们将看到： 

![Movies Runtime Column](img/mdb_runtime_col.png)

表单的标题保持原样，而网格的列标题已经发生了变化。

> 相反，如果我们想重写表单字段，我们就在 MovieForm.cs 做类似的步骤。


### 修改描述（Description）和剧情（Storyline）的编辑器类型 

描述（Description）和剧情（Storyline）比标题（Title）字段长一点，因此让我们把他们的编辑器类型改为文本域（textarea）。

在*MovieColumns.cs* 和 *MovieRow.cs* 的同一文件夹中，打开 *MovieForm.cs* 。

```cs
namespace MovieTutorial.MovieDB.Forms
{
    //...
    [FormScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow))]
    public class MovieForm
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public String Storyline { get; set; }
        public Int32 Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Int32 Runtime { get; set; }
    }
}
```

添加 TextAreaEditor 特性到这两个特性中：

```cs
namespace MovieTutorial.MovieDB.Forms
{
    //...
    [FormScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow))]
    public class MovieForm
    {
        public String Title { get; set; }
        [TextAreaEditor(Rows = 3)]
        public String Description { get; set; }
        [TextAreaEditor(Rows = 8)]
        public String Storyline { get; set; }
        public Int32 Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Int32 Runtime { get; set; }
    }
}
```

我为剧情（8）分配了更多的编辑行，因为与描述（3）相比剧情应该更长。

生成并运行项目后，我们得到：

![Movies TextArea Editors](img/mdb_movie_textarea.png)

Serene 有几个编辑器类型可供选择。有些是基于字段的数据类型自动选取，而你需要显式地设置它们。 

> 你还可以开发自己的编辑器类型。你可以把现有的编辑器类作为基类，或者从 stratch 中开发自己的，我们会在后面的章节介绍。

由于编辑器有点高，表单高度超出了 Serenity 默认的表单高度(约260px)，所以现在我们有一个垂直滚动条，让我们将其删除。

### 使用 CSS（Less）设置对话框的初始大小 

Sergen 在 *MovieTutorial.Web/Content/site/site.less* 文件中生成一些影片对话框的 CSS。 

如果你打开该文件，滚动到底部，你将看到：

```cs
/* ------------------------------------------------------------------------- */
/* APPENDED BY CODE GENERATOR, MOVE TO CORRECT PLACE AND REMOVE THIS COMMENT */
/* ------------------------------------------------------------------------- */

.s-MovieDB-MovieDialog {
    > .size { width: 650px; }
    .caption { width: 150px; }
}
```

你可以安全地删除这三行注释（由代码生成器添加）。这是提醒你将它们移动到更好的地方，如移到特定于此模块的 site.movies.less 文件（推荐）。

这些规则将应用于有 *.s-MovieDB-MovieDialog* 样式类的元素。在默认情况下，我们的对话框具有这样的样式类： "s-"+ ModuleName +"-"+ ClassName。 

在第二行中指定该对话框的默认宽度是 650px 。

在第三行中，我们指定该字段标签长度应该是 150px(@l：150px)。

让我们改变对话框初始高度为 500px(桌面模式)，所以它不会出现垂直滚动条：

```css
.s-MovieDialog {
    > .size { width: 650px); height: 500px; }
    .caption { width: 150px; }
}
```

要将此更改应用到你的对话框，你需要生成解决方案。 在生成项目时， "site.less" 文件被编译到一个 "site.css" 文件。现在生成并刷新页面。

![Movie Dialog 500px](img/mdb_movie_500px.png)

上面我所说的*桌面模式* 将很快变得直观。Serenity 对话框默认是响应式的。让我们调整浏览器窗口的宽度为 350px 左右。我会用 Chrome浏览器的移动模式切换到 iphone 6：


![Movie Dialog iPhone6](img/mdb_movie_iphone6.png)

现在改为 iPad 横向模式： 

![Movie Dialog iPad](img/mdb_movie_ipad.png)

因此，我们在这里对桌面模式设置的高度是很有用意的。对话框将变为响应式，对移动设备特定大小模式保持敏感的响应，却不需要使用 CSS 的 @media 查询。


### 修改页面标题

我们的页面有标题 *Movie*，让我们把它修改为 *Movie*。 

再次打开 *MovieRow.cs*。 

```cs
namespace MovieTutorial.MovieDB.Entities
{
    // ...
    [ConnectionKey("Default"), DisplayName("Movie"), InstanceName("Movie"), 
     TwoLevelCached]
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        [DisplayName("Movie Id"), Identity]
        public Int32? MovieId
```

把 DisplayName 特性的值改为 *Movies*。这是引用此表时使用的名称，它通常是复数。此特性用于确定默认页面标题。 

> 也可以在 *MoviePage.Index.cshtml* 文件中重写页面标题。但像往常一样，我们习惯从核心着手，以便在其他地方可以重用这些信息。

实例名对应单数名称，并在网格的新增记录（新电影）按钮中使用，也决定了对话框标题（例如编辑电影）。

```cs
namespace MovieTutorial.MovieDB.Entities
{
    // ...
    [ConnectionKey("Default"), DisplayName("Movies"), InstanceName("Movie"), 
     TwoLevelCached]
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        [DisplayName("Movie Id"), Identity]
        public Int32? MovieId
```
