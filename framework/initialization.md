# Initialization and Startup

A Serenity application is an ordinary ASP.NET Core application. It starts with the standard `Program.cs` / `Startup.cs` pair, and everything Serenity needs is wired up in `Startup.ConfigureServices` and `Startup.Configure`. Understanding this flow — especially how Serenity discovers your types — is the key to extending the framework.

## The Startup Class

When you create a project from the Serene/StartSharp template, `Initialization/Startup.cs` registers the Serenity services and configures the HTTP pipeline. The important parts of `ConfigureServices` look like this:

```cs
public void ConfigureServices(IServiceCollection services)
{
    services.AddApplicationPartsFeatureToggles(Configuration);
    services.AddApplicationPartsTypeSource();
    services.ConfigureSections(Configuration);

    // ... ASP.NET Core services (antiforgery, MVC, authentication, logging, etc.)

    services.AddSingleton<IDataMigrations, AppServices.DataMigrations>();
    services.AddSingleton<IPermissionService, AppServices.PermissionService>();
    services.AddUserProvider<AppServices.UserAccessor, AppServices.UserRetrieveService>();
    services.AddServiceHandlers();
    services.AddDynamicScripts();
    services.AddCssBundling();
    services.AddScriptBundling();
    services.AddUploadStorage();
    services.AddReporting();
}
```

And `Configure` sets up the request pipeline:

```cs
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    RowFieldsProvider.SetDefaultFrom(app.ApplicationServices);

    InitializeLocalTexts(app.ApplicationServices);

    app.UseRequestLocalization();
    // ... exception handling, security headers, HTTPS, static files

    app.UseRouting();
    app.UseAuthentication();
    app.UseAuthorization();

    app.UseDynamicScripts();

    app.UseEndpoints(endpoints => {
        endpoints.MapControllers();
    });

    app.ApplicationServices.GetRequiredService<IDataMigrations>().Initialize();
}
```

The two most important lines for this topic are the ones near the top of `ConfigureServices`:

```cs
services.AddApplicationPartsFeatureToggles(Configuration);
services.AddApplicationPartsTypeSource();
```

They register the **type source** and the **feature toggles** that almost every other Serenity service depends on.

## What Is a Type Source?

Many Serenity features are convention-based: request handlers, service behaviors, lookups, dynamic scripts, navigation items, and more are discovered by scanning the application's types rather than by listing them explicitly. The [ITypeSource](../api/dotnet/Serenity.Net.Core/Serenity.Abstractions/ITypeSource.md) interface is the abstraction for that discovery. It lives in the `Serenity.Abstractions` namespace and looks like this:

```cs
public interface ITypeSource
{
    IEnumerable<Attribute> GetAssemblyAttributes(Type attributeType);
    IEnumerable<Type> GetTypes();
    IEnumerable<Type> GetTypesWithInterface(Type interfaceType);
    IEnumerable<Type> GetTypesWithAttribute(Type attributeType);
}
```

- `GetTypes()` returns all types the source knows about.
- `GetTypesWithInterface(interfaceType)` returns types implementing a given interface, e.g. `IRequestHandler` or a service behavior interface.
- `GetTypesWithAttribute(attributeType)` returns types carrying a given attribute, e.g. `[NavigationLink]` or `[LookupScript]`.
- `GetAssemblyAttributes(attributeType)` returns assembly-level attributes, e.g. the `[assembly: NavigationLink(...)]` entries.

Serenity uses these methods to register request handlers, run behaviors, generate navigation, and build dynamic scripts — all automatically.

> Every service that needs type discovery takes `ITypeSource` through dependency injection, so you can replace or wrap the type source to change what Serenity sees.

## DefaultTypeSource

The classic implementation, [DefaultTypeSource](../api/dotnet/Serenity.Net.Core/Serenity.Abstractions/DefaultTypeSource.md), simply wraps a fixed list of assemblies that you pass in:

```cs
var typeSource = new DefaultTypeSource(new[]
{
    typeof(SomeTypeInMyApp).Assembly,
    typeof(SomeTypeInALibrary).Assembly,
});
```

