# QueryWithParams.CreateSubQuery&lt;TQuery&gt; method

Creates a new query that shares parameter storage and dialect with this query tree.

```csharp
public TQuery CreateSubQuery<TQuery>()
    where TQuery : QueryWithParams, new()
```

## Return Value

A new query that shares parameters.

## See Also

* class [QueryWithParams](../QueryWithParams.md)