# SqlHelper.ExecuteScalarAsync method (1 of 2)

Executes the statement asynchronously returning a scalar value.

```csharp
public static Task<object?> ExecuteScalarAsync(IDbConnection connection, SqlQuery query, 
    IReadOnlyDictionary<string, object?>? parameters = null, ILogger? logger = null, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| query | The select query. |
| parameters | Parameter values that override the query's parameters. |
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

Executes the statement asynchronously returning a scalar value.

```csharp
public static Task<object?> ExecuteScalarAsync(IDbConnection connection, string commandText, 
    IReadOnlyDictionary<string, object?>? param = null, ILogger? logger = null, 
    CancellationToken cancellationToken = default)
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