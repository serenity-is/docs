# ResolveLocalTextResult record
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains the local text key, invariant text, and fallback behavior resolved from an attribute.

```csharp
public record ResolveLocalTextResult
```

## Public Members

| name | description |
| --- | --- |
| [ResolveLocalTextResult](ResolveLocalTextResult/ResolveLocalTextResult.md)(…) | Initializes a new instance of the [`ResolveLocalTextResult`](./ResolveLocalTextResult.md) record. |
| [IsKey](ResolveLocalTextResult/IsKey.md) { get; } | Whether the resolved key should be used as fallback text. |
| [Key](ResolveLocalTextResult/Key.md) { get; } | The resolved local text key, or `null` if none is available. |
| [Text](ResolveLocalTextResult/Text.md) { get; } | The invariant text, if specified. |

## See Also

* **Source:** *[ResolveLocalTextResult.cs](https://github.com/serenity-is/Serenity/blob/0c34357a17d56458ca5b7a3be25f42666b9eb050/src/core/Localization/ResolveLocalTextResult.cs)*