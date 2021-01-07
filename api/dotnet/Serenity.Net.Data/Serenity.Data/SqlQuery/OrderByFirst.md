# SqlQuery.OrderByFirst method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Inserts a field name or an SQL expression to the start of ORDER BY clause.

```csharp
public SqlQuery OrderByFirst(string expression, bool desc = false)
```

| parameter | description |
| --- | --- |
| expression | A field or an SQL expression. |
| desc | True to add a " DESC" suffix. |

## Return Value

The query itself.

## Remarks

This method is designed to help apply user defined orders (for example by clicking headers on a grid) to a query with existing order. SQL server throws an error if a field is used more than once in ORDER BY expression, so this function first removes normal and DESC versions of the expression from the ORDER BY statement.

## See Also

* class [SqlQuery](../SqlQuery.md)