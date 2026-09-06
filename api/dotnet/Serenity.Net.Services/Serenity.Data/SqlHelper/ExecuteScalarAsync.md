# SqlHelper.ExecuteScalarAsync method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes the statement asynchronously returning a scalar value.

```csharp
public static Task<object> ExecuteScalarAsync(IDbConnection connection, SqlQuery query, 
    ILogger logger = null, CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| query | The select query. |
| logger | The logger. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result contains the scalar value.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | selectQuery is null. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [SqlHelper](../SqlHelper.md)

---

# SqlHelper.ExecuteScalarAsync method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes the statement asynchronously returning a scalar value.

```csharp
public static Task<object> ExecuteScalarAsync(IDbConnection connection, string commandText, 
    IDictionary<string, object> param = null, ILogger logger = null, 
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

A task that represents the asynchronous operation. The task result contains the scalar value.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | connection is null. |

## See Also

* class [SqlHelper](../SqlHelper.md)