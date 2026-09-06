# EntityConnectionExtensions.Exists&lt;TRow&gt; method

Checks if record matching specified criteria exists.

```csharp
public static bool Exists<TRow>(this IDbConnection connection, ICriteria where)
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| where | The where criteria. |

## Return Value

True if a record matching the criteria exists.

## See Also

* interface [ICriteria](../../Serenity/ICriteria.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)