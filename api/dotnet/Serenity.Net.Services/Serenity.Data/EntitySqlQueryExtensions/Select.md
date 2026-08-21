# EntitySqlQueryExtensions.Select method (1 of 5)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Adds a field's expression to the SELECT statement with its own column name. If a join alias is referenced in the field expression, and the join is defined in the field's entity class, it is automatically included in the query. The field is marked as a target at the current index for future loading from a data reader.

```csharp
public static SqlQuery Select(this SqlQuery query, IField field)
```

| parameter | description |
| --- | --- |
| field | The field object. |
| query | The SQL query. |

## Return Value

The query itself.

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IField](../IField.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)

---

# EntitySqlQueryExtensions.Select method (2 of 5)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

For each field in the fields array, adds the expression of the field to the SELECT statement with a column name of its name. If a join alias is referenced in the field expression, and the join is defined in the field's entity class, it is automatically included in the query. The fields are marked as a target at the current index for future loading from a data reader.

```csharp
public static SqlQuery Select(this SqlQuery query, params IField[] fields)
```

| parameter | description |
| --- | --- |
| query | The query. |
| fields | The field objects. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | fields is null. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IField](../IField.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)

---

# EntitySqlQueryExtensions.Select method (3 of 5)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Adds a field of a given table alias to the SELECT statement.

```csharp
public static SqlQuery Select(this SqlQuery query, IAlias alias, IField field)
```

| parameter | description |
| --- | --- |
| query | The query. |
| alias | A table alias that will be prepended to the field name with "." between. |
| field | A field that only its name will be used. It won't be set as a target. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | alias or field |

## Remarks

No column name is set for the selected field. Also the field is not set as a target, unlike the field only overload, only the field name is used.

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IAlias](../IAlias.md)
* interface [IField](../IField.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)

---

# EntitySqlQueryExtensions.Select method (4 of 5)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Adds a field's expression to the SELECT statement with a given column name. If a join alias is referenced in the field expression, and the join is defined in the field's entity class, it is automatically included in the query. The field is marked as a target at the current index for future loading from a data reader.

```csharp
public static SqlQuery Select(this SqlQuery query, IField field, string columnName)
```

| parameter | description |
| --- | --- |
| query | The query. |
| field | The field object. |
| columnName | Name of the column. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field or columnName |

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IField](../IField.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)

---

# EntitySqlQueryExtensions.Select method (5 of 5)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Adds a field of a given table alias to the SELECT statement.

```csharp
public static SqlQuery Select(this SqlQuery query, IAlias alias, IField field, string columnName)
```

| parameter | description |
| --- | --- |
| query | The query. |
| alias | A table alias that will be prepended to the field name with "." between. |
| field | A field that only its field name will be used. It won't be set as a target. |
| columnName | A column name. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | alias or field or columnName |

## Remarks

The field is not set as a target, unlike the field only overload, only the field name is used.

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IAlias](../IAlias.md)
* interface [IField](../IField.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)