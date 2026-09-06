# Dependency Injection

Serenity uses the dependency injection pattern to abstract its dependencies and to make it possible to work with your chosen libraries and service providers.

Serenity is deeply integrated with the built-in Dependency Injection feature of ASP.NET Core.

We provide some extension methods to easily configure the default Serenity services in *Serenity.Extensions.DependencyInjection* namespace of some Serenity assemblies:

| assembly              | class |
| --------------------- | ----- |
| Serenity.Net.Core     | [CoreServiceCollectionExtensions](../api/dotnet/Serenity.Net.Core/Serenity.Extensions.DependencyInjection/CoreServiceCollectionExtensions.md) |
| Serenity.Net.Services | [DataServiceCollectionExtensions](../api/dotnet/Serenity.Net.Services/Serenity.Extensions.DependencyInjection/DataServiceCollectionExtensions.md) |
| Serenity.Net.Services | [EntityServiceCollectionExtensions](../api/dotnet/Serenity.Net.Services/Serenity.Extensions.DependencyInjection/EntityServiceCollectionExtensions.md) |
| Serenity.Net.Services | [ServiceCollectionExtensions](../api/dotnet/Serenity.Net.Services/Serenity.Extensions.DependencyInjection/ServiceCollectionExtensions.md) |
| Serenity.Net.Web      | [DynamicScriptServiceCollectionExtensions](../api/dotnet/Serenity.Net.Web/Serenity.Extensions.DependencyInjection/DynamicScriptServiceCollectionExtensions.md) |
| Serenity.Net.Web      | [UploadServiceCollectionExtensions](../api/dotnet/Serenity.Net.Web/Serenity.Web/UploadServiceCollectionExtensions.md)| 

These extension methods are generally called inside the `Startup.cs` file to register default implementations of the Serenity service abstractions:

```cs
services.AddServiceHandlers();
services.AddDynamicScripts();
services.AddCssBundling();
services.AddScriptBundling();
services.AddUploadStorage();
```

All these extensions use try `TryAddSingleton` variant of registration calls, so if you register another provider for a particular service before calling them, they won't override your registration:

```cs
// here we register the MyCustomScriptBundleManager as the custom
// implementation of the IScriptBundleManager service
collection.AddSingleton<IScriptBundleManager, MyCustomScriptBundleManager>();

// in the line below AddScriptBundling will also try to register the default
// implementation of IScriptBundleManager, but as it will use the
// TryAddSingleton variant, it won't override MyCustomScriptBundleManager
services.AddScriptBundling();
```

## IServiceResolver

Sometimes you need to resolve a service *on demand* rather than injecting it directly — for example when the service you need has a shorter lifetime than the one you are in (resolving a scoped or transient service from a singleton), or when you want a fresh instance each time.

The [IServiceResolver&lt;TService&gt;](../api/dotnet/Serenity.Net.Core/Serenity/IServiceResolver-1.md) interface is a generic version of `IServiceProvider` that resolves a single service type:

```cs
public interface IServiceResolver<TService> where TService : notnull
{
    TService Resolve();
}
```

Its default implementation, [ServiceResolver&lt;TService&gt;](../api/dotnet/Serenity.Net.Core/Serenity.Extensions.DependencyInjection/ServiceResolver-1.md), wraps the `IServiceProvider` and calls `GetRequiredService<TService>()`. It is registered by `AddServiceResolver()`, which is called internally by `AddServiceHandlers()`:

```cs
services.AddServiceHandlers(); // this internally calls AddServiceResolver
```

If the service was registered as **transient**, every `Resolve()` call returns a new instance, so `IServiceResolver<T>` effectively acts as a factory.

For example, the movie tutorial's save handler needs to create/update/delete the child `MovieCast` records while saving a `Movie`. Resolving the child handlers on demand makes it easy to get a fresh handler instance for each operation:

```cs
public class MovieSaveHandler(IRequestContext context,
    IServiceResolver<IMovieCastDeleteHandler> movieCastDelete,
    IServiceResolver<IMovieCastSaveHandler> movieCastSave) : SaveRequestHandlerAsync<...>
{
    // ...
    protected override async Task AfterSaveAsync(CancellationToken cancellationToken = default)
    {
        await base.AfterSaveAsync(cancellationToken);

        // ...
        await movieCastDelete.Resolve().DeleteAsync(UnitOfWork,
            new() { EntityId = row.MovieCastId }, cancellationToken);
        // ...
    }
}
```

## Auto-Registration with Attributes

Instead of writing `services.AddSingleton<IMyService, MyService>();` for every service, you can mark an implementation type with one of the auto-registration attributes and let Serenity register it for you:

* [RegisterSingleton](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/RegisterSingletonAttribute.md)
* [RegisterScoped](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/RegisterScopedAttribute.md)
* [RegisterTransient](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/RegisterTransientAttribute.md)

They all derive from [RegisterServiceAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/RegisterServiceAttribute.md):

```cs
[RegisterSingleton]
public class MyService : IMyService
{
    // ...
}
```

By default the service type is **auto-detected**: the system looks at the interfaces the class implements and uses the one that matches the `I{ClassName}` naming convention (or the only suitable interface). Interfaces in the `System.` / `Microsoft.` namespaces and interfaces deriving from `IRequestHandler` are skipped — request handlers are registered separately by `AddServiceHandlers`.

You can specify the service types explicitly, or register the type as itself, through the attribute's options:

```cs
[RegisterSingleton(typeof(IMyService), typeof(IMyOtherService))]
public class MyService : IMyService, IMyOtherService { }

[RegisterTransient(Types = [], AsSelf = true)]
public class MyHelper { }
```

The base attribute also supports:

* `SkipExisting` (default `true`) — uses `TryAdd...`, so an existing registration is not overridden.
* `ReplaceExisting` — replaces an existing registration (ignores `SkipExisting`).
* `Order` — registration order when multiple implementations of the same service type exist.
* `Key` — registers as a keyed service.

To register all attributed services, call `AddAutoRegisteredServices()` in `Startup.ConfigureServices` — it should be the **last line** of the method:

```cs
public void ConfigureServices(IServiceCollection services)
{
    // ... all other registrations ...

    services.AddAutoRegisteredServices(); // should be the last line
}
```

It scans the type source for types carrying one of the `RegisterService` attributes and registers them with the appropriate lifetime.

See the document below for more info about DI in the ASP.NET Core framework:

[Dependency injection in ASP.NET Core - learn.microsoft.com](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-10.0)

> Before v5, Serenity used to have a service location container, but since then we completely migrated to .NET DI.