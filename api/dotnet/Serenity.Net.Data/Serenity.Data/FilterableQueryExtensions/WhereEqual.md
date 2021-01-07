# FilterableQueryExtensions.WhereEqual&lt;T&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a where statement with equality filter to a query, and sets the parameter value with a parameter.

```csharp
public static T WhereEqual<T>(this T self, IField field, object value)
    where T : IFilterableQuery
```

| parameter | description |
| --- | --- |
|  | Field. |
|  | Parameter value |

## Return Value

The new filter parameter.

## See Also

* class [T](../Serenity.Net.Data/../FilterableQueryExtensions.T.md)
* interface [IField](../IField.md)
* interface [IFilterableQuery](../IFilterableQuery.md)
* class [FilterableQueryExtensions](../FilterableQueryExtensions.md)