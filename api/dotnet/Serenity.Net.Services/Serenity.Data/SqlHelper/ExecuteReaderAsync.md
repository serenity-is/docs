# SqlHelper.ExecuteReaderAsync method (1 of 2)

Executes the command asynchronously returning a data reader.

```csharp
public static Task<IDataReader> ExecuteReaderAsync(IDbConnection connection, string commandText, 
    IReadOnlyDictionary<string, object?>? param, ILogger? logger = null, 
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

A task that represents the asynchronous operation. The task result contains a data reader with the results.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | connection is null. |

## See Also

* class [SqlHelper](../SqlHelper.md)

---

# SqlHelper.ExecuteReaderAsync method (2 of 2)

Executes the query asynchronously.

```csharp
public static Task<IDataReader> ExecuteReaderAsync(this SqlQuery query, IDbConnection connection, 
    IReadOnlyDictionary<string, object?>? parameters = null, ILogger? logger = null, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| parameters | Parameter values that override the query's parameters, or the query's parameters when null. |
| logger | The logger. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result contains a data reader with the results.

## Remarks

When overrides are supplied, they are merged over the query parameters into a new dictionary. Neither input dictionary is modified.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [SqlHelper](../SqlHelper.md)