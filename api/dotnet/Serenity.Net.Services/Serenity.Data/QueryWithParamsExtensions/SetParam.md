# QueryWithParamsExtensions.SetParam&lt;T&gt; method

Sets the parameter.

```csharp
public static T SetParam<T>(this T self, Parameter param, object value)
    where T : IQueryWithParams
```

| parameter | description |
| --- | --- |
| T | The query type. |
| self | The query. |
| param | The parameter. |
| value | The value. |

## Return Value

The query itself.

## See Also

* struct [Parameter](../Parameter.md)
* interface [IQueryWithParams](../IQueryWithParams.md)
* class [QueryWithParamsExtensions](../QueryWithParamsExtensions.md)