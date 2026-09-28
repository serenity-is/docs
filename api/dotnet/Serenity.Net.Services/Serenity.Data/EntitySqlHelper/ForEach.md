# EntitySqlHelper.ForEach method (1 of 2)

Executes the specified callback for all rows returned from executing the query.

```csharp
public static int ForEach(this SqlQuery query, IDbConnection connection, Action callBack, 
    IReadOnlyDictionary<string, object?>? parameters = null)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| callBack | The call back. |
| parameters | Values that override the query's parameters for this execution. |

## Return Value

Number of returned results.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)

---

# EntitySqlHelper.ForEach method (2 of 2)

Executes the specified data reader callback for all rows returned from executing the query.

```csharp
public static int ForEach(this SqlQuery query, IDbConnection connection, 
    Action<IDataReader> callback, IReadOnlyDictionary<string, object?>? parameters = null)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| callback | The call back. |
| parameters | Values that override the query's parameters for this execution. |

## Return Value

Number of returned results.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)