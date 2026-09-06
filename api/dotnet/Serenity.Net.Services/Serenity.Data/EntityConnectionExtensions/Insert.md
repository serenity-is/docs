# EntityConnectionExtensions.Insert&lt;TRow&gt; method

Inserts the specified entity. Note that this operates at a low level, it does not perform any validation or permission check, and does not call service behaviors / handlers.

```csharp
public static void Insert<TRow>(this IDbConnection connection, TRow row)
    where TRow : IRow
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| row | The row. |

## See Also

* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)