# SqlHelper.Exists method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes the query returning true if it has at least one result.

```csharp
public static bool Exists(this SqlQuery query, IDbConnection connection, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| logger | The logger. |

## Return Value

True if the query returns at least one result.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [SqlHelper](../SqlHelper.md)