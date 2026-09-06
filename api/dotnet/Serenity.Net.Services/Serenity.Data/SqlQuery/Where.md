# SqlQuery.Where method

Adds an expression to WHERE clause. If query already has a WHERE clause, inserts AND between existing one and new one.

```csharp
public SqlQuery Where(string expression)
```

| parameter | description |
| --- | --- |
| expression | An expression |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | expression is null or empty. |

## See Also

* class [SqlQuery](../SqlQuery.md)