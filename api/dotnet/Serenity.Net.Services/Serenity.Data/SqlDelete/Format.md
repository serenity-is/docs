# SqlDelete.Format method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Formats a DELETE query.

```csharp
public static string Format(string tableName, string where, ISqlDialect dialect = null)
```

| parameter | description |
| --- | --- |
| tableName | Table name. |
| where | Where part of the query. |
| dialect | Target dialect |

## Return Value

Formatted query.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlDelete](../SqlDelete.md)