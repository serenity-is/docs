# ISqlExpressionTranslator.Translate method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Returns customized version for passed expression attribute. If the dialect don't have custom handling for the expression, it should return null.

```csharp
public string Translate(object expression)
```

| parameter | description |
| --- | --- |
| expression | Expression attribute or subclass. In some cases it can be another unknown object type so the implementor should check the type. |

## See Also

* interface [ISqlExpressionTranslator](../ISqlExpressionTranslator.md)