# DefaultConnectionStrings.ListConnectionStrings method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Lists all known connection strings.

```csharp
public virtual IEnumerable<IConnectionString> ListConnectionStrings()
```

## Return Value

The list of all registered connections.

## Remarks

Only returns connection strings that are actually configured. Connection keys that are only resolved through a [`ConnectionKeyFallbackAttribute`](../ConnectionKeyFallbackAttribute.md) fallback are not included unless they are also configured.

## See Also

* interface [IConnectionString](../IConnectionString.md)
* class [DefaultConnectionStrings](../DefaultConnectionStrings.md)