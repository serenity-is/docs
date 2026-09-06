# FallbackLocalTextSource class
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Adds key fallback behavior to any [`ILocalTextRegistry`](../Serenity.Abstractions/ILocalTextRegistry.md) implementation.

```csharp
public class FallbackLocalTextSource : ILocalTextRegistry
```

| parameter | description |
| --- | --- |
| source | The local text source. |

## Public Members

| name | description |
| --- | --- |
| [FallbackLocalTextSource](FallbackLocalTextSource/FallbackLocalTextSource.md)(…) | Adds key fallback behavior to any [`ILocalTextRegistry`](../Serenity.Abstractions/ILocalTextRegistry.md) implementation. |
| [Add](FallbackLocalTextSource/Add.md)(…) | Adds a local text entry to the registry. |
| [TryGet](FallbackLocalTextSource/TryGet.md)(…) | Returns the localized representation that corresponds to the local text key, or a fallback if none is found in the registry. |
| static [BreakUpString](FallbackLocalTextSource/BreakUpString.md)(…) | Breaks up a string without spaces (e.g. LastDirectoryUpdate) into a normal string (e.g. 'Last Directory Update'). |
| static [TryGetKeyFallback](FallbackLocalTextSource/TryGetKeyFallback.md)(…) | Gets a fallback of the local text key. |

## Remarks

Initializes a new instance of the [`FallbackLocalTextSource`](./FallbackLocalTextSource.md) class.

## See Also

* interface [ILocalTextRegistry](../Serenity.Abstractions/ILocalTextRegistry.md)
* **Source:** *[FallbackLocalTextRegistry.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Localization/FallbackLocalTextRegistry.cs)*