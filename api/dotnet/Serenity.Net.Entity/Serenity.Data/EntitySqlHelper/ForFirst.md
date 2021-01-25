# EntitySqlHelper.ForFirst method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Executes the specified callback for the first result returned from executing the query.

```csharp
public static bool ForFirst(this SqlQuery query, IDbConnection connection, Action callBack)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| callBack | The call back. |

## Return Value

True if any result returned.

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)

---

# EntitySqlHelper.ForFirst method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Executes the specified reader callback for the first result returned from executing the query.

```csharp
public static bool ForFirst(this SqlQuery query, IDbConnection connection, ReaderCallBack callBack)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| callBack | The call back. |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* delegate [ReaderCallBack](../Serenity.Net.Data/../ReaderCallBack.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)