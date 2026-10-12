# SqlQuery.Union method

Adds a union to query with the specified union type.

```csharp
public SqlQuery Union(SqlUnionType unionType = SqlUnionType.Union)
```

| parameter | description |
| --- | --- |
| unionType | Type of the union. |

## Return Value

The query itself.

## Remarks

This saves the current SELECT as one leg of the UNION and starts a new SELECT leg. [`Skip`](./Skip.md), [`Take`](./Take.md), and [`CountRecords`](./CountRecords.md) apply to the leg on which they are set; they do not apply to the combined UNION result. To page or count the complete UNION, use it as a subquery in a parent query and set those options on the parent query.

## See Also

* enum [SqlUnionType](../SqlUnionType.md)
* class [SqlQuery](../SqlQuery.md)