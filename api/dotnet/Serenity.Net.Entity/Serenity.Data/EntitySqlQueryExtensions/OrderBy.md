# EntitySqlQueryExtensions.OrderBy method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Adds fields expressions to order by list

```csharp
public static SqlQuery OrderBy(this SqlQuery query, params IField[] fields)
```

| parameter | description |
| --- | --- |
| query | The query. |
| fields | The fields. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | fields |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* interface [IField](../Serenity.Net.Data/../IField.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)

---

# EntitySqlQueryExtensions.OrderBy method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Adds fields expression to order by list

```csharp
public static SqlQuery OrderBy(this SqlQuery query, IField field, bool desc = false)
```

| parameter | description |
| --- | --- |
| query | The query. |
| field | The field. |
| desc | if set to `true` [desc]. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* interface [IField](../Serenity.Net.Data/../IField.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)