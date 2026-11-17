# CastAttribute constructor

Cast expression attribute, which converts a value to one of the types that have an equivalent in all supported databases: Int32, Int64, Decimal with [`Precision`](./Precision.md) and [`Scale`](./Scale.md), String with [`Size`](./Size.md), and Date, which drops the time. Converting a number with a fraction to an integer truncates it in SQL Server and SQLite, while it rounds it in the others. SQLite has no decimal type, so a decimal is a REAL there.

```csharp
public CastAttribute(object expression, DbType type)
```

| parameter | description |
| --- | --- |
| expression | An expression that returns the value to convert. |
| type | The type to convert to. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | The expression is null. |

## See Also

* class [CastAttribute](../CastAttribute.md)