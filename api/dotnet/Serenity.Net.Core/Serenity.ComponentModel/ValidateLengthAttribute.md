# ValidateLengthAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Requires a text to have no more than a number of characters, and no fewer than MinimumLength when it is set, which the forms also check. An empty value is valid, as being required is [`RequiredAttribute`](./RequiredAttribute.md)'s concern.

```csharp
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class ValidateLengthAttribute : StringLengthAttribute, IClientValidationRule, IHasTextKey
```

| parameter | description |
| --- | --- |
| maximumLength | The most characters the text can have. |

## Public Members

| name | description |
| --- | --- |
| [ValidateLengthAttribute](ValidateLengthAttribute/ValidateLengthAttribute.md)(…) | Requires a text to have no more than a number of characters, and no fewer than MinimumLength when it is set, which the forms also check. An empty value is valid, as being required is [`RequiredAttribute`](./RequiredAttribute.md)'s concern. |
| [Rule](ValidateLengthAttribute/Rule.md) { get; } |  |
| [RuleParams](ValidateLengthAttribute/RuleParams.md) { get; } | Gets the minimum and the maximum length, where a minimum of zero is none. |
| [Side](ValidateLengthAttribute/Side.md) { get; set; } |  |
| [TextKey](ValidateLengthAttribute/TextKey.md) { get; set; } |  |
| const [Key](ValidateLengthAttribute/Key.md) | The type key of the class of the rule on the client side, i.e. `Serenity.LengthValidationRule`. |

## Protected Members

| name | description |
| --- | --- |
| override [IsValid](ValidateLengthAttribute/IsValid.md)(…) |  |

## See Also

* interface [IClientValidationRule](./IClientValidationRule.md)
* interface [IHasTextKey](../Serenity.Services/IHasTextKey.md)
* **Source:** *[ValidateLengthAttribute.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/core/ComponentModel/Validation/ValidateLengthAttribute.cs)*