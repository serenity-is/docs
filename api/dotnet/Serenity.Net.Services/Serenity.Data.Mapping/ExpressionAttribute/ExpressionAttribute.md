# ExpressionAttribute constructor (1 of 2)
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Specifies SQL expression this property corresponds to. You may use brackets ([]) to escape identifiers. Brackets will be converted to database specific quotes.

```csharp
public ExpressionAttribute(string value)
```

| parameter | description |
| --- | --- |
| value | An SQL expression like (T0.Firstname + ' ' + T0.LastName) |

## Remarks

Specifies SQL expression this property corresponds to.

## See Also

* class [ExpressionAttribute](../ExpressionAttribute.md)

---

# ExpressionAttribute constructor (2 of 2)
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Specifies SQL expression and dialects this property corresponds to.

```csharp
public ExpressionAttribute(string expression, params ServerType[] serverTypes)
```

| parameter | description |
| --- | --- |
| expression | An SQL expression like (T0.Firstname + ' ' + T0.LastName) |
| serverTypes | Dialects like MySql, Sqlite. |

## See Also

* enum [ServerType](../../Serenity.Data/ServerType.md)
* class [ExpressionAttribute](../ExpressionAttribute.md)