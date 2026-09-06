# SqlQuery.OrderBy method (1 of 2)

Adds a field name or an SQL expression to the ORDER BY clause.

```csharp
public SqlQuery OrderBy(string expression, bool desc = false)
```

| parameter | description |
| --- | --- |
| expression | A field or an SQL expression. |
| desc | True to add " DESC" keyword to the expression. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | expression is null or empty. |

## See Also

* class [SqlQuery](../SqlQuery.md)

---

# SqlQuery.OrderBy method (2 of 2)

Adds a field of a given table alias to the ORDER BY clause.

```csharp
public SqlQuery OrderBy(IAlias alias, string fieldName, bool desc = false)
```

| parameter | description |
| --- | --- |
| alias | A table alias that will be prepended to the field name with "." between |
| fieldName | A field name of the aliased table. |
| desc | True to add " DESC" keyword to the expression. |

## Return Value

The query itself.

## See Also

* interface [IAlias](../IAlias.md)
* class [SqlQuery](../SqlQuery.md)