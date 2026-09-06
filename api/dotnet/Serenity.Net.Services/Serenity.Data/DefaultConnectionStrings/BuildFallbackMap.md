# DefaultConnectionStrings.BuildFallbackMap method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Builds the connection key fallback map from the given type source.

```csharp
protected static Dictionary<string, string> BuildFallbackMap(ITypeSource typeSource)
```

| parameter | description |
| --- | --- |
| typeSource | The type source used to discover connection key fallbacks. |

## Return Value

The connection key fallback map.

## See Also

* interface [ITypeSource](../Serenity.Net.Core/../../Serenity.Abstractions/ITypeSource.md)
* class [DefaultConnectionStrings](../DefaultConnectionStrings.md)