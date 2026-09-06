# SetFieldByStatementExtensions.Set&lt;T&gt; method

Sets a field value with a parameter.

```csharp
public static T Set<T>(this T self, string field, object value)
    where T : ISetFieldByStatement
```

| parameter | description |
| --- | --- |
| self | The object itself. |
| field | Field name. |
| value | Parameter value. |

## Return Value

Object itself.

## See Also

* interface [ISetFieldByStatement](../ISetFieldByStatement.md)
* class [SetFieldByStatementExtensions](../SetFieldByStatementExtensions.md)