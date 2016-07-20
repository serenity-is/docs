# 如何更新 Serenity 的 NuGet 程序包？

Serene 模板包含下面的 Serenity  NuGet 程序包引用：

```
Serenity.Core
Serenity.Data
Serenity.Data.Entity
Serenity.Services
Serenity.Web
Serenity.CodeGenerator
```

要更新到最新版本的 Serenity 程序包，打开程序包管理器控制台（点击 视图 -> 其他窗口 -> 程序包管理器控制台）。

并输入：

```ps
Update-Package Serenity.Web
Update-Package Serenity.CodeGenerator
```

更新这些包的同时也将更新其他的程序包（由于依赖引用关系）。