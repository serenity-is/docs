# ConnectionStringsExtensions.Get method

Gets the connection string by key.

```csharp
public static IConnectionString Get(this IConnectionStrings connectionStrings, string connectionKey)
```

| parameter | description |
| --- | --- |
| connectionStrings | The connection strings object. |
| connectionKey | The connection key. |

## Return Value

The connection string with the key, or throws an ArgumentOutOfRangeException.

## See Also

* interface [IConnectionString](../IConnectionString.md)
* interface [IConnectionStrings](../IConnectionStrings.md)
* class [ConnectionStringsExtensions](../ConnectionStringsExtensions.md)