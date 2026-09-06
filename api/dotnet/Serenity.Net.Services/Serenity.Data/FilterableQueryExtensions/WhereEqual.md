# FilterableQueryExtensions.WhereEqual&lt;T&gt; method

Adds a where statement with equality filter to a query, and sets the parameter value with a parameter.

```csharp
public static T WhereEqual<T>(this T self, IField field, object value)
    where T : IFilterableQuery
```

| parameter | description |
| --- | --- |
| self | Query. |
| field | Field. |
| value | Parameter value. |

## Return Value

The new filter parameter.

## See Also

* interface [IField](../IField.md)
* interface [IFilterableQuery](../IFilterableQuery.md)
* class [FilterableQueryExtensions](../FilterableQueryExtensions.md)