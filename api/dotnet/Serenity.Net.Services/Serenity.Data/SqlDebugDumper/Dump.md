# SqlDebugDumper.Dump method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Dumps the specified SQL, replacing parameters with SQL constants, fixing brackets and database caret references.

```csharp
public static string Dump(string sql, IDictionary<string, object> parameters, 
    ISqlDialect dialect = null)
```

| parameter | description |
| --- | --- |
| sql | The SQL. |
| parameters | The parameters. |
| dialect | The dialect. |

## Return Value

The debug version of the SQL.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlDebugDumper](../SqlDebugDumper.md)