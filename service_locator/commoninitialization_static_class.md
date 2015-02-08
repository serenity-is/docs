# CommonInitialization Static Class

[**namespace**: *Serenity.Web*, **assembly**: *Serenity.Web*]

If you are going to use defaults in a web environment, instead of doing the service locator setup and some other configuration manually, you may just call *CommonInitialization.Run()* in your application start method. CommonInitialization registers default implementations for some of Serenity abstractions.

```cs
CommonInitialization.Run();
```

> If there is already a provider registered for some abstraction, CommonInitialization doesn't override them.

This method contains calls to some other methods to initialize Serenity platform defaults:

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

> CommonInitialization.InitializeServiceLocator and other methods may also be used individually instead of calling CommonInitialization.Run.

*InitializeServiceLocator()*, registers a MunqContainer instance as the default IDependencyResolver implementation.

