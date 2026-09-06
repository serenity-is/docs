# SqlHelper.ExecuteAsync method (1 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes the specified query on the connection asynchronously.

```csharp
public static Task ExecuteAsync(this SqlInsert query, IDbConnection connection, 
    ILogger logger = null, CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| logger | The logger. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation.

## See Also

* class [SqlInsert](../SqlInsert.md)
* class [SqlHelper](../SqlHelper.md)

---

# SqlHelper.ExecuteAsync method (2 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes the specified delete query on the connection asynchronously and returns the number of affected rows.

```csharp
public static Task<int> ExecuteAsync(this SqlDelete query, IDbConnection connection, 
    ExpectedRows expectedRows = ExpectedRows.One, ILogger logger = null, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| expectedRows | The expected rows. Used to validate the expected number of affected rows. |
| logger | The logger. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result contains the number of affected rows.

## See Also

* class [SqlDelete](../SqlDelete.md)
* enum [ExpectedRows](../ExpectedRows.md)
* class [SqlHelper](../SqlHelper.md)

---

# SqlHelper.ExecuteAsync method (3 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes the specified update query on the connection asynchronously and returns the number of affected rows.

```csharp
public static Task<int> ExecuteAsync(this SqlUpdate query, IDbConnection connection, 
    ExpectedRows expectedRows = ExpectedRows.One, ILogger logger = null, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| expectedRows | The expected rows. Used to validate the expected number of affected rows. |
| logger | The logger. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result contains the number of affected rows.

## See Also

* class [SqlUpdate](../SqlUpdate.md)
* enum [ExpectedRows](../ExpectedRows.md)
* class [SqlHelper](../SqlHelper.md)