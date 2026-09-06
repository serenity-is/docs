# SqlHelper.ExecuteReader method (1 of 2)

Executes the query.

```csharp
public static IDataReader ExecuteReader(this SqlQuery query, IDbConnection connection, 
    ILogger logger = null)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| logger | The logger. |

## Return Value

A data reader with the results.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [SqlHelper](../SqlHelper.md)

---

# SqlHelper.ExecuteReader method (2 of 2)

Executes the command returning a data reader.

```csharp
public static IDataReader ExecuteReader(IDbConnection connection, string commandText, 
    IDictionary<string, object> param, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| commandText | The command text. |
| param | The parameters. |
| logger | The logger. |

## Return Value

A data reader with the results.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | connection is null. |

## See Also

* class [SqlHelper](../SqlHelper.md)