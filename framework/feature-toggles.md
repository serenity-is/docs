# Feature Toggles

Feature toggles (also known as feature flags) let you enable or disable parts of your application at runtime, without deploying new code. Serenity provides a small abstraction (`IFeatureToggles`) and integrates it with configuration, type discovery, navigation, and MVC.

## IFeatureToggles

The core abstraction is the [IFeatureToggles](../api/dotnet/Serenity.Net.Core/Serenity.Abstractions/IFeatureToggles.md) interface:

```cs
public interface IFeatureToggles
{
    bool IsEnabled(string feature);
}
```

The default implementation, [ConfigurationFeatureToggles](../api/dotnet/Serenity.Net.Core/Serenity/ConfigurationFeatureToggles.md), reads from the `FeatureToggles` section of the configuration. Unless a feature is explicitly set to `"false"`, it is considered enabled:

```json
{
  "FeatureToggles": {
    "DataAuditLog": false,
    "EmailQueue": true
  }
}
```

## Registration

`AddFeatureToggles()` registers the `IFeatureToggles` service:

```cs
services.AddFeatureToggles(configuration);
```

In a typical Serene/StartSharp application you don't call it directly. The template calls `AddApplicationPartsFeatureToggles(Configuration)` in `Startup.cs` (see [Initialization and Startup](initialization.md)), which scans the application parts for feature key sets, applies defaults and dependencies, and registers the service:

```cs
services.AddApplicationPartsFeatureToggles(Configuration);
```

## Defining Feature Keys

Features are usually defined as an enum marked with the [FeatureKeySet](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/FeatureKeySetAttribute.md) attribute:

```cs
[FeatureKeySet]
public enum FeatureKeys
{
    [Description("Data Audit Log")]
    DataAuditLog,

    [Description("Email Queue")]
    EmailQueue,

    [DefaultValue(false)]
    DataExplorer
}
```

`AddApplicationPartsFeatureToggles` scans for such enums:

- Members marked with `[DefaultValue(false)]` are disabled by default (unless explicitly enabled in configuration).
- [RequiresFeature](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/RequiresFeatureAttribute.md) attributes on the enum or its members declare dependencies: a feature is only enabled when all (or any, via `RequireAny`) of its dependencies are enabled.

## Checking Features

Inject `IFeatureToggles` and call `IsEnabled`:

```cs
public class SomeService(IFeatureToggles featureToggles)
{
    public void DoSomething()
    {
        if (featureToggles.IsEnabled(FeatureKeys.DataExplorer))
        {
            // ...
        }
    }
}
```

The [FeatureTogglesExtensions](../api/dotnet/Serenity.Net.Core/Serenity/FeatureTogglesExtensions.md) class provides overloads that accept enum values directly, or sets of features (requiring all or any of them).

## Restricting Pages and Actions

The [FeatureBarrierAttribute](../api/dotnet/Serenity.Net.Web/Serenity.Web/FeatureBarrierAttribute.md) (in `Serenity.Net.Web`) can be placed on MVC controllers, actions, or Razor pages. When a required feature is disabled, the action/page is not accessible (returns 404):

```cs
[FeatureBarrier(FeatureKeys.DataExplorer)]
public class DataExplorerPage : Controller
{
    // ...
}
```

## Filtering by the Type Source

The type source itself respects feature toggles. `BaseAssemblyTypeSource` (which `ApplicationPartsTypeSource` derives from) excludes assemblies and types marked with `[RequiresFeature]` whose features are disabled. This means a disabled feature's types — including its navigation attributes, rows, and services — are not discovered at all, so their navigation links and other UI elements simply don't appear.

In other words, placing `[RequiresFeature]` or `[FeatureBarrier]` on a page/controller is usually enough to hide everything related to it.

## See Also

- [Initialization and Startup](initialization.md)
- [Configuration](configuration.md)
