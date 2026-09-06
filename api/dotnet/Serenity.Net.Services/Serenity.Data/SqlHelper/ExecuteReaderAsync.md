# SqlHelper.ExecuteReaderAsync method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes the query asynchronously.

```csharp
public static Task<IDataReader> ExecuteReaderAsync(this SqlQuery query, IDbConnection connection, 
    ILogger logger = null, CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| logger | The logger. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result contains a data reader with the results.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [SqlHelper](../SqlHelper.md)

---

# SqlHelper.ExecuteReaderAsync method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes the command asynchronously returning a data reader.

```csharp
public static Task<IDataReader> ExecuteReaderAsync(IDbConnection connection, string commandText, 
    IDictionary<string, object> param, ILogger logger = null, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| commandText | The command text. |
| param | The parameters. |
| logger | The logger. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result contains a data reader with the results.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | connection is null. |

## See Also

* class [SqlHelper](../SqlHelper.md)