# QueryWithParams.GetCachedToString method

Gets the cached SQL string, regenerating it when this query tree's dialect changes.

```csharp
protected string GetCachedToString(Func<ISqlDialect, string> format)
```

| parameter | description |
| --- | --- |
| format | The formatter. |

## Return Value

The SQL string.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [QueryWithParams](../QueryWithParams.md)