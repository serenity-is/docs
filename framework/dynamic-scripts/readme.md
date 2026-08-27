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

### Related Interfaces: `INamedDynamicScript`, `IScriptName`, `IGetScriptData`

A few small interfaces complement `IDynamicScript`:

- [IScriptName](../../api/dotnet/Serenity.Net.Core/Serenity.Web/IScriptName.md) — exposes a `ScriptName` property, the registration name for a dynamic script:

  ```cs
  public interface IScriptName
  {
      string ScriptName { get; }
  }
  ```

- [INamedDynamicScript](../../api/dotnet/Serenity.Net.Core/Serenity.Web/INamedDynamicScript.md) — a dynamic script that also provides its own default registration name. It combines `IDynamicScript` and `IScriptName`:

  ```cs
  public interface INamedDynamicScript : IDynamicScript, IScriptName
  {
  }
  ```

  Scripts implementing this interface can be registered without specifying a name (`Register(INamedDynamicScript)`), whereas others must be registered with an explicit name.

- [IGetScriptData](../../api/dotnet/Serenity.Net.Core/Serenity.Web/IGetScriptData.md) — provides access to the underlying data object of a dynamic script, rather than its rendered script text:

  ```cs
  public interface IGetScriptData
  {
      object GetScriptData();
  }
  ```

  This is used by scripts that expose a data object (e.g. lookups) so the manager can retrieve the data directly, for example to serve it as JSON via the `~/DynamicData` route.

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

### The DynamicScriptManager Implementation

[`DynamicScriptManager`](../../api/dotnet/Serenity.Net.Web/Serenity.Web/DynamicScriptManager.md) is the default `IDynamicScriptManager`. It keeps a dictionary of registered scripts and caches each script's generated content through the two-level cache (`ITwoLevelCache`), keyed by `DynamicScript:<name>` (or `DynamicData:<name>` for JSON). It also tracks the last change time of each script so that calling `Changed(name)` (or `Reset()`) invalidates the cached content.

Besides `Register`, `GetScriptText`, and `ReadScriptContent`, it provides:

- `GetScriptInclude(name, extension)` — returns the `~/DynJS.axd/<name><extension>?v=<hash>` URL for a script, using a cached hash without executing the script.
- `PeekScriptHash(name, script)` — returns the cached hash for a script (or a fresh one) without generating its content.
- `GetRegisteredScripts()` / `GetRegisteredScriptNames()` — the registered script names and their hashes.
- `IfNotRegistered(name, callback)` — registers a script only if it isn't already (used for lazily registered scripts like local texts).
- `CheckScriptRights(name)` — runs a script's `CheckRights` against the current user.
- `Changed(name)` / `Reset()` — mark scripts as changed so their cached content is regenerated.

The manager automatically registers a `RegisteredScripts` script on construction (see below).

### ScriptContent and ICacheSuffix

[`ScriptContent`](../../api/dotnet/Serenity.Net.Web/Serenity.Web/ScriptContent.md) is the default `IScriptContent` returned by `ReadScriptContent`. It holds the generated content as a byte array plus:

- `Time` — the generation time (used for `Last-Modified` / `If-Modified-Since`).
- `Hash` — an MD5 hash of the content, base64-url-encoded (used for the `?v=` version parameter).
- `CanCompress` / `CompressedContent` / `BrotliContent` — lazily produced GZip and Brotli compressed versions, served when the client advertises the corresponding `Accept-Encoding`.

[`ICacheSuffix`](../../api/dotnet/Serenity.Net.Web/Serenity.Web/ICacheSuffix.md) lets a script add a suffix to its cache key. This is how a script can produce different cached content per parameter without being re-executed on every request — for example, `LocalTextDataScript` uses `languageId:packageId` as its suffix so each language/package combination is cached separately.

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

## Concrete Script Types

The framework ships several ready-made dynamic script classes you can use or derive from.

### `DynamicScript` (base class)

[`DynamicScript`](../../api/dotnet/Serenity.Net.Services/Serenity.Web/DynamicScript.md) is the abstract base implementation of `IDynamicScript`. Besides `GetScript()`, it provides settable `GroupKey`, `Expiration`, and `Permission` properties, and its `CheckRights` validates `Permission` if set:

```cs
public abstract class DynamicScript : IDynamicScript
{
    public abstract string GetScript();
    public virtual void CheckRights(IPermissionService permissions, ITextLocalizer localizer)
    {
        if (Permission != null)
            permissions.ValidatePermission(Permission, localizer);
    }
    public string GroupKey { get; set; }
    public TimeSpan Expiration { get; set; }
    public string Permission { get; set; }
}
```

### `DataScript` and `DataScript<TData>`

