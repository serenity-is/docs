# ValidationContextExtensions.GetConnection method

Gets the connection the value is saved with, e.g. in the transaction of a save handler, or null when the context has none.

```csharp
public static IDbConnection? GetConnection(this ValidationContext context)
```

| parameter | description |
| --- | --- |
| context | The context. |

## See Also

* class [ValidationContextExtensions](../ValidationContextExtensions.md)