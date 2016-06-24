# 列表页 

Serene 有 Northwind 数据库的列表和编辑页面,让我们来看看 Northwind 菜单下的 Products 页面。

![Products Page Initial](img/products_page_initial.png)

在这里我们看到按产品名称 （初始排序顺序） 排序的产品列表。

> Grid 组件使用的是 SlickGrid，并自定义其主题。关于 SlickGrid 详见：

> https://github.com/mleibman/SlickGrid

你可以通过单击列标题更改顺序。若要按降序排序，请再次单击相同的列标题。

要按多个列进行排序，可以使用 Shift + Click。

这是先按 Category 列然后用 Supplier 列进行排序的结果：

![Products Category Supplier Sort](img/products_category_supplier.png)

当你更改排序顺序时，列表由一个 AJAX 请求服务加载数据。 

> 当你第一次打开页面，初始记录也是通过AJAX调用加载数据。

默认情况下列表加载记录的大小是每页100条，只会从服务器加载当前页面的数据。可在 列表左下角 设置每页显示数据的大小。

在列表的左上角，你可以输入一些关键字进行搜索。

例如，输入 *coffee* 查找名称中有 coffee 的产品。

![Products Coffee Search](img/products_coffee_search.png)

它使用产品名称字段搜索，也可以使用另一个或多个字段进行快速搜索，我们将在后面的章节进行详细介绍。

在列表右上角，有 *Supplier* 和 *Category* 筛选条件。

> 下拉列表组件使用的是 Select2，详见： 

> https://github.com/select2/select2

选择 *Seafood* 作为 *Category* 的过滤条件，结果将只显示该类别的产品。

![Products Seafood](img/products_seafood.png)

> 所有的排序、分页和过滤都是在服务器端进行,由 Serenity 生成动态 SQL 进行查询。

也可以在网格右下角单击 *编辑筛选* 添加列筛选条件。

![Products Edit Filter](img/products_edit_filter.png)

在这里，通过单击 *增加筛选条件* 你可以添加列表的任意列作为过滤条件，只须设置列名，过滤操作，条件值。 

根据列类型，筛选条件有一些是简单的文本框，还有一些是下拉列表或其他自定义控件。

另外，也可以通过点击 *and* 修改改为 *or*。 

你还可以通过点击括号来调整筛选条件间的行距。





