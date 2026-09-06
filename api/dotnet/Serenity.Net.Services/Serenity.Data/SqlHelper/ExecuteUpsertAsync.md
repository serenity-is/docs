# SqlHelper.ExecuteUpsertAsync method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes an UPSERT (insert or update) query on the connection asynchronously and returns the number of affected rows. The key fields are used to determine whether an existing record is updated or a new record is inserted.

```csharp
public static Task<int> ExecuteUpsertAsync(this SqlInsert query, IDbConnection connection, 
    IEnumerable<string> keyFields, ExpectedRows expectedRows = ExpectedRows.Ignore, 
    ILogger logger = null, CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| query | The insert query. |
| connection | The connection. |
| keyFields | List of key fields (e.g. primary key columns) used to match an existing record. |
| expectedRows | The expected rows. Used to validate the expected number of affected rows. |
| logger | The logger. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result contains the number of affected rows.

## See Also

* class [SqlInsert](../SqlInsert.md)
* enum [ExpectedRows](../ExpectedRows.md)
* class [SqlHelper](../SqlHelper.md)