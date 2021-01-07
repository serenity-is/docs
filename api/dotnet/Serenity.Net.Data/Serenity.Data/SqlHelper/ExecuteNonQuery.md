# SqlHelper.ExecuteNonQuery method (1 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Executes the SQL statement, and returns affected rows.

```csharp
public static int ExecuteNonQuery(IDbCommand command, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| command | The command. |
| logger | Logger |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | command is null or command.Connection is null. |

## See Also

* class [SqlHelper](../SqlHelper.md)

---

# SqlHelper.ExecuteNonQuery method (2 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Executes the statement.

```csharp
public static int ExecuteNonQuery(IDbConnection connection, string commandText, 
    ILogger logger = null)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| commandText | The command text. |
| logger | Logger |

## Return Value

Number of affected rows

## See Also

* class [SqlHelper](../SqlHelper.md)

---

# SqlHelper.ExecuteNonQuery method (3 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Executes the statement

```csharp
public static int ExecuteNonQuery(IDbConnection connection, string commandText, 
    IDictionary<string, object> param, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| commandText | The command text. |
| param | The parameters. |
| logger | Logger |

## Return Value

Number of affected rows

## See Also

* class [SqlHelper](../SqlHelper.md)