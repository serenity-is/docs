# SqlQuery.SelectMany method

Adds field names or SQL expressions to the SELECT statement.

```csharp
public SqlQuery SelectMany(params string[] expressions)
```

| parameter | description |
| --- | --- |
| expressions | Fields or SQL expressions. |

## Return Value

The query itself.

## Remarks

No aliases are used for the fields or expressions.

## See Also

* class [SqlQuery](../SqlQuery.md)