Because the list is fixed, you had to keep it in sync manually whenever you added a project reference or a plugin assembly. Older templates used a custom `TypeSource` class in the application for this purpose.

## ApplicationPartsTypeSource

[ApplicationPartsTypeSource](../api/dotnet/Serenity.Net.Web/Serenity.Web/ApplicationPartsTypeSource.md) is the modern default implementation used by the current templates. Instead of a hardcoded assembly list, it obtains its assemblies from ASP.NET Core's `ApplicationPartManager`, the same mechanism MVC uses to discover controllers.

It includes:

- The assemblies referenced by the application that are marked with `[TypeSourceAssembly]`.
- The implicit Serenity assembly chain (`Serenity.Net.Core` → `Serenity.Net.Services` → `Serenity.Net.Web`), see `WebTypeSource.SerenityNetWebAssemblyChain`.

The assemblies are sorted topologically by their references, so that base types are registered before derived types where ordering matters (for example, for service behaviors).

Because it's based on application parts, you don't have to maintain a type list: any assembly your project references and that is marked as a type source is picked up automatically.

### TypeSourceAssembly Attribute

[TypeSourceAssemblyAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/TypeSourceAssemblyAttribute.md) marks an assembly as a source of types for `ITypeSource`.

```cs
[assembly: TypeSourceAssembly]
```

You normally never write this yourself: `Serenity.Net.Web.targets` adds it automatically to every assembly that references the `Serenity.Net.Web` NuGet package. That is why `ApplicationPartsTypeSource` picks up your web project and any Serenity-based library you reference without any manual configuration.

## Registering the Type Source

The [ApplicationPartsServiceCollectionExtensions](../api/dotnet/Serenity.Net.Web/Serenity.Extensions.DependencyInjection/ApplicationPartsServiceCollectionExtensions.md) class provides the registration extensions used in the template.

`AddApplicationPartsTypeSource()` creates an `ApplicationPartsTypeSource` and registers it as a singleton `ITypeSource`:

```cs
services.AddApplicationPartsTypeSource();
```

It resolves the `ApplicationPartManager` from the service collection (calling `AddMvcCore()` first if needed), and throws if an `ITypeSource` is already registered, so you can register your own `ITypeSource` before calling it if you need a custom implementation.

`AddApplicationPartsFeatureToggles(Configuration)` scans the application parts for enums marked with `[FeatureKeySet]` and registers an `IFeatureToggles` implementation backed by the `FeatureToggles` configuration section. Features that have `[DefaultValue(false)]` are disabled by default unless enabled in configuration:

```cs
services.AddApplicationPartsFeatureToggles(Configuration);
```

## Where the Type Source Is Used

Once registered, the type source drives a large part of the framework:

- **Request handlers & behaviors** — `AddServiceHandlers()` locates `IRequestHandler` implementations (Save/Retrieve/List/Delete handlers and their behaviors) through the type source and registers them.
- **Row fields** — `RowFieldsProvider.SetDefaultFrom(...)` initializes the field provider from the type source.
- **Dynamic scripts** — lookups, data scripts, and other dynamic scripts are enumerated from the types and assembly attributes.
- **Navigation** — `[assembly: NavigationLink(...)]` / `[NavigationMenu]` attributes are collected via `GetAssemblyAttributes`.
- **Report & upload registration** — report renderers, upload processors, and similar services are discovered the same way.

In short, if you add a new row, request handler, behavior, or navigation attribute to an assembly that is marked as a type source, Serenity will find it on the next start — no registration lists to update.

## See Also

- [Dependency Injection](dependency-injection.md)
- [Configuration](configuration.md)
- [ITypeSource (API reference)](../api/dotnet/Serenity.Net.Core/Serenity.Abstractions/ITypeSource.md)
- [ApplicationPartsTypeSource (API reference)](../api/dotnet/Serenity.Net.Web/Serenity.Web/ApplicationPartsTypeSource.md)
