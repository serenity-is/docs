# EntitySqlHelper.GetFirst method

Gets the first entity returned by executing the query. The result is loaded into the loader row of the query.

```csharp
public static bool GetFirst(this SqlQuery query, IDbConnection connection)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |

## Return Value

True if any rows were returned.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)