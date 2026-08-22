# ILocalTextRegistry interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Abstraction for a local text registry which stores translations for local text keys.

```csharp
public interface ILocalTextRegistry
```

## Members

| name | description |
| --- | --- |
| [Add](ILocalTextRegistry/Add.md)(…) | Adds a local text entry to the registry. |
| [TryGet](ILocalTextRegistry/TryGet.md)(…) | Returns the localized representation that corresponds to the local text key, or `null` if none is found in the source. |

## See Also

* **Source:** *[ILocalTextRegistry.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Localization/ILocalTextRegistry.cs)*