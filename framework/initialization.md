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
    services.AddLocalTextInitializer();
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

    app.InitializeLocalTexts();

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

In development, `app.UseNodeScriptRunner()` in `Configure` can also start the TypeScript build in **watch** mode so you don't have to rebuild manually when you modify a `.ts` file. See [Node Script Runner](node-script-runner.md).

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

See the [Feature Toggles](feature-toggles.md) topic for details.

## Where the Type Source Is Used

Once registered, the type source drives a large part of the framework:

- **Request handlers & behaviors** — `AddServiceHandlers()` locates `IRequestHandler` implementations (Save/Retrieve/List/Delete handlers and their behaviors) through the type source and registers them.
- **Row fields** — `RowFieldsProvider.SetDefaultFrom(...)` initializes the field provider from the type source.
- **Dynamic scripts** — lookups, data scripts, and other dynamic scripts are enumerated from the types and assembly attributes.
- **Navigation** — `[assembly: NavigationLink(...)]` / `[NavigationMenu]` attributes are collected via `GetAssemblyAttributes`.
- **Auto-registration** — `AddAutoRegisteredServices()` registers types marked with `[RegisterService]` and its subclasses (see [Dependency Injection](dependency-injection.md)).
- **Report & upload registration** — report renderers, upload processors, and similar services are discovered the same way.

In short, if you add a new row, request handler, behavior, or navigation attribute to an assembly that is marked as a type source, Serenity will find it on the next start — no registration lists to update.

## WebTypeSource and the Serenity Assembly Chain

[WebTypeSource](../api/dotnet/Serenity.Net.Web/Serenity.Web/WebTypeSource.md) is the base type source for applications that reference `Serenity.Net.Web`. It prepends the Serenity assembly chain to whatever assemblies you pass in:

```cs
public class WebTypeSource(IEnumerable<Assembly> assemblies) : BaseAssemblyTypeSource
{
    public override IEnumerable<Assembly> GetAssemblies()
    {
        return SerenityNetWebAssemblyChain.Concat(assemblies);
    }
}
```

`SerenityNetWebAssemblyChain` is the ordered list `Serenity.Net.Core` → `Serenity.Net.Services` → `Serenity.Net.Web`. Because the chain is prepended, the framework's own base types are always discovered before your application types, which matters where registration order is significant (for example, service behaviors). `ApplicationPartsTypeSource` derives from `WebTypeSource`, so it inherits this chain automatically.

## HttpContext-Backed Services

Several Serenity services need access to the current HTTP request even when they are used from code that has no direct reference to ASP.NET Core. Serenity provides small adapters that read from `IHttpContextAccessor`.

### HttpContextItemsAccessor

[HttpContextItemsAccessor](../api/dotnet/Serenity.Net.Web/Serenity.Web/HttpContextItemsAccessor.md) implements [IHttpContextItemsAccessor](../api/dotnet/Serenity.Net.Core/Serenity.Abstractions/IHttpContextItemsAccessor.md), exposing the current request's `HttpContext.Items` dictionary:

```cs
public class HttpContextItemsAccessor(IHttpContextAccessor httpContextAccessor = null) : IHttpContextItemsAccessor
{
    public IDictionary<object, object> Items => httpContextAccessor?.HttpContext?.Items;
}
```

This is how Serenity shares per-request data (such as the current user, tenant, or other ambient state) with services that don't reference the web layer directly.

Register it with `AddHttpContextItemsAccessor()` (from `HttpContextServiceCollectionExtensions`), which also calls `AddHttpContextAccessor()`:

```cs
services.AddHttpContextItemsAccessor();
```

### HttpContextUserAccessor

[HttpContextUserAccessor](../api/dotnet/Serenity.Net.Web/Serenity.Web/HttpContextUserAccessor.md) implements [IUserAccessor](../api/dotnet/Serenity.Net.Core/Serenity.Abstractions/IUserAccessor.md), exposing the current `ClaimsPrincipal` from the HTTP context:

```cs
public class HttpContextUserAccessor(IHttpContextAccessor httpContextAccessor = null) : IUserAccessor
{
    public ClaimsPrincipal User => httpContextAccessor?.HttpContext?.User;
}
```

In the templates, the application's own user accessor derives from this. For example, StartSharp's `AppServices.UserAccessor` extends `HttpContextUserAccessor` and is registered together with the user retrieve service:

```cs
services.AddUserProvider<AppServices.UserAccessor, AppServices.UserRetrieveService>();
```

`AddUserProvider<TUserAccessor, TUserRetrieveService>()` registers the `IUserAccessor` and `IUserRetrieveService` implementations and adds the `DefaultUserProvider` (plus `DefaultUserClaimCreator`) as the `IUserProvider`. See [Authentication & Authorization](authorization.md) for how these fit into the user/permission model.

## Local Text Initialization

[DefaultLocalTextInitializer](../api/dotnet/Serenity.Net.Web/Serenity.Web/DefaultLocalTextInitializer.md) is the default [ILocalTextInitializer](../api/dotnet/Serenity.Net.Core/Serenity.Abstractions/ILocalTextInitializer.md). It populates the local text registry at startup with:

