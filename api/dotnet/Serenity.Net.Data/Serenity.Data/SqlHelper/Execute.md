# SqlHelper.Execute method (1 of 5)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Executes the specified query on connection.

```csharp
public static void Execute(this SqlInsert query, IDbConnection connection, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| logger | Logger |

## See Also

* class [SqlInsert](../SqlInsert.md)
* class [SqlHelper](../SqlHelper.md)

---

# SqlHelper.Execute method (2 of 5)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Executes the specified delete query on connection and returns number of affected rows.

```csharp
public static int Execute(this SqlDelete query, IDbConnection connection, 
    ExpectedRows expectedRows = ExpectedRows.One, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| expectedRows | The expected rows. Used to validate expected number of affected rows. |
| logger | Logger |

## Return Value

Number of affected rows.

## See Also

* class [SqlDelete](../SqlDelete.md)
* enum [ExpectedRows](../ExpectedRows.md)
* class [SqlHelper](../SqlHelper.md)

---

# SqlHelper.Execute method (3 of 5)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Executes the query on connection with specified params.

```csharp
public static void Execute(this SqlInsert query, IDbConnection connection, 
    Dictionary<string, object> param, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| param | The parameters. |
| logger | Logger |

## See Also

* class [SqlInsert](../SqlInsert.md)
* class [SqlHelper](../SqlHelper.md)

---

# SqlHelper.Execute method (4 of 5)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Executes the specified update query on connection and returns number of affected rows.

```csharp
public static int Execute(this SqlUpdate query, IDbConnection connection, 
    ExpectedRows expectedRows = ExpectedRows.One, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| expectedRows | The expected rows. Used to validate expected number of affected rows. |
| logger | Logger |

## Return Value

Number of affected rows.

## See Also

* class [SqlUpdate](../SqlUpdate.md)
* enum [ExpectedRows](../ExpectedRows.md)
* class [SqlHelper](../SqlHelper.md)

---

# SqlHelper.Execute method (5 of 5)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Executes the specified delete query on connection and returns number of affected rows.

```csharp
public static int Execute(this SqlDelete query, IDbConnection connection, 
    Dictionary<string, object> param, ExpectedRows expectedRows = ExpectedRows.One, 
    ILogger logger = null)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| param | The parameters. |
| expectedRows | The expected rows. Used to validate expected number of affected rows. |
| logger | Logger |

## Return Value

Number of affected rows.

## See Also

* class [SqlDelete](../SqlDelete.md)
* enum [ExpectedRows](../ExpectedRows.md)
* class [SqlHelper](../SqlHelper.md)