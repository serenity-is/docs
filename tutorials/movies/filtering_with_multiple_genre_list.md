# 筛选具有多个流派的列表

记得当每部影片只有一个流派时，我们可以很容易实现快速过滤：在 GenreId 属性加入了 [QuickFilter] 特性即可。

让我们试着在 MovieColumns.cs 做类似修改：

```
[ColumnsScript("MovieDB.Movie")]
[BasedOnRow(typeof(Entities.MovieRow))]
public class MovieColumns
{
    //...
    [Width(200), GenreListFormatter, QuickFilter]
    public List<Int32> GenreList { get; set; }
}
```

只要在 Genres 中输入流派就会得到该错误：

![Invalid Column GenreList](img/mdb_genrelist_invalid.png)

ListHandler 尝试使用 GenreList 字段过滤，但是在数据库中并没有这样的字段，因此我们得到这个错误。

> 事实上，LinkingSetRelation 会拦截此过滤器并把它转换为 EXISTS 子查询，但是列行为（list behaviors）还没有实现这样的功能，也许会在以后版本…… 

因此，我们现在就用某种方式来处理它。


### 声明 MovieListRequest 类型

因为我们打算做一些不规范的事，例如通过关联表（linking set table）的值来过滤时，我们需要防止 ListHandler 在 GenreList 属性中过滤自身。

我们可以使用一个访问者模式处理请求 *条件（Criteria）* 对象（它类似于表达式目录树）和处理 GenreList 自身，但这有点复杂。所以现在我会使用一个简单的方式。

让我们看一个含标准的 *ListRequest* 对象的子类，我们将在这里添加流派过滤器参数。在 *MovieRepository.cs* 文件旁边添加 *MovieListRequest.cs* 文件：

```cs
namespace MovieTutorial.MovieDB
{
    using Serenity.Services;
    using System.Collections.Generic;

    public class MovieListRequest : ListRequest
    {
        public List<int> Genres { get; set; }
    }
}
```

在列表请求对象中，我们添加一个 *Genres* 属性，它将保存我们想在影片中过滤的 *流派（Genres）* 选项。


### 为新请求类型修改 Repository/Endpoint

为使我们的列表处理程序（list handler）和服务使用新的列表请求类型，需要在几个地方做修改。

先从 *MovieRepository.cs* 开始：

```cs
public class MovieRepository
{
    //...
    public ListResponse<MyRow> List(IDbConnection connection, MovieListRequest request)
    {
        return new MyListHandler().Process(connection, request);
    }

    //...
    private class MyListHandler : ListRequestHandler<MyRow, MovieListRequest> { }
}
```

若要使用新类型，而不是 ListRequest，在 List 方法中，我们把 ListRequest 改为 MovieListRequest，并在 MyListHandler 中添加一个泛型参数。

在另一文件 *MovieEndpoint.cs* 中也做一些小修改，该类实际上是 web 服务：

```cs
public class MovieController : ServiceEndpoint
{
    //...
    public ListResponse<MyRow> List(IDbConnection connection, MovieListRequest request)
    {
        return new MyRepository().List(connection, request);
    }
}
```

现在是时候生成和转换模板，以使我们的 MovieListRequest 对象及相关服务方法能在客户端生效。


### 将快速过滤器移到流派参数

我们仍然有同样的错误，因为快速过滤器并不知道我们刚添加到列表的请求类型，还一直使用着 *Criteria* 参数。

需要拦截快速过滤项并将流派列表移到 *MovieListRequest* 的 *流派（Genres）* 属性。

编辑 *MovieGrid.ts*：

```ts
export class MovieGrid extends Serenity.EntityGrid<MovieRow, any> {

    //...
    protected getQuickFilters() {
        let items = super.getQuickFilters();

        var genreListFilter = Q.first(items, x =>
            x.field == MovieRow.Fields.GenreList);

        genreListFilter.handler = h => {
            var request = (h.request as MovieListRequest);
            var values = (h.widget as Serenity.LookupEditor).values;
            request.Genres = values.map(x => parseInt(x, 10));
            h.handled = true;
        };

        return items;
    }
}
```

getQuickFilters 是一个获取此网格列表的快速过滤器对象列表的方法。

默认情况下，网格列表枚举 MovieColumns.cs 中所有含 [QuickFilter] 特性的属性，并为其创建合适的快速过滤器对象。

我们从基类获取 QuickFilter 对象列表开始。

```ts
let items = super.getQuickFilters();
```

然后找到 *GenreList* 属性的快速过滤器对象：

```ts
var genreListFilter = Q.first(items, x =>
    x.field == MovieRow.Fields.GenreList);
```

实际上现在只有一个快速过滤器。

下一步是设置 *handler* 方法。 在提交到列表服务之前，快速过滤器对象读取编辑器值并将其应用到请求的 *Criteria* （如果有多个） 或 *EqualityFilter* （如果单个值）参数。

```ts
genreListFilter.handler = h => {
```

