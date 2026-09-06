# ISqlExpressionTranslator.Translate method

Returns a customized version for the passed expression attribute. If the dialect has no custom handling for the expression, it should return `null`.

```csharp
public string Translate(object expression)
```

| parameter | description |
| --- | --- |
| expression | The expression attribute or a subclass. In some cases it can be another unknown object type, so the implementor should check the type. |

## Return Value

The translated expression, or `null` if the dialect cannot handle it.

## See Also

* interface [ISqlExpressionTranslator](../ISqlExpressionTranslator.md)