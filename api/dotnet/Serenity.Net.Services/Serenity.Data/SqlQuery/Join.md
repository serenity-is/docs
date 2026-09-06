# SqlQuery.Join method

Joins the specified join.

```csharp
public SqlQuery Join(Join join)
```

| parameter | description |
| --- | --- |
| join | The join. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | join is null. |
| InvalidOperationException | Another join with different expression is already in the query. |

## See Also

* class [Join](../Join.md)
* class [SqlQuery](../SqlQuery.md)