然后我们获得当前 *ListRequest* 引用：

```ts
var request = (h.request as MovieListRequest);
```

并读取检索编辑器（LookupEditor）中的当前值：

```ts
var values = (h.widget as Serenity.LookupEditor).values;
```

把该值设置到 *request.Genres* 属性：

```
request.Genres = values.map(x => parseInt(x, 10));
```

这是一个字符串列表的值，我们需要将它们转换为整数。

最后一步是设置 *handled* 为 true，要禁用快速过虑器对象的默认行为，因此它将不会使用自己设置的 *Criteria* 或 *EqualityFilter*：

```ts
h.handled = true;
```

现在，我们将不再有 *无效的列名 GenreList* 的错误，但 Genres 过滤器还没有应用到服务器端。


### 在仓储（Repository）中处理流派的过滤

在 *MovieRepository.cs* 文件对 *MyListHandler* 做如下修改：

```cs
private class MyListHandler : ListRequestHandler<MyRow, MovieListRequest>
{
    protected override void ApplyFilters(SqlQuery query)
    {
        base.ApplyFilters(query);

        if (!Request.Genres.IsEmptyOrNull())
        {
            var mg = Entities.MovieGenresRow.Fields.As("mg");

            query.Where(Criteria.Exists(
                query.SubQuery()
                    .From(mg)
                    .Select("1")
                    .Where(
                        mg.MovieId == fld.MovieId &&
                        mg.GenreId.In(Request.Genres))
                    .ToString()));
        }
    }
}
```

*ApplyFilters* 是一个应用过滤器指定的 *Criteria* 和 *EqualityFilter* 请求参数表的方法。这里是应用自定义过滤器的好地方。

如果需要做任何过滤，我们首先要检查 *Request.Genres* 是否是 null 或空列表。

接下来，我们获得一个别名为 *mg* 的字段 *MovieGenresRow* 引用。

```
var mg = Entities.MovieGenresRow.Fields.As("mg");
```

这里需要说明一下，我们还没有覆盖 Serenity 实体系统。

让我们从还没有别名的 *MovieGenresRow.Fields* 开始：

```cs
var x = MovieGenresRow.Fields;
new SqlQuery()
  .From(x)
  .Select(x.MovieId)
  .Select(x.GenreId);
```

如果我们写类似上述的查询，它输出的 SQL 会是这样的：

```sql
SELECT t0.MovieId, t0.GenreId FROM MovieGenres t0
```

除非特别指出，Serenity 总是分配 *t0* 到行的主表。即使我们命名 *MovieGenresRow.Fields* 为变量 *x*，它的别名仍将是 *t0* 。

> 因为在编译时，*x* 不会存在并且 Serenity 已没有办法知道其变量的名称。Serenity 实体系统没有使用像 LINQ to SQL 或 Entity Framework 那样的表达式树。它使用非常简单的字符串/查询生成器。

所以，如果想要使用 *x* 作为别名，我们必须明确地声明：

```cs
var x = MovieGenresRow.Fields.As("x");
new SqlQuery()
  .From(x)
  .Select(x.MovieId)
  .Select(x.GenreId);
```

结果为:

```sql
SELECT x.MovieId, x.GenreId FROM MovieGenres x
```

在 *MovieRow* 实体的 *MyListHandler* 中，*t0* 已经被 *MovieRow* 字段使用。因此，为防止 *MovieGenresRow* 字段（名为 *fld*）的冲突，我需要把 *MovieGenresRow* 别名指定为 *mg*。

```
var mg = Entities.MovieGenresRow.Fields.As("mg");
```

我想实现的是这样的一个查询（就像我们会使用纯SQL）：

```
SELECT t0.MovieId, t0.Title, ... FROM Movies t0
WHERE EXISTS (
   SELECT 1 
   FROM MovieGenres mg 
   WHERE 
     mg.MovieId = t0.MovieId AND
     mg.GenreId IN (1, 3, 5, 7)
)
```

因此，我向 query 对象的 Where 方法添加 WHERE 过滤器，使用 EXISTS 条件：

```cs
query.Where(Criteria.Exists(
```

然后开始写子查询：

```cs
query.SubQuery()
    .From(mg)
    .Select("1")
```

为子查询添加 where 声明：

```
.Where(
    mg.MovieId == fld.MovieId &&
    mg.GenreId.In(Request.Genres))
```

> 其实这里 fld 包含 MovieRow 字段的别名 t0。

由于 *Criteria.Exists* 方法需要一个字符串，所以我需要在末尾使用 .ToString() 方法把子查询转换为字符串。

> 是的，我注意到应该添加一个接受子查询的重载……

```cs
.ToString()));
```

> 开始使用时，这种写法看上去可能有点陌生，但花点时间你就会明白，Serenity 查询系统与 SQL 有 99% 的相似。但它不能是具体的 SQL，因为我们需要在不同的语言（C#）工作。

现在，我们的 *GenreList* 属性过滤器就可以很好地工作了……