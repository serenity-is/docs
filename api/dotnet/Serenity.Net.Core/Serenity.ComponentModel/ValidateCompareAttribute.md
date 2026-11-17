# ValidateCompareAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Requires a value to be the same as the one of another property, e.g. a password and its confirmation, which the forms also check, with the field of that property.

```csharp
[AttributeUsage(AttributeTargets.Property)]
public class ValidateCompareAttribute : CompareAttribute, IClientValidationRule, IHasTextKey
```

| parameter | description |
| --- | --- |
| otherProperty | The name of the other property, e.g. `nameof(Password)`. |

## Public Members

| name | description |
| --- | --- |
| [ValidateCompareAttribute](ValidateCompareAttribute/ValidateCompareAttribute.md)(…) | Requires a value to be the same as the one of another property, e.g. a password and its confirmation, which the forms also check, with the field of that property. |
| [Rule](ValidateCompareAttribute/Rule.md) { get; } |  |
| [RuleParams](ValidateCompareAttribute/RuleParams.md) { get; } |  |
| [Side](ValidateCompareAttribute/Side.md) { get; set; } |  |
| [TextKey](ValidateCompareAttribute/TextKey.md) { get; set; } |  |
| const [Key](ValidateCompareAttribute/Key.md) | The type key of the class of the rule on the client side, i.e. `Serenity.CompareValidationRule`. |

## Protected Members

| name | description |
| --- | --- |
| override [IsValid](ValidateCompareAttribute/IsValid.md)(…) |  |

## See Also

* interface [IClientValidationRule](./IClientValidationRule.md)
* interface [IHasTextKey](../Serenity.Services/IHasTextKey.md)
* **Source:** *[ValidateCompareAttribute.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/core/ComponentModel/Validation/ValidateCompareAttribute.cs)*