# EntitySqlHelper.GetFirstAsync method (1 of 2)

Gets the first entity returned by executing the query asynchronously.

```csharp
public static Task<bool> GetFirstAsync(this SqlQuery query, IDbConnection connection, 
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

# EntitySqlHelper.GetFirstAsync method (2 of 2)

Gets the first entity returned by executing the query asynchronously. The result is loaded into the loader row of the query.

```csharp
public static Task<bool> GetFirstAsync(this SqlQuery query, IDbConnection connection, 
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

A task that represents the asynchronous operation. The task result is true if any rows were returned.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)