[`DataScript`](../../api/dotnet/Serenity.Net.Services/Serenity.Web/DataScript.md) is a dynamic script that wraps a data object. It implements `INamedDynamicScript` and `IGetScriptData`, so it can be registered without an explicit name and its data can be served as JSON via `~/DynamicData`. Its script name is `RemoteData.<key>`, and `GetScript()` emits a `Serenity.setScriptData(...)` call that stores the JSON data in a global `Serenity.scriptData` object on the client.

[`DataScript<TData>`](../../api/dotnet/Serenity.Net.Services/Serenity.Web/DataScript-1.md) is the generic subclass you derive from when writing a data script. It reads its key, cache duration, permission, and cache group key from the [`[DataScript]`](../../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/DataScriptAttribute.md) attribute:

```cs
[DataScript("MyData", CacheDuration = 3600, Permission = "MyPermission")]
public class MyDataScript : DataScript<MyData>
{
    protected override MyData GetData()
    {
        // load and return the data
    }
}
```

### `ConcatenatedScript`

[`ConcatenatedScript`](../../api/dotnet/Serenity.Net.Services/Serenity.Web/ConcatenatedScript.md) combines several other scripts into one, joining their outputs with a separator. It takes a list of `Func<string>` script parts (and an optional `checkRights` callback). This is how script bundles are assembled.

### `ColumnsScript`, `FormScript`, and `PropertyItemsScript`

[`ColumnsScript`](../../api/dotnet/Serenity.Net.Services/Serenity.Web/ColumnsScript.md) and [`FormScript`](../../api/dotnet/Serenity.Net.Services/Serenity.Web/FormScript.md) are the dynamic scripts behind the `[ColumnsScript]` and `[FormScript]` attributes. They derive from [`PropertyItemsScript`](../../api/dotnet/Serenity.Net.Services/Serenity.Web/PropertyItemsScript.md), which builds a `PropertyItemsData` object (the `PropertyItem[]` metadata for a columns or form type) via `IPropertyItemProvider` and emits it as `Serenity.setScriptData(...)`.

- `ColumnsScript` registers under `Columns.<name>`.
- `FormScript` registers under `Form.<name>`.

`PropertyItemsScript.Compact` generates a compact, minified representation of the property items used by the client to reduce payload size.

### `LookupScript` and `RowLookupScript`

[`LookupScript`](../../api/dotnet/Serenity.Net.Web/Serenity.Web/LookupScript.md) is the abstract base class for lookup scripts. It implements `INamedDynamicScript` and `IGetScriptData`, and its script name is `Lookup.<LookupKey>`. It exposes `IdField`, `TextField`, and `ParentIdField` (for tree lookups) plus a `LookupParams` dictionary, and requires you to implement `GetItems()` returning the item list. Its `GetScript()` emits a `Serenity.setScriptData(...)` call that constructs a client-side `Lookup` object.

[`RowLookupScript<TRow>`](../../api/dotnet/Serenity.Net.Web/Serenity.Web/RowLookupScript-1/RowLookupScript.md) is the generic implementation for rows. It:

- Reads `IdField`, `TextField`, and `ParentIdField` from the row's `IdProperty` / `NameProperty` / `IParentIdRow`.
- Uses the row's `[ReadPermission]` as the script permission.
- Uses the row fields' `GenerationKey` as the `GroupKey`, so the lookup is invalidated when the row schema changes.
- `PrepareQuery` selects the ID, name, and any `[LookupInclude]` fields; `ApplyOrder` orders by the name (or ID) field.

This is the base class used by auto-generated row lookups and by custom lookups like `LanguageLookup`. See [Lookup Scripts](lookups.md) for the full lookup topic.

### `DistinctValuesScript`

[`DistinctValuesScript<TRow>`](../../api/dotnet/Serenity.Net.Web/Serenity.Web/DistinctValuesScript-1/DistinctValuesScript.md) is a `LookupScript` subclass that returns the distinct values of a single row field. It is created automatically for properties marked with `[DistinctValuesEditor]` (see `DistinctValuesRegistration` below) and registers under a key like `Distinct.<LocalTextPrefix>.<PropertyName>`. Its items are `{ v: <value> }` objects, so both `IdField` and `TextField` are `v`.

### `LocalTextScript` and `LocalTextDataScript`

[`LocalTextScript`](../../api/dotnet/Serenity.Net.Web/Serenity.Web/LocalTextScript.md) is the dynamic script behind the `@Html.LocalTextScript(package)` helper. It implements `INamedDynamicScript` and registers under `LocalText.<package>.<languageId>.<Public|Pending>`. It serializes the local texts matching a package's include pattern as a nested JSON object. `GetScriptName` and `GetLocalTextPackageScript` are static helpers for building the name/content.

[`LocalTextDataScript`](../../api/dotnet/Serenity.Net.Web/Serenity.Web/LocalTextDataScript.md) is a `[DataScript("LocalText")]` that serves local texts as JSON via `~/DynamicData` for external clients (e.g. mobile apps). It implements `ICacheSuffix` with `languageId:packageId` so each language/package is cached separately, and reads the `lang` and `pack` query parameters (defaulting to the current UI culture and the `Site` package).

