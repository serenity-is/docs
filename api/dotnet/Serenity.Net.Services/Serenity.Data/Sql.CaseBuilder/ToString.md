# Sql.CaseBuilder.ToString method

Converts to string.

```csharp
public string ToString(IQueryWithParams query)
```

| parameter | description |
| --- | --- |
| query | The query. |

## Return Value

A String that represents this instance.

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | There should be at least one WHEN/THEN pair. or WHEN/THEN pairs don't match. or A THEN/ELSE query has auto parameters outside the target query's storage. |

## Remarks

Embedded queries are rendered as text only: their parameters are not merged. Pass sub-queries created from this query (e.g. via SubQuery()), which share its parameter storage, instead of standalone queries.

## See Also

* interface [IQueryWithParams](../IQueryWithParams.md)
* class [CaseBuilder](../Sql.CaseBuilder.md)