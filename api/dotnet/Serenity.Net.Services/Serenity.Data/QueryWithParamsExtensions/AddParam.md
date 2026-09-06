# QueryWithParamsExtensions.AddParam&lt;T&gt; method

Adds the parameter.

```csharp
public static Parameter AddParam<T>(this T self, object value)
    where T : IQueryWithParams
```

| parameter | description |
| --- | --- |
| T | The query type. |
| self | The query. |
| value | The value. |

## Return Value

The automatically named parameter that was added.

## See Also

* struct [Parameter](../Parameter.md)
* interface [IQueryWithParams](../IQueryWithParams.md)
* class [QueryWithParamsExtensions](../QueryWithParamsExtensions.md)