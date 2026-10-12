# QueryWithParamsExtensions.AddParam&lt;TQuery&gt; method

Adds the parameter.

```csharp
public static Parameter AddParam<TQuery>(this TQuery self, object? value)
    where TQuery : IQueryWithParams
```

| parameter | description |
| --- | --- |
| TQuery | The query type. |
| self | The query. |
| value | The value. |

## Return Value

The automatically named parameter that was added.

## See Also

* struct [Parameter](../Parameter.md)
* interface [IQueryWithParams](../IQueryWithParams.md)
* class [QueryWithParamsExtensions](../QueryWithParamsExtensions.md)