# ValidatePatternAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Requires a text to match a regular expression as a whole, which the forms also check. The expression is matched with ECMAScript semantics on the server, as the browsers match it, so it should only use what both have, e.g. no named groups or lookbehinds. An empty value is valid, as being required is [`RequiredAttribute`](./RequiredAttribute.md)'s concern.

```csharp
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class ValidatePatternAttribute : RegularExpressionAttribute, IClientValidationRule, 
    IHasTextKey
```

| parameter | description |
| --- | --- |
| pattern | The regular expression, without anchors, as the whole text has to match it. |

## Public Members

| name | description |
| --- | --- |
| [ValidatePatternAttribute](ValidatePatternAttribute/ValidatePatternAttribute.md)(…) | Requires a text to match a regular expression as a whole, which the forms also check. The expression is matched with ECMAScript semantics on the server, as the browsers match it, so it should only use what both have, e.g. no named groups or lookbehinds. An empty value is valid, as being required is [`RequiredAttribute`](./RequiredAttribute.md)'s concern. |
| [Rule](ValidatePatternAttribute/Rule.md) { get; } |  |
| [RuleParams](ValidatePatternAttribute/RuleParams.md) { get; } |  |
| [Side](ValidatePatternAttribute/Side.md) { get; set; } |  |
| [TextKey](ValidatePatternAttribute/TextKey.md) { get; set; } |  |
| override [IsValid](ValidatePatternAttribute/IsValid.md)(…) |  |
| const [Key](ValidatePatternAttribute/Key.md) | The type key of the class of the rule on the client side, i.e. `Serenity.PatternValidationRule`. |

## Protected Members

| name | description |
| --- | --- |
| override [IsValid](ValidatePatternAttribute/IsValid.md)(…) |  |

## See Also

* interface [IClientValidationRule](./IClientValidationRule.md)
* interface [IHasTextKey](../Serenity.Services/IHasTextKey.md)
* **Source:** *[ValidatePatternAttribute.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/core/ComponentModel/Validation/ValidatePatternAttribute.cs)*