# QueryWithParamsExtensions.SetParam&lt;TQuery&gt; method

Sets the parameter.

```csharp
public static TQuery SetParam<TQuery>(this TQuery self, Parameter param, object? value)
    where TQuery : IQueryWithParams
```

| parameter | description |
| --- | --- |
| TQuery | The query type. |
| self | The query. |
| param | The parameter. |
| value | The value. |

## Return Value

The query itself.

## See Also

* struct [Parameter](../Parameter.md)
* interface [IQueryWithParams](../IQueryWithParams.md)
* class [QueryWithParamsExtensions](../QueryWithParamsExtensions.md)