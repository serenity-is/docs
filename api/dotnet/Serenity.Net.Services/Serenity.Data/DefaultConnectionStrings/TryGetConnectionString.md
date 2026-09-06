# DefaultConnectionStrings.TryGetConnectionString method

Gets a connection string by its key, resolving any connection key fallbacks. If the specified key is not configured but has a fallback, the fallback connection string is returned. The returned [`ConnectionKey`](../IConnectionString/ConnectionKey.md) is the key the connection is actually registered under.

```csharp
public virtual IConnectionString TryGetConnectionString(string connectionKey)
```

| parameter | description |
| --- | --- |
| connectionKey | The connection key. |

## Return Value

The connection string, or `null` if not found.

## See Also

* interface [IConnectionString](../IConnectionString.md)
* class [DefaultConnectionStrings](../DefaultConnectionStrings.md)