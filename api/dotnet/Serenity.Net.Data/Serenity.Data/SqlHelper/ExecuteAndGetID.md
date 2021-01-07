# SqlHelper.ExecuteAndGetID method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Executes the query and returns the generated identity value. Only works for auto incremented fields, not GUIDs.

```csharp
public static long? ExecuteAndGetID(this SqlInsert query, IDbConnection connection, 
    ILogger logger = null)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| logger | Logger |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | query.IdentityColumn is null |
| NotImplementedException | The connection dialect doesn't support returning inserted identity. |

## See Also

* class [SqlInsert](../SqlInsert.md)
* class [SqlHelper](../SqlHelper.md)