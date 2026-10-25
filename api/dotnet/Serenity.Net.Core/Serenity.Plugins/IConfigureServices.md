# IConfigureServices interface
**namespace:** *[Serenity.Plugins](../README.md#serenity.plugins-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Interface for plugins that require configuring their own services or options.

```csharp
public interface IConfigureServices
```

## Members

| name | description |
| --- | --- |
| [ConfigureServices](IConfigureServices/ConfigureServices.md)(…) | Configures the services and options for the plugin. |

## Remarks

This type is part of a legacy plugin system design and is no longer used by the framework. Register services through dependency injection instead, e.g. using `AddAutoRegisteredServices` and `IConfigureOptions`.

## See Also

* **Source:** *[IConfigureServices.cs](https://github.com/serenity-is/Serenity/blob/42921a2cabf9c9256331037e2f6cd60672b97071/src/core/Plugins/IConfigureServices.cs)*