# ConcatAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Concat expression attribute

```csharp
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class ConcatAttribute : BaseExpressionAttribute
```

## Public Members

| name | description |
| --- | --- |
| [ConcatAttribute](ConcatAttribute/ConcatAttribute.md)(…) | Creates a new instance |
| [Expressions](ConcatAttribute/Expressions.md) { get; } | Gets the expressions |
| [NullAsEmpty](ConcatAttribute/NullAsEmpty.md) { get; set; } | When true (default), NULLS values are assumed to be empty. This is done using the COALESCE operator for dialects that is necessary. SQLServer Concat() returns empty string even when all the arguments are null. Oracle only returns null when all the arguments are null. |
| override [Translate](ConcatAttribute/Translate.md)(…) |  |

## See Also

* class [BaseExpressionAttribute](BaseExpressionAttribute.md)
* **Source:** *[ConcatAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/ConcatAttribute.cs)*