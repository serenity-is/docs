# IBackgroundJobs interface
**namespace:** *[Serenity.Plugins](../README.md#serenity.plugins-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Interface for plugins that have a list of background jobs.

```csharp
public interface IBackgroundJobs
```

## Members

| name | description |
| --- | --- |
| [GetBackgroundJobs](IBackgroundJobs/GetBackgroundJobs.md)() | Gets the list of background jobs. |

## Remarks

This type is part of a legacy plugin system design and is no longer used by the framework. Register background jobs through dependency injection instead.

## See Also

* **Source:** *[IBackgroundJobs.cs](https://github.com/serenity-is/Serenity/blob/42921a2cabf9c9256331037e2f6cd60672b97071/src/core/Plugins/IBackgroundJobs.cs)*