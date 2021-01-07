# Sql.CaseBuilder.ToString method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

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
| InvalidOperationException | There should be at least one WHEN/THEN pair. or WHEN/THEN pairs doesn't match. |

## See Also

* interface [IQueryWithParams](../IQueryWithParams.md)
* class [CaseBuilder](../Sql.CaseBuilder.md)