# EntitySqlHelper.ForEachAsync method (1 of 4)

Asynchronously executes the callback for all rows returned from the query.

```csharp
public static Task<int> ForEachAsync(this SqlQuery query, IDbConnection connection, 
    Action callBack, CancellationToken token)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| callBack | The callback. |
| token | The cancellation token. |

## Return Value

A task representing the asynchronous operation.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)

---

# EntitySqlHelper.ForEachAsync method (2 of 4)

Asynchronously executes the data reader callback for all rows returned from the query.

```csharp
public static Task<int> ForEachAsync(this SqlQuery query, IDbConnection connection, 
    Action<IDataReader> callback, CancellationToken token)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| callback | The callback. |
| token | The cancellation token. |

## Return Value

A task representing the asynchronous operation.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)

---

# EntitySqlHelper.ForEachAsync method (3 of 4)

Asynchronously executes the specified callback for all rows returned from executing the query.

```csharp
public static Task<int> ForEachAsync(this SqlQuery query, IDbConnection connection, 
    Action callBack, IReadOnlyDictionary<string, object?>? parameters = null, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| callBack | The call back. |
| parameters | Values that override the query's parameters for this execution. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the number of returned results.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)

---

# EntitySqlHelper.ForEachAsync method (4 of 4)

Asynchronously executes the specified data reader callback for all rows returned from executing the query.

```csharp
public static Task<int> ForEachAsync(this SqlQuery query, IDbConnection connection, 
    Action<IDataReader> callback, IReadOnlyDictionary<string, object?>? parameters = null, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| callback | The call back. |
| parameters | Values that override the query's parameters for this execution. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the number of returned results.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)