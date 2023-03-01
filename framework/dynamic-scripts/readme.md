# Dynamic Scripts

Serenity has a special middleware called [DynamicScriptMiddleware](../../api/dotnet/Serenity.Net.Web/Serenity.Web.Middleware/DynamicScriptMiddleware.md) that handles any call to the specific routes starting with `~/DynJS.axd/` and `~/DynamicData/`.

The `.axd` extension originates from the time when it was defined as an HTTP handler in the classic ASP.NET, which usually preferred `.axd` for such handlers, and mapping extensionless URLs in IIS was complicated back then.

`DynJS` is the abbreviation for `Dynamic JS` as its initial purpose was to only serve dynamically generated Javascript which is now extended to `CSS`, in addition to some other types like `HTML Templates`, etc. 

The contents of these script files were mainly used to pass data from the server side to the client side by setting some global variables. So they were not usual script blocks with functions etc. but merely a few statements to set data.
 
Recently, the `DynamicScriptMiddleware` also started to handle the `~/DynamicData` route to retrieve `JSON` data, which is mainly intended for mobile apps.

Even though we call them `Dynamic Script` due to historical reasons, it is more like `Dynamic Content` today.

## The `IDynamicScript` Interface

[IDynamicScript](../../api/dotnet/Serenity.Net.Web/Serenity.Web/IDynamicScript.md) is the abstraction that all the dynamic script (or content) objects should implement:

```cs
public interface IDynamicScript
{
    string GetScript();
    void CheckRights(IPermissionService permissions, 
        ITextLocalizer localizer);
    string GroupKey { get; }
    TimeSpan Expiration { get; }
}
```

The dynamic script object should return its dynamically generated content via the `GetScript` method.

The source for the dynamic content can be anything, from a database query; to some data generated from the application code itself via reflection.

`CheckRights` is the method the dynamic script should implement to validate if the current user has access to this content. You may think of it as the `Authorize` attribute.

`GroupKey` is used for cache invalidation and is closely related to the `ITwoLevelCache` interface we mentioned in the [Caching](../caching.md) topic. So if for instance, this is a dynamic script that generates its content from a `Country` table, it should return its `GroupKey` so that when a new Country is added to that table via a `Create` handler, the dynamic script should reload its data.

`Expiration` is the duration a dynamic script should be kept in the cache.

## The `IDynamicScriptManager` Interface

The class implementing [IDynamicScriptManager](../../api/dotnet/Serenity.Net.Web/Serenity.Web/IDynamicScriptManager.md) is the central location for dynamic scripts.

It contains a dictionary of registered dynamic scripts. Every registered script has a unique `registration key` or `name`. Some script types that implement the `INamedDynamicScript` interface may provide their predefined names, while others must be specified during registration:

```cs
void Register(INamedDynamicScript script);
void Register(string name, IDynamicScript script);
```

When a script is requested first time by specifying its registration name, `DynamicScriptManager` calls its `GetScript` method to generate the content and caches it.

Next time the same script is requested, it returns the cached data instead of calling the `GetScript` method unless the content has expired.

It provides these methods to retrieve dynamic script contents:

```cs
string GetScriptText(string name, bool json = false);
IScriptContent ReadScriptContent(string name, bool json = false);
```

While `GetScriptText` directly returns the content as text, `ReadScriptContent` returns an [IScriptContent](../../api/dotnet/Serenity.Net.Web/Serenity.Web/IScriptContent.md) object which provides more details like the hash, last generation time, content as a byte array, Brotli/Gzip compressed versions of the content, etc.

The default implementation for `IDynamicScriptManager` is registered in `Startup.cs` via the `services.AddDynamicScripts()` call.

## Dynamic Script Types

There is a bunch of dynamic script types including but not limited to:

- Columns definitions
- Form definitions
- Lookups
- Data Scripts (like `UserData`, `PermissionKeys`)
- Distinct Field Values
- Local Text Script
- HTML Templates
- Script bundles
- CSS bundles

We'll visit and explain some of them in the next chapters. 

Most of these script types are defined via special attributes like `[LookupScript]`, `[FormScript]`, etc., discovered via reflection and are automatically registered by `services.AddDynamicScripts()` call in the `Startup.cs` file.

Script bundles and CSS bundle contents are defined in the `appsettings.bundles.json` file.

Local text scripts are lazily initialized and registered when the site is displayed first time in a specific language.

## Dynamic Scripts Versus Services/Actions

Some users might think that as the name `Dynamic` implies, they can use dynamic scripts like `Services/Actions` to generate dynamic content on every request, e.g. return a different set of data based on query string parameters, or context variables like the current user, tenant, etc.

Dynamic scripts are generated the first time they are requested, and unless otherwise specified, aggressively cached both on the server and client side, so on every subsequent request the content received will be the same, regardless of the current user or query string parameters.

Even though it is possible to disable caching and apply some workarounds to make them act as if parameterized, you would be losing the primary advantage and misusing dynamic scripts for something that they are not intended to.

If you need parameterized dynamic scripts, we recommend defining proper services instead. For `frequently changing data`, dynamic scripts are `NOT the right tool for the job`. Think of them like a static dictionary, with dynamic content that is generated once, maybe twice, etc.

We'll try to explain this in more detail in the `Lookups` topic.