### `RegisteredScripts`

[`RegisteredScripts`](../../api/dotnet/Serenity.Net.Web/Serenity.Web/RegisteredScripts.md) is a dynamic script (registered automatically by `DynamicScriptManager`) whose data is a dictionary of every registered script name to its current hash. The client uses it to detect which dynamic scripts have changed and need to be reloaded. It is rendered into the page by the layout (see the `RegisteredScripts` JSON element in `_LayoutHead.cshtml`).

## Registration Helpers

Dynamic scripts are discovered and registered from the type source. The registration entry point is [`DynamicScriptServiceCollectionExtensions`](../../api/dotnet/Serenity.Net.Web/Serenity.Extensions.DependencyInjection/DynamicScriptServiceCollectionExtensions.md):

- `AddDynamicScripts()` — registers `IDynamicScriptManager` (via `AddDynamicScriptManager`) plus `IPropertyItemProvider`. This is what the templates call in `Startup.cs`.
- `AddDynamicScriptManager()` — registers `IDynamicScriptManager` (plus caching and the text registry).
- `AddFileWatcherFactory()` — registers `IFileWatcherFactory` (used by bundling and content-hash caching).

The actual registration of individual script types is done by helper classes that scan the type source:

- [`DataScriptRegistration`](../../api/dotnet/Serenity.Net.Web/Serenity.Web/DataScriptRegistration.md) — `RegisterDataScripts` creates and registers an instance for every type carrying `[DataScript]`.
- [`LookupScriptRegistration`](../../api/dotnet/Serenity.Net.Web/Serenity.Web/LookupScriptRegistration.md) — `RegisterLookupScripts` creates a `RowLookupScript<>` for row types with `[LookupScript]` (or a custom `LookupScript` subclass), sets the lookup key, permission, and expiration, and throws on duplicate keys.
- [`DistinctValuesRegistration`](../../api/dotnet/Serenity.Net.Web/Serenity.Web/DistinctValuesRegistration.md) — `RegisterDistinctValueScripts` scans `[DistinctValuesEditor]` on rows/forms/columns and creates the corresponding `DistinctValuesScript<>`.
- [`ColumnsScriptRegistration`](../../api/dotnet/Serenity.Net.Web/Serenity.Web/ColumnsScriptRegistration.md) — `RegisterColumnsScripts` registers a `ColumnsScript` for every `[ColumnsScript]` type, plus a `ColumnsBundle` concatenated script.
- [`FormScriptRegistration`](../../api/dotnet/Serenity.Net.Web/Serenity.Web/FormScriptRegistration.md) — `RegisterFormScripts` registers a `FormScript` for every `[FormScript]` type, plus a `FormBundle` concatenated script.

Two related types live in the same source area: [`EmailEditorAttribute`](../../api/dotnet/Serenity.Net.Web/Serenity.ComponentModel/EmailEditorAttribute.md) is an editor attribute that also implements `ICustomValidator` (see [Validation](../../services/validation.md)), and `ICustomizedFormScript` is an obsolete interface — use `ICustomizePropertyItems` instead.

## BaseDynamicDataGenerator

[`BaseDynamicDataGenerator`](../../api/dotnet/Serenity.Net.Web/Serenity.Web/BaseDynamicDataGenerator.md) is a base class for generating `.json` files under a `dynamic-data` folder, containing the JSON data of every registered dynamic script. It is used for script testing purposes (e.g. to inspect lookup/columns/form data without a running site). Its `Run()` method builds a service provider, initializes the scripts, and writes each script's JSON data to `dynamic-data/<name>.json`; `RunAndExitIf(args)` runs it when the command line contains `dynamic-data`. `ShouldSkipScript` excludes the bundle and `RegisteredScripts` scripts by default.

## Dynamic Scripts Versus Services/Actions

Some users might think that as the name `Dynamic` implies, they can use dynamic scripts like `Services/Actions` to generate dynamic content on every request, e.g. return a different set of data based on query string parameters, or context variables like the current user, tenant, etc.

Dynamic scripts are generated the first time they are requested, and unless otherwise specified, aggressively cached both on the server and client side, so on every subsequent request the content received will be the same, regardless of the current user or query string parameters.

Even though it is possible to disable caching and apply some workarounds to make them act as if parameterized, you would be losing the primary advantage and misusing dynamic scripts for something that they are not intended to.

If you need parameterized dynamic scripts, we recommend defining proper services instead. For `frequently changing data`, dynamic scripts are `NOT the right tool for the job`. Think of them like a static dictionary, with dynamic content that is generated once, maybe twice, etc.

We'll try to explain this in more detail in the `Lookups` topic.