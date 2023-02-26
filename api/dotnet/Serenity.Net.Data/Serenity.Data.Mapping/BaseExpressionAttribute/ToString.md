# BaseExpressionAttribute.ToString method (1 of 2)
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Converts the expression to string for specified dialect

```csharp
public string ToString(ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| dialect | Target dialect |

## See Also

* interface [ISqlDialect](../../Serenity.Data/ISqlDialect.md)
* class [BaseExpressionAttribute](../BaseExpressionAttribute.md)

---

# BaseExpressionAttribute.ToString method (2 of 2)
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Convert the expression to string. Used by derived expression attributes to convert their constructor arguments to string while supporting other expression attribute types, or a special array with the first argument as the attribute type and others as its constructor parameters.

```csharp
public static string ToString(object expression, ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| expression | Expression |
| dialect | Target dialect |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Dialect is null |

## See Also

* interface [ISqlDialect](../../Serenity.Data/ISqlDialect.md)
* class [BaseExpressionAttribute](../BaseExpressionAttribute.md)