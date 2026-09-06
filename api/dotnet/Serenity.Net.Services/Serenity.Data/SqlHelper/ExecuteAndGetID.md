# SqlHelper.ExecuteAndGetID method

Executes the query and returns the generated identity value. Only works for auto incremented fields, not GUIDs.

```csharp
public static long? ExecuteAndGetID(this SqlInsert query, IDbConnection connection, 
    ILogger logger = null)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| logger | The logger. |

## Return Value

The generated identity value, or null if none was generated.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | query.IdentityColumn is null. |
| NotImplementedException | The connection dialect doesn't support returning the inserted identity. |

## See Also

* class [SqlInsert](../SqlInsert.md)
* class [SqlHelper](../SqlHelper.md)