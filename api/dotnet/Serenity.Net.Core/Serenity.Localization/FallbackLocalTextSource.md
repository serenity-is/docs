# FallbackLocalTextSource class
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Adds key fallback to any ILocalTextSource implementation

```csharp
public class FallbackLocalTextSource : ILocalTextRegistry
```

## Public Members

| name | description |
| --- | --- |
| [FallbackLocalTextSource](FallbackLocalTextSource/FallbackLocalTextSource.md)(…) | Initializes a new instance of the [`FallbackLocalTextSource`](FallbackLocalTextSource.md) class. |
| [Add](FallbackLocalTextSource/Add.md)(…) | Adds a local text entry to the registry |
| [TryGet](FallbackLocalTextSource/TryGet.md)(…) | Returns localized representation which corresponds to the local text key or the fallback if none found in the registry. |
| static [BreakUpString](FallbackLocalTextSource/BreakUpString.md)(…) | Break up string without spaces (e.g. LastDirectoryUpdate) into a normal string (e.g. 'Last Directory Update') |
| static [TryGetKeyFallback](FallbackLocalTextSource/TryGetKeyFallback.md)(…) | Get a fallback of the local text key |

## See Also

* interface [ILocalTextRegistry](../Serenity.Abstractions/ILocalTextRegistry.md)
* **Source:** *[FallbackLocalTextRegistry.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Localization/FallbackLocalTextRegistry.cs)*