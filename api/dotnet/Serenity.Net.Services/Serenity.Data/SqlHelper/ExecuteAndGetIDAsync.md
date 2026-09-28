# SqlHelper.ExecuteAndGetIDAsync method

Executes the query asynchronously and returns the generated identity value. Only works for auto incremented fields, not GUIDs.

```csharp
public static Task<long?> ExecuteAndGetIDAsync(this SqlInsert query, IDbConnection connection, 
    IReadOnlyDictionary<string, object?>? parameters = null, ILogger? logger = null, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| parameters | Values that override the query's parameters for this execution. |
| logger | The logger. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result contains the generated identity value, or null if none was generated.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | query.IdentityColumn is null. |
| NotImplementedException | The connection dialect doesn't support returning the inserted identity. |

## See Also

* class [SqlInsert](../SqlInsert.md)
* class [SqlHelper](../SqlHelper.md)