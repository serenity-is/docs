# ConnectionStringsExtensions.Get method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Gets connection string by key

```csharp
public static IConnectionString Get(this IConnectionStrings connectionStrings, string connectionKey)
```

| parameter | description |
| --- | --- |
| connectionStrings | Connection strings object |
| connectionKey | Connection key |

## Return Value

Connection string with key, or throws an ArgumentOutOfRangeException

## See Also

* interface [IConnectionString](../IConnectionString.md)
* interface [IConnectionStrings](../IConnectionStrings.md)
* class [ConnectionStringsExtensions](../ConnectionStringsExtensions.md)