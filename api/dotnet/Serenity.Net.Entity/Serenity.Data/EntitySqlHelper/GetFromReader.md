# EntitySqlHelper.GetFromReader method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Gets field values from data reader into the query loader row.

```csharp
public static void GetFromReader(this SqlQuery query, IDataReader reader)
```

| parameter | description |
| --- | --- |
| query | The query. |
| reader | The reader. |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)

---

# EntitySqlHelper.GetFromReader method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Gets field values from data reader into the set of specified into rows.

```csharp
public static void GetFromReader(this SqlQuery query, IDataReader reader, IList<object> into)
```

| parameter | description |
| --- | --- |
| query | The query. |
| reader | The reader. |
| into | The into rows list. |

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | An exception occurred during conversion |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)