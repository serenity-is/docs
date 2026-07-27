# SqlHelper.ExecuteNonQuery method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes the statement

```csharp
public static int ExecuteNonQuery(IDbConnection connection, string commandText, 
    IDictionary<string, object> param = null, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| commandText | The command text. |
| param | The parameters. |
| logger | Logger |

## Return Value

Number of affected rows

## See Also

* class [SqlHelper](../SqlHelper.md)