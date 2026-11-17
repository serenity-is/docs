# ValidationRuleMessage class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Gets the messages of the validation rules, which are localized: the text of the [`TextKey`](../Serenity.Services/IHasTextKey/TextKey.md) of the attribute, else the text of its implied key, which its ErrorMessage is registered with, e.g. `Db.Northwind.Customer.Quantity_ValidateRange`, see [`GetTextKeySuffix`](./ValidationRules/GetTextKeySuffix.md), else its message as it is, else the default message of the rule, by its local text key, e.g. `Validation.Range`. The parameters of the rule are put in the message, e.g. `{0}` for the minimum of a range, unlike the messages of DataAnnotations, whose `{0}` is the name of the field, as a message of a form is displayed by the field.

```csharp
public static class ValidationRuleMessage
```

## Public Members

| name | description |
| --- | --- |
| const [PropertyTextKeyItem](ValidationRuleMessage/PropertyTextKeyItem.md) | The key of the item of a ValidationContext that has the text key of the property being validated, e.g. `Db.Northwind.Customer.Quantity`, which the implied text keys of its rules start with. |
| static [Failure](ValidationRuleMessage/Failure.md)(…) | Gets the result for an attribute whose value is not valid, with its message, see [`Format`](./ValidationRuleMessage/Format.md), for the member being validated. |
| static [Format](ValidationRuleMessage/Format.md)(…) | Gets the message of an attribute whose value is not valid. |
| static [GetDefaultText](ValidationRuleMessage/GetDefaultText.md)(…) | Gets the invariant text of a default message, for when the local texts are not registered, e.g. in a unit test. |
| static [GetImpliedTextKey](ValidationRuleMessage/GetImpliedTextKey.md)(…) | Gets the implied text key of the message of a rule, which is the text key of the property being validated with the suffix of the rule, e.g. `Db.Northwind.Customer.Quantity_ValidateRange`, when the context has the text key of the property, see [`PropertyTextKeyItem`](./ValidationRuleMessage/PropertyTextKeyItem.md), and the rule has one, see [`GetTextKeySuffix`](./ValidationRules/GetTextKeySuffix.md). |

## See Also

* **Source:** *[ValidationRuleMessage.cs](https://github.com/serenity-is/Serenity/blob/3667efc070731b24eb4c550d5deb814ec080a088/src/core/ComponentModel/Validation/ValidationRuleMessage.cs)*