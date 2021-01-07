# SqlUpdate.Format method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Formats an SQL UPDATE statement.

```csharp
public static string Format(string tableName, string where, List<string> nameValuePairs)
```

| parameter | description |
| --- | --- |
| tableName | Tablename (required). |
| nameValuePairs | Field name and values. Should have structure of `[field1, value1, field2, value2, ...., fieldN, valueN]`. This array is required and must have even number of elements. |
| where | WHERE clause (can be null). |

## Return Value

Formatted UPDATE query.

## See Also

* class [SqlUpdate](../SqlUpdate.md)