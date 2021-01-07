# SqlHelper.ExecuteScalar method (1 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Executes the statement returning a scalar value.

```csharp
public static object ExecuteScalar(IDbConnection connection, SqlQuery selectQuery, 
    ILogger logger = null)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| selectQuery | The select query. |
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

# SqlHelper.ExecuteScalar method (2 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Executes the statement returning a scalar value.

```csharp
public static object ExecuteScalar(IDbConnection connection, string commandText, 
    ILogger logger = null)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| commandText | The command text. |
| logger | Logger |

## Return Value

Scalar value

## See Also

* class [SqlHelper](../SqlHelper.md)

---

# SqlHelper.ExecuteScalar method (3 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Executes the statement returning a scalar value.

```csharp
public static object ExecuteScalar(IDbConnection connection, SqlQuery selectQuery, 
    Dictionary<string, object> param, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| selectQuery | The select query. |
| param | The parameters. |
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

# SqlHelper.ExecuteScalar method (4 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Executes the statement returning a scalar value.

```csharp
public static object ExecuteScalar(IDbConnection connection, string commandText, 
    IDictionary<string, object> param, ILogger logger = null)
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