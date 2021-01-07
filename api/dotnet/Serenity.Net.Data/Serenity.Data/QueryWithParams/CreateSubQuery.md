# QueryWithParams.CreateSubQuery&lt;TQuery&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a new query that shares parameter dictionary with this query.

```csharp
public TQuery CreateSubQuery<TQuery>()
    where TQuery : QueryWithParams, new()
```

## Return Value

A new query that shares parameters.

## See Also

* class [TQuery](../Serenity.Net.Data/../QueryWithParams.TQuery.md)
* class [QueryWithParams](../QueryWithParams.md)