# 更新 Serenity 程序包

当我开始写这个教程时，Serenity （NuGet 程序包中含 Serenity 程序集和标准的脚本库）和 Serene （应用程序模板）是 2.1.8 版本。

当你阅读本教程时，你可能在使用更高的版本，所以此时你还不需要更新 serenity 。

但是，我想向你演示如何更新 Serenity 的 NuGet 程序包，以便你在将来能顺利更新版本。

比起使用 Nuget程序包管理器，我更喜欢使用程序包管理控制台，因为命令行操作更快。

所以，选择 *视图 -> 其他窗体 -> 程序包管理控制台*。

输入：

> Update-Package Serenity.Web

由于依赖引用，也将更新 *MovieTutorial.Web* 项目的下列 NuGet 程序包：

```txt
Serenity.Core
Serenity.Data
Serenity.Data.Entity
Serenity.Services
```

要更新 Serenity.CodeGenerator （含 sergen.exe），请输入：

> Update-Package Serenity.CodeGenerator

Serenity.CodeGenerator 也安装在 MovieTutorial.Web 项目中。

> 在更新期间，如果 NuGet 提示要覆盖修改一些脚本文件，你可以放心地同意，除非你想手工修改 Serenity 的脚本文件(我建议你避免这样做)。

现在重新生成你的解决方案，它应该能生成成功。

> Serenity 可能会不时地发生重大改变，但尽量把变化保持在最低限度，尽管如此，你可能还是需要在应用程序代码中进行几处手工的修改。

> 这些更改都被记录在更新日志的  [BREAKING CHANGE] 标签中：
> https://github.com/volkanceylan/Serenity/blob/master/CHANGELOG.md

> 在更新后，如果仍有问题，欢迎使用 issue 反馈给我们：
> https://github.com/volkanceylan/Serenity/issues


### 哪些内容会更新

更新 Serenity 的 NuGet 程序包以获取最新版本的 Serenity 程序集。

也可以更新一些其他的第三方程序包，例如： ASP.NET MVC、 FluentMigrator、Select2.js、SlickGrid 等。

> 请不要更新 Select2.js 3.5.1 之后的版本，因为它有一些 jQuery 验证的兼容问题。

Serenity.Web 程序包还提供一些静态脚本和 css 资源，如：

```
Content/serenity/serenity.css
Scripts/saltarelle/mscorlib.js
Scripts/saltarelle/linq.js
Scripts/serenity/Serenity.CoreLib.js
Scripts/serenity/Serenity.Script.UI.js
```

因此，这些或更多的资源都将在 MovieApplication.Web 中更新。


### 哪些内容不会更新 （或不能自动更新）

更新 Serenity 程序包，是更新了 Serenity 程序集和大部分静态脚本，但并不是所有的 *Serene* 模板内容都会被更新。

我们努力让更新程序变得尽可能地简单，但 Serene 只是一个项目模板，而不是一个静态的程序包，你的应用程序是一个可定制的 Serene 副本。

你可能修改了应用程序的源代码，所以更新一个有旧版本 Serene 模板的应用程序并不像听起那么简单。

所以有时你可能需要创建一个含最新 Serene 模板的新应用程序，用它和你的应用程序进行比较，并手工合并你需要的功能。

通常情况下，更新 Serenity 程序包就足够了，Serene 本身是不需要更新的，除非你需要最新版本 Serene 的功能。

> 我们有把 Serene 模板也集成到一个 NuGet 程序包的计划，但是我们不知道在更新应用程序时如何处理你的更改，例如，公共代码的导航菜单项，如果你删除了 Northwind 相关导航代码，但是在更新时，我们是要重新加上它吗？欢迎你给我们提出宝贵建议……