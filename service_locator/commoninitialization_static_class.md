# CommonInitialization 静态类

[**命名空间**: *Serenity.Web*, **程序集**: *Serenity.Web*]

如果要在 web 环境中使用默认设置，而不是手动组织服务定位器和其他配置，你只需在应用程序启动方法中调用 *CommonInitialization.Run()*。CommonInitialization 为一些 Serenity 抽象注册的默认实现。  

```cs
CommonInitialization.Run();
```

> 如果已经为一些抽象注册了提供者，CommonInitialization 不会覆盖它们。

此方法包含调用一些其他的方法来初始化 Serenity 平台的默认值：

```
public static class CommonInitialization
{
    public static void Run()
    {
        InitializeServiceLocator();
        InitializeSelfAssemblies();
        InitializeConfigurationSystem();
        InitializeCaching();
        InitializeLocalTexts();
        InitializeDynamicScripts();
    }

    public static void InitializeServiceLocator()
    {
        if (!Dependency.HasResolver)
        {
            var container = new MunqContainer();
            Dependency.SetResolver(container);
        }
    }

    //...
}
```

> CommonInitialization.InitializeServiceLocator 和其他方法也可以单独地使用，而不需要调用 CommonInitialization.Run。

*InitializeServiceLocator()* 注册一个 MunqContainer 实例作为 IDependencyResolver 的默认实现。 

