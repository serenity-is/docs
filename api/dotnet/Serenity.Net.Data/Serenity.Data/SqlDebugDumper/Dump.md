# SqlDebugDumper.Dump method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Dumps the specified SQL.

```csharp
public static string Dump(string sql, IDictionary<string, object> parameters, 
    ISqlDialect dialect = null)
```

| parameter | description |
| --- | --- |
| sql | The SQL. |
| parameters | The parameters. |
| dialect | The dialect. |

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlDebugDumper](../SqlDebugDumper.md)