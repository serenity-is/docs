# 处理 Movie 的导航

### 设置导航项标题和图标

当 Sergen 为影片（Movie）表生成代码时，它同时也创建了一个导航项目实体。在 Serene 中，导航项目使用专门的程序集特性创建。

在同一文件夹中打开 *MoviePage.cs*，在顶部你将找到下面这行代码：

```cs
[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "MovieDB/Movie", 
    typeof(MovieTutorial.MovieDB.Pages.MovieController))]

namespace MovieTutorial.MovieDB.Pages
{
    //...
```

该特性的第一个参数是该导航项目的显示次序。因为我们在 Movie 菜单中只有一个导航项目，所以我们不需要次序。

第二个参数是 “节（Section）标题/连接（Link）标题” 格式的导航标题。节和导航项目是以斜杠(/)分隔。

让我们将其更改为 *Movie Database/Movies* 。

```cs
[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Movie Database/Movies", 
    typeof(MovieTutorial.MovieDB.Pages.MovieController), icon: "icon-camrecorder")]

namespace MovieTutorial.MovieDB.Pages
{

//..
```

![Navigation Item Title and Icon](img/mdb_movie_navtitle.png)

我们也将导航项的图标修改为 *icon-camcorder*。Serene 模板有两种字体图标的设置：

更多 simple line icons 和其 css 类，请访问下面的连接：

http://thesabbir.github.io/simple-line-icons/

FontAwesome 可在这里查看：

https://fortawesome.github.io/Font-Awesome/icons/

> Serene 中 *Theme Samples / UI Elements / Icons* 下有一个包含这些图标集的列表页面。

### 对导航节（Navigation Sections）排序

由于我们的 *Movie Database* 节是最后自动生成的，所以它显示在导航菜单的底部。

我们将把它移到 Northwind 菜单前面。

正如我们最近看到的，Sergen 在 *MoviePage.cs* 创建了一个导航项目。如果导航项目都分散到像这样的页面，将很难看到大图(所有导航项目的列表)并难以对它们排序。

因此我们把它移到一个集中的位置：*MovieTutorial.Web/Modules/Common/Navigation/NavigationItems.cs*。

我们只须从 *MoviePage.cs* 剪切下面的行：

```cs
[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Movie Database/Movies", 
    typeof(MovieTutorial.MovieDB.Pages.MovieController), icon: "icon-camrecorder")]
```

把它移到 *NavigationItems.cs* ，并作如下修改：

```
using Serenity.Navigation;
using Northwind = MovieTutorial.Northwind.Pages;
using Administration = MovieTutorial.Administration.Pages;
using MovieDB = MovieTutorial.MovieDB.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "",
    icon: "icon-speedometer")]

[assembly: NavigationMenu(2000, "Movie Database", icon: "icon-film")]
[assembly: NavigationLink(2100, "Movie Database/Movies", 
    typeof(MovieDB.MovieController), icon: "icon-camcorder")]

[assembly: NavigationMenu(8000, "Northwind", icon: "icon-anchor")]
[assembly: NavigationLink(8200, "Northwind/Customers", 
    typeof(Northwind.CustomerController), icon: "icon-wallet")]
[assembly: NavigationLink(8300, "Northwind/Products", 
    typeof(Northwind.ProductController), icon: "icon-present")]
// ...
```

我们在这里还声明导航菜单(Movie Database)和使用 *film* 图标。当你没有明确定义导航菜单，Serenity 将隐式创建一个菜单，但在这种情况下，你不能自己对菜单排序或设置菜单图标。

我们指定它的显示顺序为 *2000*，所以这个菜单将显示在 Dashboard(1000) 连接之后，但在 Northwind(8000) 菜单之前。

我们指定 *Movies* 连接的显示顺序为 *2100*，但现在也不重要了，因为我们 *Movie Database* 菜单下只有一个导航项目。

> 第一级的连接和导航菜单首先根据它们的显示顺序排序，然后第二级兄弟结点间的连接排序。

这是更改之后的样子：

![Movie Database Moved](img/mdb_movie_navmoved.png)


### 使用 Visual Studio 解决一些问题

你可能已经注意到，Visual Studio 在站点运行时，不允许你修改代码。当你停止调试时，网站也停止了，所以你不能在重新生成之后打开浏览器并刷新页面。

为了解决这个问题，我们需要禁用 *编辑并继续（Edit And Continue）* (不知道为什么)。

在 *MovieTutorial.Web* 项目中右键，点击 *属性*，在 *Web 选项卡* 中，取消 *Enable Edit And Continue under Debuggers*。

> 不幸的是，在 visual studio 2015 Update 2 中该方法不能工作。唯一的变通方案是在不调试状态下执行，例如，使用 Ctrl+F5 替换 F5。

此外，在这种情况下，你的网站顶部的蓝色进度栏（即 Pace.js 动画）总是保持运行就像它仍在加载东西。这是由于 Visual Studio 的 *Browser Link* 功能。要禁用它，需要在 Visual Studio 工具栏找到看上去像刷新的按钮（在含 Chrome 名称的调试图标旁边），单击其下拉列表，并取消勾选 *Enable Browser Link*。

也可以在 web.config 设置中禁用它。

```xml
<appsettings>
    <add key="vs:EnableBrowserLink" value="false" />
</appsettings>
```

> Serene 1.5.4 及后续版本都已经在 web.config 中默认配置了此设置，因此你将不会遇到这样的问题。