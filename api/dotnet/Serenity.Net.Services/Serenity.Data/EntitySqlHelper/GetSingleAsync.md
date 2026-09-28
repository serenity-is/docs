# EntitySqlHelper.GetSingleAsync method (1 of 2)

Gets the single entity returned by executing the query asynchronously.

```csharp
public static Task<bool> GetSingleAsync(this SqlQuery query, IDbConnection connection, 
    CancellationToken token)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| token | The cancellation token. |

## Return Value

A task that represents the asynchronous operation.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)

---

# EntitySqlHelper.GetSingleAsync method (2 of 2)

Gets the single entity returned by executing the query asynchronously. The values are loaded into the loader row of the query.

```csharp
public static Task<bool> GetSingleAsync(this SqlQuery query, IDbConnection connection, 
    IReadOnlyDictionary<string, object?>? parameters = null, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| parameters | Values that override the query's parameters for this execution. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result is true if any results were returned from the data reader.

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | Query returned more than one result! |

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)