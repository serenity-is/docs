# SqlHelper.ExecuteReader method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes the query.

```csharp
public static IDataReader ExecuteReader(this SqlQuery query, IDbConnection connection, 
    ILogger logger = null)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| logger | Logger |

## Return Value

A data reader with results.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [SqlHelper](../SqlHelper.md)

---

# SqlHelper.ExecuteReader method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes the command returning a data reader.

```csharp
public static IDataReader ExecuteReader(IDbConnection connection, string commandText, 
    IDictionary<string, object> param, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| commandText | The command text. |
| param | The parameters. |
| logger | Logger |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | connection is null |

## See Also

* class [SqlHelper](../SqlHelper.md)