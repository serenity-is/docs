# EntitySqlQueryExtensions.Select method (1 of 5)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Adds a field's expression to the SELECT statement with its own column name. If a join alias is referenced in the field expression, and the join is defined in field's entity class, it is automatically included in the query. The field is marked as a target at current index for future loading from a data reader.

```csharp
public static SqlQuery Select(this SqlQuery query, IField field)
```

| parameter | description |
| --- | --- |
| field | Field object |
| query | The sql query |

## Return Value

The query itself.

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* interface [IField](../Serenity.Net.Data/../IField.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)

---

# EntitySqlQueryExtensions.Select method (2 of 5)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

For each field in the fields array, adds expression of the field to the SELECT statement with a column name of its name. If a join alias is referenced in the field expression, and the join is defined in field's entity class, it is automatically included in the query. The fields are marked as a target at current index for future loading from a data reader.

```csharp
public static SqlQuery Select(this SqlQuery query, params IField[] fields)
```

| parameter | description |
| --- | --- |
| query | The query. |
| fields | Field objects |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | fields |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* interface [IField](../Serenity.Net.Data/../IField.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)

---

# EntitySqlQueryExtensions.Select method (3 of 5)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Adds a field of a given table alias to the SELECT statement.

```csharp
public static SqlQuery Select(this SqlQuery query, IAlias alias, IField field)
```

| parameter | description |
| --- | --- |
| query | The query. |
| alias | A table alias that will be prepended to the field name with "." between |
| field | A field that only name will be used. It won't be set as a target. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | alias or field |

## Remarks

No column name is set for the selected field. Also field is not set as a target, unlike field only overload, only field name is used.

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* interface [IAlias](../Serenity.Net.Data/../IAlias.md)
* interface [IField](../Serenity.Net.Data/../IField.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)

---

# EntitySqlQueryExtensions.Select method (4 of 5)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Adds a field's expression to the SELECT statement with a given column name. If a join alias is referenced in the field expression, and the join is defined in field's entity class, it is automatically included in the query. The field is marked as a target at current index for future loading from a data reader.

```csharp
public static SqlQuery Select(this SqlQuery query, IField field, string columnName)
```

| parameter | description |
| --- | --- |
| query | The query. |
| field | Field object |
| columnName | Name of the column. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field or columnName |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* interface [IField](../Serenity.Net.Data/../IField.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)

---

# EntitySqlQueryExtensions.Select method (5 of 5)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Adds a field of a given table alias to the SELECT statement.

```csharp
public static SqlQuery Select(this SqlQuery query, IAlias alias, IField field, string columnName)
```

| parameter | description |
| --- | --- |
| query | The query. |
| alias | A table alias that will be prepended to the field name with "." between |
| field | A field that only its field name will be used. It won't be set as a target. |
| columnName | A column name |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | alias or field or columnName |

## Remarks

Field is not set as a target, unlike field only overload, only field name is used.

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* interface [IAlias](../Serenity.Net.Data/../IAlias.md)
* interface [IField](../Serenity.Net.Data/../IField.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)