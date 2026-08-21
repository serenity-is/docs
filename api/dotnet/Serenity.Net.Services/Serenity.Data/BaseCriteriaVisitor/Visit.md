# BaseCriteriaVisitor.Visit method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Visits the specified criteria.

```csharp
protected virtual BaseCriteria Visit(BaseCriteria criteria)
```

| parameter | description |
| --- | --- |
| criteria | The criteria. |

## Return Value

The visited criteria, which may be a reworked version.

## Exceptions

| exception | condition |
| --- | --- |
| Exception | Criteria type is unknown. |

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* class [BaseCriteriaVisitor](../BaseCriteriaVisitor.md)