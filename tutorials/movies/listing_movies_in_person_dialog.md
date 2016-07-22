# 在人员对话框列出参演影片

为了显示人员参演的影片，我们将在 PersonDialog 添加一个选项卡。

默认情况下，所有编辑对话框（都继承自 EntityDialog）在 *MovieTutorial.Web/Views/Templates/EntityDialog.Template.html* 使用 *EntityDialog* 模板。

```html
<div class="s-DialogContent">
    <div id="~_Toolbar" class="s-DialogToolbar">
    </div>
    <div class="s-Form">
        <form id="~_Form" action="">
            <div class="fieldset ui-widget ui-widget-content ui-corner-all">
                <div id="~_PropertyGrid"></div>
                <div class="clear"></div>
            </div>
        </form> 
    </div>
</div>
```

该模板包含占位符，如 *工具栏(~_Toolbar)*、*表单(~_Form)* 和 *网格属性(*~_PropertyGrid)*。

> ~_ 是一个在运行时被替换为唯一对话框 ID 的特殊前缀。这确保了同一个对话框的两个实例不会有同样的 ID 值。

所有模板共享 EntityDialog 模板，因此我们把它原样添加到 PersonDialog 选项卡。

### 为 PersonDialog 添加选项卡模板定义

在 *Modules/MovieDB/Person/* 文件夹下创建 *MovieDB.PersonDialog.Template.html*，其内容为：


```html
<div id="~_Tabs" class="s-DialogContent">
    <ul>
        <li><a href="#~_TabInfo"><span>Person</span></a></li>
        <li><a href="#~_TabMovies"><span>Movies</span></a></li>
    </ul>
    <div id="~_TabInfo" class="tab-pane s-TabInfo">
        <div id="~_Toolbar" class="s-DialogToolbar">
        </div>
        <div class="s-Form">
            <form id="~_Form" action="">
                <div class="fieldset ui-widget ui-widget-content ui-corner-all">
                    <div id="~_PropertyGrid"></div>
                    <div class="clear"></div>
                </div>
            </form>
        </div>
    </div>
    <div id="~_TabMovies" class="tab-pane s-TabMovies">
        <div id="~_MoviesGrid">

        </div>
    </div>
</div>
```

我们这里使用的语法是特定于 jQuery UI 选项卡组件，它需要一个包含指向选项卡面板 div(*.tab-pane*) 的 UL 列表。

当 *EntityDialog* 在模板中找到 ID 含有 *~_Tabs* 的 div，它将自动在模板中把其初始化为选项卡组件。

模板文件的命名是很重要的，它必须以 *.Template.html* 扩展名结尾。所有以该扩展名结束的文件都是通过动态脚本提供给客户端。

模板文件的文件夹被忽略，但是模板必须在 *Modules* 或者 *Views/Template* 文件夹下面。

默认情况下，所有的模板组件（EntityDialog 也继承自 TemplatedWidget 类）使用类名查找模板。因此，PersonDialog 首先查找名为 *MovieDB.PersonDialog.Template.html* 的模板，然后是 *PersonDialog.Template.html*。

> MovieDB 来自于把 PersonDialog 命名空间删除根命名空间(MovieTutorial)。你也可以认为是模块名与类名的组合。

如果没有找到含该类名的模板，将继续到基类查找并最终找到一个备用模板，使用 *EntityDialog.Template.html*。

现在，我们将在 PersonDialog 中有一个选项卡：

![Person With Tabs Initial](img/mdb_person_tabs.png)

> 与此同时，我注意到 Person 菜单还在 MovieDB 下面，并且我们忘了删除 MovieCast 菜单，我现在就修正……

### 创建 PersonMovieGrid

Movie 选项卡现在还是空的。我们需要在该选项卡里定义一个有合适列的网格列表。

首先，在 *PersonColumns.cs* 旁边的 *PersonMovieColumns.cs* 文件中，定义需要在网格列表使用的的列：

```cs
namespace MovieTutorial.MovieDB.Columns
{
    using Serenity.ComponentModel;
    using System;

    [ColumnsScript("MovieDB.PersonMovie")]
    [BasedOnRow(typeof(Entities.MovieCastRow))]
    public class PersonMovieColumns
    {
        [Width(220)]
        public String MovieTitle { get; set; }
        [Width(100)]
        public Int32 MovieYear { get; set; }
        [Width(200)]
        public String Character { get; set; }
    }
}
```

然后，在 *PersonGrid.ts* 旁边的 *PersonMovieGrid.ts* 文件中定义一个 *PersonMovieGrid* 类：

```ts
namespace MovieTutorial.MovieDB {

    @Serenity.Decorators.registerClass()
    export class PersonMovieGrid extends Serenity.EntityGrid<MovieCastRow, any>
    {
        protected getColumnsKey() { return "MovieDB.PersonMovie"; }
        protected getIdProperty() { return MovieCastRow.idProperty; }
        protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }
        protected getService() { return MovieCastService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
```

实际上，我们使用 MovieCast 服务查找人员所参演的影片列表。

最后的步骤是在 PersonDialog.ts 实例化该网格列表：

```ts
@Serenity.Decorators.registerClass()
@Serenity.Decorators.responsive()
export class PersonDialog extends Serenity.EntityDialog<PersonRow, any> {
    protected getFormKey() { return PersonForm.formKey; }
    protected getIdProperty() { return PersonRow.idProperty; }
    protected getLocalTextPrefix() { return PersonRow.localTextPrefix; }
    protected getNameProperty() { return PersonRow.nameProperty; }
    protected getService() { return PersonService.baseUrl; }

    protected form = new PersonForm(this.idPrefix);

    private moviesGrid: PersonMovieGrid;

    constructor() {
        super();

        this.moviesGrid = new PersonMovieGrid(this.byId("MoviesGrid"));
        this.tabs.on('tabsactivate', (e, i) => {
            this.arrange();
        });
    }
}
```

记得我们的模板在 movies 选项卡下有一个 id 为 *~_MoviesGrid* 的 div，我们在该 div 中创建了 PersonMovie 网格列表。

> this.ById("MoviesGrid") 是一个特殊的模板组件方法。*$('#MoviesGrid')* 在这里不能工作，因为实际上 div 有一些像 *PersonDialog17_MoviesGrid* 的 ID。`~_` 在模板中被替换为容器组件的唯一 ID。

我们还为 jQuery UI 选项卡附加 OnActivate 事件，并调用对话框的 Arrange 方法。这是解决 SlickGrid 初始创建在不可见的选项卡的问题，通过 Arrange 触发 SlickGrid 的布局来解决该问题。

OK, 现在我们可以在 Movies 选项卡中看到影片列表，但是有些奇怪：

![Person With Movies Unfiltered](img/mdb_person_cast3.png)

### 筛选出人员所参演的影片

不，Carrie-Anne Moss 并没有扮演以上三个角色。由于我们还没有告诉该应用什么过滤器，现在这个网格列表显示所有的影片演员记录。

PersonMovieGrid 应该知道它该显示哪个人员的电影记录。因此我们添加一个 *PersonID* 属性到该网格列表。该 *PersonID* 应该通过某种方式传递给列表服务进行过滤。

```ts
namespace MovieTutorial.MovieDB
{
    @Serenity.Decorators.registerClass()
    export class PersonMovieGrid extends Serenity.EntityGrid<MovieCastRow, any>
    {
        protected getColumnsKey() { return "MovieDB.PersonMovie"; }
        protected getIdProperty() { return MovieCastRow.idProperty; }
        protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }
        protected getService() { return MovieCastService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getButtons() {
            return null;
        }

        protected getInitialTitle() {
            return null;
        }

        protected usePager() {
            return false;
        }

        protected getGridCanLoad() {
            return this.personID != null;
        }

        private _personID: number;

        get personID() {
            return this._personID;
        }

        set personID(value: number) {
            if (this._personID != value) {
                this._personID = value;
                this.setEquality(MovieCastRow.Fields.PersonId, value);
                this.refresh();
            }
        }
    }
}
```

> 我们使用 ES5 (EcmaScript 5) 的属性(get/set) 特性。它与 C# 的属性非常相似。

我们把人员 ID 存储在一个私有变量中。当它改变时，我们还使用 SetEquality 方法（将被发送到列表服务）为 PersonId 字段设置一个相等过滤器，并刷新获取更新。

> 相等过滤器是使用快速过滤器项目的列表请求参数。

当网格列表调用列表服务时，重写 GetGridCanLoad 方法允许我们做一些控制。如果我们没有重写它，当创建一个新的人员时，由于还没有 PersonID（它为 null），网格列表将加载所有的演员记录。

> 如果相等过滤器的参数为 null，List handler 将忽略相等过滤器的参数，就像快速过滤器下拉列表为空时，所有的记录都被显示出来。

通过重写三个方法，我们还做了三个改变：一、从工具栏（getButtons）中删除所有按钮；二、从网格列表（*getInitialTitle*）删除作为选项卡的标题，三、删除分页功能（usePager），一个人不可能参演一百万部电影吧？。

### 在 PersonDialog 设置 PersonMovieGrid 的 PersonID

如果没有设置网格列表的 PersonID 属性，它将总是为 null，并且不会加载记录。我们应该在 Person 对话框的 afterLoadEntity 方法中设置它。

```ts
namespace MovieTutorial.MovieDB
{
    // ...
    export class PersonDialog extends Serenity.EntityDialog<PersonRow>
    {
        // ...
        protected afterLoadEntity()
        {
            super.afterLoadEntity();

            moviesGrid.personID = this.entityId;
        }
    }
}
```

在实体或新实体被加载到对话框之后调用 *afterLoadEntity*。

> 请注意，实体是在后一阶段被加载的，因此把它放在对话框的构造函数中是没有用的。

*this.EntityId* 引用当前加载实体的标识值。在新记录的情况下，它的值为 null。

> 在对话框生命周期内，AfterLoadEntity 和 LoadEntity 可能被调用多次，因此避免在这些事件中创建一些子对象，否则你会有多个创建对象的实例。这就是为什么我们在对话框构造函数中创建网格列表的原因。

![Person With Movies Filtered](img/mdb_person_movies.png)

### 调整 Movies 选项卡大小

你可能已经注意到，当你切换到 Movies 选项卡时，对话框高度有点不够。这是由于对话框设置为自动高度，并且网格列表默认高度是 200px。当你切换到 Movies 选项卡，表单被隐藏，因此对话框调整为 Movies 网格列表高度。

在 site.less 编辑 *s-MovieDB-PersonDialog* css：

```css
.s-MovieDB-PersonDialog {
    > .size { width: 650px; }
    .caption { width: 150px; }
    .s-PersonMovieGrid > .grid-container { height: 287px; }
}
```


