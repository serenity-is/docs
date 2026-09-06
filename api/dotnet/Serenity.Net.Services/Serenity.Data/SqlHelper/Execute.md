# SqlHelper.Execute method (1 of 3)

Executes the specified query on the connection.

```csharp
public static void Execute(this SqlInsert query, IDbConnection connection, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| logger | The logger. |

## See Also

* class [SqlInsert](../SqlInsert.md)
* class [SqlHelper](../SqlHelper.md)

---

# SqlHelper.Execute method (2 of 3)

Executes the specified delete query on the connection and returns the number of affected rows.

```csharp
public static int Execute(this SqlDelete query, IDbConnection connection, 
    ExpectedRows expectedRows = ExpectedRows.One, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| expectedRows | The expected rows. Used to validate the expected number of affected rows. |
| logger | The logger. |

## Return Value

The number of affected rows.

## See Also

* class [SqlDelete](../SqlDelete.md)
* enum [ExpectedRows](../ExpectedRows.md)
* class [SqlHelper](../SqlHelper.md)

---

# SqlHelper.Execute method (3 of 3)

Executes the specified update query on the connection and returns the number of affected rows.

```csharp
public static int Execute(this SqlUpdate query, IDbConnection connection, 
    ExpectedRows expectedRows = ExpectedRows.One, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| expectedRows | The expected rows. Used to validate the expected number of affected rows. |
| logger | The logger. |

## Return Value

The number of affected rows.

## See Also

* class [SqlUpdate](../SqlUpdate.md)
* enum [ExpectedRows](../ExpectedRows.md)
* class [SqlHelper](../SqlHelper.md)