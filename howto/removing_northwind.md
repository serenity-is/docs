
# 如何删除 Serene 的 Northwind 及其他示例？

当你以 Northwind 为样本开发完自己的项目后，你会想从项目中移除 Northwind 和其他示例模块。

这里将介绍如何移除它们。

假设你的解决方案名称是 *MyProject* ，因此在你的解决方案中有 *MyProject.Web* 项目。

在 Visual Studio 中执行如下步骤：


### 移除项目文件

* 移除 *MyProject.Web/Modules/AdminLTE* 文件夹。这将删除所有主题示例相关的服务器端代码。

* 移除 *MyProject.Web/Modules/BasicSamples* 文件夹。这将删除所有基本示例的服务器端代码。

* 移除 *MyProject.Web/Modules/Northwind* 文件夹。这将删除所有 Northwind 相关的服务器端代码。

### 移除导航项目

* 打开 *MyProject.Web/Modules/Common/Navigation/NavigationItems.cs*，删除所有含 *Northwind*、*Basic Samples* 和 *Theme Samples* 的行，并删除下面两行代码：

```
using Northwind = MovieTutorial.Northwind.Pages;
using Basic = MovieTutorial.BasicSamples.Pages;
```

### 移除迁移脚本

删除 *MyProject.Web/Modules/Common/Migrations/NorthwindDB/* 文件夹下的所有文件。

从 *MyProject.Web/App_Start/ SiteInitialization.Migrations.cs* 的下面行中删除 "Northwind" 。

```cs
private static string[] databaseKeys = new[] { "Default", "Northwind" };
```

同样，从 *web.config* 删除 *Northwind* 连接字符串。

```xml
<add name="Northwind" connectionString="Data Source=(LocalDb)\v11.0; 
    Initial Catalog=MovieTutorial_Northwind_v1; 
    Integrated Security=True" 
    providerName="System.Data.SqlClient" />
```

### 移除 LESS 记录

* 打开 *MyProject.Web/Content/site/site.less* 文件，删除下面的代码：
    
```less
@import "site.basicsamples.less";
@import "site.northwind.less";
```

* 删除 *MyProject.Web/Content/site/site.basicsamples.less* 文件。
* 删除 *MyProject.Web/Content/site/site.northwind.less* 文件。

### 移除本地化文本

* 打开 *MyProject.Web/Modules/Texts.cs* 文件，并删除下面的代码：

```cs
            public static LocalText NorthwindPhone = "...";
            public static LocalText NorthwindPhoneMultiple = "...";
```

* 删除文件夹 *MyProject.Web/Scripts/site/texts/northwind*。
* 删除文件夹 *MyProject.Web/Scripts/site/texts/samples*。

### 移除 Northwind / Samples 生成的代码

* 展开 *MyProject.Web/Modules/Common/Imports/ ServerTypings/ServerTypings.tt*。删除以 *Northwind* 或 *BasicSamples* 开头的文件。
 
### 移除控制面板（Dashboard）中的 Northwind 数字

打开 *DashboardPage.cs*，删除 using 行：

```cs
using Northwind;
using Northwind.Entities;
```

由于控制面板从 Northwind 表获取数据，你应该把 *Index()* 操作修改为：

```cs
[Authorize, HttpGet, Route("~/")]
public ActionResult Index()
{
    var cachedModel = new DashboardPageModel()
    {
    };

    return View(MVC.Views.Common.Dashboard.DashboardIndex, cachedModel);
}
```

> 你应该替换该模块为你网站的具体内容，并相应地修改 DashboardIndex。

打开 *DashboardIndex.cshtml*，清除包含 "Northwind" 的 *href* 属性内容，如：

```html
<a href="~/Northwind/Order?shippingState=1"></a>
<a href=""></a>
```

### 生成项目并运行 T4 (.tt) 模板

* 现在重新生成你的解决方案；

* 在执行下一步骤前，请确保 *成功* 生成；

* 点击 *生成* 菜单，然后点击 *转换所有模板*；

* 再次重新生成解决方案。

* 在整个解决方案中搜索 *Northwind*、*Basic Samples* 和 *Theme Samples*，应该找不到任何结果。

* 运行项目，现在已经没有 Northwind 和 Sample 菜单。


### 移除 Northwind 表

Northwind 的表都在一个单独的数据库中，因此，删除该数据库即可。