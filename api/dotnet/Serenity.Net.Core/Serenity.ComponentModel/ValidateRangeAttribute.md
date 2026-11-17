# ValidateRangeAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Requires a value to be between a minimum and a maximum, both included, which the forms also check. The limits are parsed, and a value given as text is converted, in the invariant culture. An empty value is valid, as being required is [`RequiredAttribute`](./RequiredAttribute.md)'s concern.

```csharp
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class ValidateRangeAttribute : RangeAttribute, IClientValidationRule, IHasTextKey
```

## Public Members

| name | description |
| --- | --- |
| [ValidateRangeAttribute](ValidateRangeAttribute/ValidateRangeAttribute.md)(…) | Creates a range of integers. (3 constructors) |
| [Rule](ValidateRangeAttribute/Rule.md) { get; } |  |
| [RuleParams](ValidateRangeAttribute/RuleParams.md) { get; } |  |
| [Side](ValidateRangeAttribute/Side.md) { get; set; } |  |
| [TextKey](ValidateRangeAttribute/TextKey.md) { get; set; } |  |
| const [Key](ValidateRangeAttribute/Key.md) | The type key of the class of the rule on the client side, i.e. `Serenity.RangeValidationRule`. |

## Protected Members

| name | description |
| --- | --- |
| override [IsValid](ValidateRangeAttribute/IsValid.md)(…) |  |

## See Also

* interface [IClientValidationRule](./IClientValidationRule.md)
* interface [IHasTextKey](../Serenity.Services/IHasTextKey.md)
* **Source:** *[ValidateRangeAttribute.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/core/ComponentModel/Validation/ValidateRangeAttribute.cs)*