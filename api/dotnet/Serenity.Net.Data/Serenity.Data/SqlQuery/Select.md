# SqlQuery.Select method (1 of 6)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a subquery to the SELECT statement.

```csharp
public SqlQuery Select(ISqlQuery expression)
```

| parameter | description |
| --- | --- |
| expression | A subquery. |

## Return Value

The query itself.

## See Also

* interface [ISqlQuery](../ISqlQuery.md)
* class [SqlQuery](../SqlQuery.md)

---

# SqlQuery.Select method (2 of 6)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a field name or an SQL expression to the SELECT statement.

```csharp
public SqlQuery Select(string expression)
```

| parameter | description |
| --- | --- |
| expression | A field or an SQL expression. |

## Return Value

The query itself.

## Remarks

No column name is used for the field or expression.

## See Also

* class [SqlQuery](../SqlQuery.md)

---

# SqlQuery.Select method (3 of 6)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a field of a given table alias to the SELECT statement.

```csharp
public SqlQuery Select(IAlias alias, string fieldName)
```

| parameter | description |
| --- | --- |
| alias | A table alias that will be prepended to the field name with "." between |
| fieldName | A field name of the aliased table. |

## Return Value

The query itself.

## Remarks

No column name is used for the field or expression.

## See Also

* interface [IAlias](../IAlias.md)
* class [SqlQuery](../SqlQuery.md)

---

# SqlQuery.Select method (4 of 6)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a subquery to the SELECT statement.

```csharp
public SqlQuery Select(ISqlQuery expression, string columnName)
```

| parameter | description |
| --- | --- |
| expression | A subquery. |
| columnName | A column name |

## Return Value

The query itself.

## See Also

* interface [ISqlQuery](../ISqlQuery.md)
* class [SqlQuery](../SqlQuery.md)

---

# SqlQuery.Select method (5 of 6)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a field name or expression to the SELECT statement with a column name

```csharp
public SqlQuery Select(string expression, string columnName)
```

| parameter | description |
| --- | --- |
| expression | A field name or SQL expression. |
| columnName | A column name. |

## Return Value

The query itself.

## See Also

* class [SqlQuery](../SqlQuery.md)

---

# SqlQuery.Select method (6 of 6)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a field of a given table alias to the SELECT statement with a column name.

```csharp
public SqlQuery Select(IAlias alias, string fieldName, string columnName)
```

| parameter | description |
| --- | --- |
| alias | A table alias that will be prepended to the field name with "." between |
| fieldName | A field name of the aliased table. |
| columnName | A column name |

## Return Value

The query itself.

## See Also

* interface [IAlias](../IAlias.md)
* class [SqlQuery](../SqlQuery.md)