# CaseAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Concat expression attribute

```csharp
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class CaseAttribute : BaseExpressionAttribute
```

## Public Members

| name | description |
| --- | --- |
| [CaseAttribute](CaseAttribute/CaseAttribute.md)(…) | Creates a new instance |
| [Else](CaseAttribute/Else.md) { get; set; } | Gets the else expression |
| [Switch](CaseAttribute/Switch.md) { get; set; } | Gets the switch expression |
| [Then](CaseAttribute/Then.md) { get; } | Gets the then expressions |
| [When](CaseAttribute/When.md) { get; } | Gets the when expressions |
| override [Translate](CaseAttribute/Translate.md)(…) |  |

## See Also

* class [BaseExpressionAttribute](BaseExpressionAttribute.md)
* **Source:** *[CaseAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/CaseAttribute.cs)*