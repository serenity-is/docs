# IClientValidationRule interface
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A validation attribute that the forms also check, by the client side rule class whose type key is its rule, e.g. `Range` for `Serenity.RangeValidationRule`, with the minimum and the maximum as its parameters. The Validate attributes, like [`ValidateRangeAttribute`](./ValidateRangeAttribute.md), and the ones deriving from [`ValidationRuleAttribute`](./ValidationRuleAttribute.md) implement it.

```csharp
public interface IClientValidationRule
```

## Members

| name | description |
| --- | --- |
| [Rule](IClientValidationRule/Rule.md) { get; } | Gets the type key of the class of the rule on the client side, which can be short like the keys of the editors, e.g. `Range` for `Serenity.RangeValidationRule`. |
| [RuleParams](IClientValidationRule/RuleParams.md) { get; } | Gets the parameters of the rule on the client side, which are serialized to JSON, or null when it has none. |
| [Side](IClientValidationRule/Side.md) { get; } | Gets where the rule is checked: by the forms and on the server, which is the default, or only on one of them. |

## See Also

* **Source:** *[IClientValidationRule.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/core/ComponentModel/Validation/IClientValidationRule.cs)*