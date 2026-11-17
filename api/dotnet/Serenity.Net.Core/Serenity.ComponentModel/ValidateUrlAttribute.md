# ValidateUrlAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Requires a text to be an absolute http, https or ftp address with a host, which the forms also check. It is stricter than UrlAttribute, which only checks how the text starts, and can not be derived from. Like it, it is a DataTypeAttribute of Url, which tools like OpenAPI read. An empty value is valid, as being required is [`RequiredAttribute`](./RequiredAttribute.md)'s concern.

```csharp
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class ValidateUrlAttribute : DataTypeAttribute, IClientValidationRule, IHasTextKey
```

## Public Members

| name | description |
| --- | --- |
| [ValidateUrlAttribute](ValidateUrlAttribute/ValidateUrlAttribute.md)() | Requires a text to be an absolute http, https or ftp address with a host, which the forms also check. It is stricter than UrlAttribute, which only checks how the text starts, and can not be derived from. Like it, it is a DataTypeAttribute of Url, which tools like OpenAPI read. An empty value is valid, as being required is [`RequiredAttribute`](./RequiredAttribute.md)'s concern. |
| [Rule](ValidateUrlAttribute/Rule.md) { get; } |  |
| [RuleParams](ValidateUrlAttribute/RuleParams.md) { get; } |  |
| [Side](ValidateUrlAttribute/Side.md) { get; set; } |  |
| [TextKey](ValidateUrlAttribute/TextKey.md) { get; set; } |  |
| override [IsValid](ValidateUrlAttribute/IsValid.md)(…) |  |
| const [Key](ValidateUrlAttribute/Key.md) | The type key of the class of the rule on the client side, i.e. `Serenity.UrlValidationRule`. |

## Protected Members

| name | description |
| --- | --- |
| override [IsValid](ValidateUrlAttribute/IsValid.md)(…) |  |

## See Also

* interface [IClientValidationRule](./IClientValidationRule.md)
* interface [IHasTextKey](../Serenity.Services/IHasTextKey.md)
* **Source:** *[ValidateUrlAttribute.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/core/ComponentModel/Validation/ValidateUrlAttribute.cs)*