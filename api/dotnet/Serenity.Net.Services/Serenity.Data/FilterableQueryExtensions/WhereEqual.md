# FilterableQueryExtensions.WhereEqual&lt;T&gt; method

Adds a where statement with equality filter to a query, and sets the parameter value with a parameter.

```csharp
public static T WhereEqual<T>(this T self, IField field, object? value, bool emitIsNull = false)
    where T : IFilterableQuery
```

| parameter | description |
| --- | --- |
| self | Query. |
| field | Field. |
| value | Parameter value. |
| emitIsNull | When true and *value* is null, an IS NULL filter is emitted instead of an equality check. This is false by default, in which case null produces a plain equality against NULL that never matches (matching SQL three-valued logic and Criteria equality semantics). |

## Return Value

The new filter parameter.

## See Also

* interface [IField](../IField.md)
* interface [IFilterableQuery](../IFilterableQuery.md)
* class [FilterableQueryExtensions](../FilterableQueryExtensions.md)