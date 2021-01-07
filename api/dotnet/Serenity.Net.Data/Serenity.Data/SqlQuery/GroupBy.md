# SqlQuery.GroupBy method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a field name or an SQL expression to the GROUP BY clause.

```csharp
public SqlQuery GroupBy(string expression)
```

| parameter | description |
| --- | --- |
| expression | Array of fields or expressions. |

## Return Value

The query itself.

## See Also

* class [SqlQuery](../SqlQuery.md)

---

# SqlQuery.GroupBy method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a field of a given table alias to the GROUP BY clause.

```csharp
public SqlQuery GroupBy(IAlias alias, string fieldName)
```

| parameter | description |
| --- | --- |
| alias | A table alias that will be prepended to the field name with "." between |
| fieldName | A field name of the aliased table. |

## Return Value

The query itself.

## See Also

* interface [IAlias](../IAlias.md)
* class [SqlQuery](../SqlQuery.md)