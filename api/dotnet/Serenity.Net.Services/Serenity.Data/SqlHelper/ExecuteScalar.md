# SqlHelper.ExecuteScalar method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes the statement returning a scalar value.

```csharp
public static object ExecuteScalar(IDbConnection connection, SqlQuery query, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| query | The select query. |
| logger | Logger |

## Return Value

Scalar value

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | selectQuery is null |

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [SqlHelper](../SqlHelper.md)

---

# SqlHelper.ExecuteScalar method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes the statement returning a scalar value.

```csharp
public static object ExecuteScalar(IDbConnection connection, string commandText, 
    IDictionary<string, object> param = null, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| commandText | The command text. |
| param | The parameters. |
| logger | Logger |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | connection |

## See Also

* class [SqlHelper](../SqlHelper.md)