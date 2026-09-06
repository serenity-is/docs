# EntityConnectionExtensions.InsertAndGetID&lt;TRow&gt; method

Inserts the specified entity and returns the ID of record inserted. Only works for identity columns of integer type. Note that this operates at a low level, it does not perform any validation or permission check and does not call service behaviors / handlers.

```csharp
public static long? InsertAndGetID<TRow>(this IDbConnection connection, TRow row)
    where TRow : IRow
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| row | The row. |

## Return Value

The ID of the record inserted.

## See Also

* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)