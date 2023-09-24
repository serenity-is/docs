# SqlConversions.Translate method (1 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Translates the command text to target connection dialect by replacing brackets ([]), and parameter prefixes (@). If the query already has a dialect set, it uses that instead of the connection one.

```csharp
public static string Translate(IQueryWithParams query, IDbConnection connection)
```

| parameter | description |
| --- | --- |
| query | The sql query. |
| connection | The connection to get dialect from. |

## Return Value

Translated query.

## See Also

* interface [IQueryWithParams](../IQueryWithParams.md)
* class [SqlConversions](../SqlConversions.md)

---

# SqlConversions.Translate method (2 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Translates the command text to target connection dialect by replacing brackets ([]), and parameter prefixes (@).

```csharp
public static string Translate(string commandText, IDbConnection connection)
```

| parameter | description |
| --- | --- |
| commandText | The command text. |
| connection | The connection. |

## Return Value

Translated query.

## See Also

* class [SqlConversions](../SqlConversions.md)

---

# SqlConversions.Translate method (3 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Translates the command text to target dialect by replacing brackets ([]), and parameter prefixes (@).

```csharp
public static string Translate(string commandText, ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| commandText | The command text. |
| dialect | The dialect. |

## Return Value

Translated query.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlConversions](../SqlConversions.md)