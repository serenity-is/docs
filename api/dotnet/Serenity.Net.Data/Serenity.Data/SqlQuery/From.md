# SqlQuery.From method (1 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a table to the FROM statement, with given short name.

```csharp
public SqlQuery From(IAlias alias)
```

| parameter | description |
| --- | --- |
| alias | Alias that contains table name and short name. |

## Return Value

The query itself.

## Remarks

This overload requires that alias has a table name.

## See Also

* interface [IAlias](../IAlias.md)
* class [SqlQuery](../SqlQuery.md)

---

# SqlQuery.From method (2 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a table to the FROM statement. When it is called more than once, puts a comma between table names (cross join)

```csharp
public SqlQuery From(string table)
```

| parameter | description |
| --- | --- |
| table | Table name |

## Return Value

The query itself.

## See Also

* class [SqlQuery](../SqlQuery.md)

---

# SqlQuery.From method (3 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a subquery to the FROM statement, with given short name.

```csharp
public SqlQuery From(ISqlQuery subQuery, IAlias alias)
```

| parameter | description |
| --- | --- |
| subQuery | A subquery |
| alias | Alias that contains the short name. |

## Return Value

The query itself.

## Remarks

This overload requires that alias has a table name.

## See Also

* interface [ISqlQuery](../ISqlQuery.md)
* interface [IAlias](../IAlias.md)
* class [SqlQuery](../SqlQuery.md)

---

# SqlQuery.From method (4 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a table to the FROM statement with an alias. When it is called more than once, puts a comma between table names (cross join)

```csharp
public SqlQuery From(string table, IAlias alias)
```

| parameter | description |
| --- | --- |
| table | Table |
| alias | Alias for the table |

## Return Value

The query itself.

## See Also

* interface [IAlias](../IAlias.md)
* class [SqlQuery](../SqlQuery.md)