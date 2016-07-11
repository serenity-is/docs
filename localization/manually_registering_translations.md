# 手工注册翻译

你可以在应用程序的启动方法中向本地化文本注册表（local text registry）添加翻译。

这些翻译可来源自数据库表、xml 文件、嵌入的资源等。

```cs
void Application_Start()
{
    // ...
    var registry = Dependency.Resolve<ILocalTextRegistry>();
    registry.Add("es", "Dialogs.YesButton", "Sí");
    registry.Add("fr", "Dialogs.YesButton", "Oui");
    // ..
}
```


