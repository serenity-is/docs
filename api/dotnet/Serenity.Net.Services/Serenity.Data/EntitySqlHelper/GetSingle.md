# EntitySqlHelper.GetSingle method

Gets the single entity returned by executing the query. The values are loaded into the loader row of the query.

```csharp
public static bool GetSingle(this SqlQuery query, IDbConnection connection)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |

## Return Value

True if any results were returned from the data reader.

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | Query returned more than one result! |

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)