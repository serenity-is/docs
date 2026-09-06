# SqlQuery.Having method

Adds an SQL expression to the GROUP BY clause.

```csharp
public SqlQuery Having(string expression)
```

| parameter | description |
| --- | --- |
| expression | Array of fields or expressions. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | expression is null or empty. |

## See Also

* class [SqlQuery](../SqlQuery.md)