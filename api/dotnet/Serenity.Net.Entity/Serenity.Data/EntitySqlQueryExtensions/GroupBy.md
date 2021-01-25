# EntitySqlQueryExtensions.GroupBy method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Adds fields expressions to group by list

```csharp
public static SqlQuery GroupBy(this SqlQuery query, IField field)
```

| parameter | description |
| --- | --- |
| query | The query. |
| field | The field. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* interface [IField](../Serenity.Net.Data/../IField.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)

---

# EntitySqlQueryExtensions.GroupBy method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Adds fields expression to group by list

```csharp
public static SqlQuery GroupBy(this SqlQuery query, params IField[] fields)
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