- **Base texts** — the built-in Serenity texts, discovered from the type source and row type registry (`AddBaseTexts`).
- **JSON texts** — the `*.json` files under the `App_Data/texts` folder (recursively), loaded through the content root file provider.

Register it with `AddLocalTextInitializer()`:

```cs
services.AddLocalTextInitializer();
```

Then, in `Configure`, call `InitializeLocalTexts()` to run it against the registry:

```cs
app.InitializeLocalTexts();
```

This is what makes the framework's built-in strings and your `App_Data/texts/*.json` translations available to `ITextLocalizer`. See [Localization](localization.md) for the full picture.

## Configuration Sections

[ServiceCollectionConfigureExtensions](../api/dotnet/Serenity.Net.Web/Serenity.Extensions.DependencyInjection/ServiceCollectionConfigureExtensions.md) provides a convenient way to bind Serenity option classes to configuration sections without repeating the section key.

`ConfigureSection<TOptions>(config)` calls `Configure<TOptions>` using the section key from the `[DefaultSectionKey]` attribute on the options type:

```cs
services.ConfigureSection<UploadSettings>(Configuration);
```

`ConfigureSections(config)` does this for **every** type in the type source that carries a `[DefaultSectionKey]` attribute:

```cs
services.ConfigureSections(Configuration);
```

This is why the template's `Startup.cs` calls `ConfigureSections(Configuration)` once near the top — it binds all Serenity settings (upload, reporting, bundling, etc.) from their corresponding `appsettings.json` sections automatically. You can pass a predicate to filter which types are configured, or a custom `ITypeSource`.

The `[DefaultSectionKey]` attribute ([API reference](../api/dotnet/Serenity.Net.Core/Serenity/DefaultSectionKeyAttribute.md)) declares the section key for an options class, e.g. `[DefaultSectionKey("UploadSettings")]`.

## ScriptCulture

[ScriptCulture](../api/dotnet/Serenity.Net.Web/Serenity/ScriptCulture.md) captures the current culture's formatting settings so they can be passed to the client side. It reads from `CultureInfo.CurrentCulture` (or a culture you supply) and exposes:

- `DateOrder` — the year-month-day ordering, e.g. `d/M/y`.
- `DateFormat` / `DateTimeFormat` — the default date and date/time formats.
- `DateSeparator` — the date separator character.
- `DecimalSeparator` / `GroupSeparator` — the numeric decimal and group separators.

Serenity serializes a `ScriptCulture` into the client so that date/number formatting on the client matches the server's culture. You generally don't construct this yourself; it is produced from the current culture when the client script bundle is generated.

## File Watchers

Serenity uses file watchers to detect changes to files that affect cached output — most notably the script/CSS bundles and dynamic scripts, so that content is regenerated when source files change during development.

- [IFileWatcher](../api/dotnet/Serenity.Net.Web/Serenity.Web/IFileWatcher.md) — the abstraction for a file system watcher. It exposes a `Changed` event (raised with the changed file name), `RaiseChanged(name)`, and the watched `Path` and `Filter`.
- [IFileWatcherFactory](../api/dotnet/Serenity.Net.Web/Serenity.Web/IFileWatcherFactory.md) — creates watchers via `Create(path, filter)` and keeps them alive with `KeepAlive(watcher)` so they aren't garbage-collected. `Watchers` lists the stored watchers.
- [DefaultFileWatcherFactory](../api/dotnet/Serenity.Net.Web/Serenity.Web/DefaultFileWatcherFactory.md) — the default factory; it creates `FileWatcher` instances and retains them for the lifetime of the factory.
- [FileWatcher](../api/dotnet/Serenity.Net.Web/Serenity.Web/FileWatcher.md) — the default `IFileWatcher` implementation, wrapping a `FileSystemWatcher` that watches a directory (recursively) for a filter and raises `Changed` on create/change/delete/rename.

You rarely interact with these directly — they are used internally by the bundling and dynamic-script infrastructure to invalidate caches. If you build a custom bundle or dynamic script that depends on files, you can use `IFileWatcherFactory` to watch them the same way.

## ArgumentExceptions

[ArgumentExceptions](../api/dotnet/Serenity.Net.Web/Serenity/ArgumentExceptions.md) is a small helper for creating `ArgumentOutOfRangeException` (and similar) instances while avoiding analyzer warnings about mismatched argument names. It uses `[CallerArgumentExpression]` to capture the parameter name automatically:

```cs
ArgumentExceptions.OutOfRange(someArgument);
```

It is an internal convenience used throughout the framework; you don't need it in application code, but you may see it in Serenity source.

## See Also

- [Dependency Injection](dependency-injection.md)
- [Feature Toggles](feature-toggles.md)
- [Configuration](configuration.md)
- [Localization](localization.md)
- [Authentication & Authorization](authorization.md)
- [ITypeSource (API reference)](../api/dotnet/Serenity.Net.Core/Serenity.Abstractions/ITypeSource.md)
- [ApplicationPartsTypeSource (API reference)](../api/dotnet/Serenity.Net.Web/Serenity.Web/ApplicationPartsTypeSource.md)
