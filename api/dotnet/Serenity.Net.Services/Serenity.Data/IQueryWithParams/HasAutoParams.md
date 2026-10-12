# IQueryWithParams.HasAutoParams property

Gets a value indicating whether any automatically named parameters were generated for this query or one of the queries sharing its parameter storage. Manually named parameters don't affect this. Note that this may still return false before the query is rendered (e.g. via ToString()), as auto parameters only materialize at render time.

```csharp
public bool HasAutoParams { get; }
```

## See Also

* interface [IQueryWithParams](../IQueryWithParams.md)