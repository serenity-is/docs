# ValidateEmailAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Requires a text to be an email address, by [`Pattern`](./ValidateEmailAttribute/Pattern.md), which is stricter than EmailAddressAttribute, as that only checks for an @ that is not the first or the last character, and can not be derived from. Like it, it is a DataTypeAttribute of EmailAddress, which tools like OpenAPI read. The forms also check it. An empty value is valid, as being required is [`RequiredAttribute`](./RequiredAttribute.md)'s concern.

```csharp
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class ValidateEmailAttribute : DataTypeAttribute, IClientValidationRule, IHasTextKey
```

## Public Members

| name | description |
| --- | --- |
| [ValidateEmailAttribute](ValidateEmailAttribute/ValidateEmailAttribute.md)() | Requires a text to be an email address, by [`Pattern`](./ValidateEmailAttribute/Pattern.md), which is stricter than EmailAddressAttribute, as that only checks for an @ that is not the first or the last character, and can not be derived from. Like it, it is a DataTypeAttribute of EmailAddress, which tools like OpenAPI read. The forms also check it. An empty value is valid, as being required is [`RequiredAttribute`](./RequiredAttribute.md)'s concern. |
| [Rule](ValidateEmailAttribute/Rule.md) { get; } |  |
| [RuleParams](ValidateEmailAttribute/RuleParams.md) { get; } |  |
| [Side](ValidateEmailAttribute/Side.md) { get; set; } |  |
| [TextKey](ValidateEmailAttribute/TextKey.md) { get; set; } |  |
| override [IsValid](ValidateEmailAttribute/IsValid.md)(…) |  |
| const [Key](ValidateEmailAttribute/Key.md) | The type key of the class of the rule on the client side, i.e. `Serenity.EmailValidationRule`. |
| static readonly [Pattern](ValidateEmailAttribute/Pattern.md) | The pattern of an email address, of ASCII letters, digits and the symbols an address can have before the @, and a domain of labels of letters, digits and hyphens. |

## Protected Members

| name | description |
| --- | --- |
| override [IsValid](ValidateEmailAttribute/IsValid.md)(…) |  |

## See Also

* interface [IClientValidationRule](./IClientValidationRule.md)
* interface [IHasTextKey](../Serenity.Services/IHasTextKey.md)
* **Source:** *[ValidateEmailAttribute.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/core/ComponentModel/Validation/ValidateEmailAttribute.cs)*