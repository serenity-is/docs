# EntityQueryExtensions.SelectTableFields method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Adds actual table fields in a row to select list of a query.

```csharp
public static SqlQuery SelectTableFields(this SqlQuery query, params Field[] exclude)
```

| parameter | description |
| --- | --- |
| query | Query to select fields into (required). |
| exclude | Fields to be excluded (optional). |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* class [Field](../Field.md)
* class [EntityQueryExtensions](../EntityQueryExtensions.md)

---

# EntityQueryExtensions.SelectTableFields method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Adds actual table fields in a row to select list of a query.

```csharp
public static SqlQuery SelectTableFields(this SqlQuery query, IRow row, params Field[] exclude)
```

| parameter | description |
| --- | --- |
| query | Query to select fields into (required). |
| row | Row with fields to be selected (required). |
| exclude | Fields to be excluded (optional). |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [Field](../Field.md)
* class [EntityQueryExtensions](../EntityQueryExtensions.md)