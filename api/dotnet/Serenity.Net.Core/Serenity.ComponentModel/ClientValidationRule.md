# ClientValidationRule class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A validation rule as the forms get it, from a validation attribute of a property, see [`GetClientRule`](./ValidationRules/GetClientRule.md).

```csharp
public class ClientValidationRule
```

## Public Members

| name | description |
| --- | --- |
| [ClientValidationRule](ClientValidationRule/ClientValidationRule.md)() | The default constructor. |
| [Message](ClientValidationRule/Message.md) { get; set; } | Gets or sets the message as it is, used when there is no text of the [`TextKey`](./ClientValidationRule/TextKey.md). The default message of the rule is used when neither is set. |
| [Params](ClientValidationRule/Params.md) { get; set; } | Gets or sets the parameters of the rule, e.g. the minimum and the maximum of a range. |
| [Rule](ClientValidationRule/Rule.md) { get; set; } | Gets or sets the name of the rule on the client side, e.g. `range`. |
| [TextKey](ClientValidationRule/TextKey.md) { get; set; } | Gets or sets the local text key of the message, which is used when it has a text. |

## See Also

* **Source:** *[ClientValidationRule.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/core/ComponentModel/Validation/ClientValidationRule.cs)*