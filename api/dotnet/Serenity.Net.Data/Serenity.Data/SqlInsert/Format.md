# SqlInsert.Format method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Formats an INSERT query.

```csharp
public static string Format(string tableName, List<string> nameValuePairs)
```

| parameter | description |
| --- | --- |
| tableName | Tablename (required). |
| nameValuePairs | Field names and values. Must be passed in the order of `[field1, value1, field2, value2, ...., fieldN, valueN]`. It must have even number of elements. |

## Return Value

Formatted query.

## See Also

* class [SqlInsert](../SqlInsert.md)