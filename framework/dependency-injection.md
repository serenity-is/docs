# Dependency Injection

Serenity uses the dependency injection pattern to abstract its dependencies and to make it possible to work with your chosen libraries and service providers.

Serenity is deeply integrated with the built-in Dependency Injection feature of ASP.NET Core.

We provide some extension methods to easily configure the default Serenity services in *Serenity.Extensions.DependencyInjection* namespace of some Serenity assemblies:

| assembly          | class |
| ----------------- | ----- |
| Serenity.Core     | [CoreServiceCollectionExtensions](../api/dotnet/Serenity.Net.Core/Serenity.Extensions.DependencyInjection/CoreServiceCollectionExtensions.md) |
| Serenity.Data     | [DataServiceCollectionExtensions](../api/dotnet/Serenity.Net.Data/Serenity.Extensions.DependencyInjection/DataServiceCollectionExtensions.md) |
| Serenity.Entity   | [EntityServiceCollectionExtensions](../api/dotnet/Serenity.Net.Entity/Serenity.Extensions.DependencyInjection/EntityServiceCollectionExtensions.md) |
| Serenity.Services | [ServiceCollectionExtensions](../api/dotnet/Serenity.Net.Services/Serenity.Extensions.DependencyInjection/ServiceCollectionExtensions.md) |
| Serenity.Web      | [DynamicScriptServiceCollectionExtensions](../api/dotnet/Serenity.Net.Web/Serenity.Extensions.DependencyInjection/DynamicScriptServiceCollectionExtensions.md) |
| Serenity.Web      | [UploadServiceCollectionExtensions](../api/dotnet/Serenity.Net.Web/Serenity.Web/UploadServiceCollectionExtensions.md)| 

These extension methods are generally called inside the `Startup.cs` file to register default implementations of the Serenity service abstractions:

```cs
services.AddServiceHandlers();
services.AddDynamicScripts();
services.AddCssBundling();
services.AddScriptBundling();
services.AddUploadStorage();
```

All these extensions use try `TryAddSingleton` variant of registration calls, so if you register another provider for a particular service before calling them, they won't override your registration:

```
// here we register the MyCustomScriptBundleManager as the custom
// implementation of the IScriptBundleManager service
collection.AddSingleton<IScriptBundleManager, MyCustomScriptBundleManager>();

// in the line below AddScriptBundling will also try to register the default
// implementation of IScriptBundleManager, but as it will use the
// TryAddSingleton variant, it won't override MyCustomScriptBundleManager
services.AddScriptBundling();
```

See the document below for more info about DI in the ASP.NET Core framework:

[Dependency injection in ASP.NET Core - learn.microsoft.com](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-7.0)

> Before v5, Serenity used to have a service location container, but since then we completely migrated to .NET DI.