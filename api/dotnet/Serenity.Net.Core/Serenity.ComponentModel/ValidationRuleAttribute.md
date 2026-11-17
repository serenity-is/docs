# ValidationRuleAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

The base of a custom validation rule that the forms also check, by the client side rule class of the type key [`Rule`](./ValidationRuleAttribute/Rule.md), which is given to the constructor, like the key of a custom editor, as a `Key` constant of the attribute, e.g. `public const string Key = "MyApp.EvenValidationRule"`, or else by the convention of [`GetConventionalRule`](./ValidationRuleAttribute/GetConventionalRule.md). The server typings generator finds it the same way, and imports that class in the forms that have the rule, so it is loaded with them. Its message is localized like the ones of the Validate attributes, see [`ValidationRuleMessage`](./ValidationRuleMessage.md), by [`DefaultTextKey`](./ValidationRuleAttribute/DefaultTextKey.md) when no other is given. A rule that needs to wait, e.g. for a query, can override [`IsValidValueAsync`](./ValidationRuleAttribute/IsValidValueAsync.md), which the asynchronous save handlers await, while the synchronous ones, and other validators, still call [`IsValidValue`](./ValidationRuleAttribute/IsValidValue.md).

```csharp
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public abstract class ValidationRuleAttribute : ValidationAttribute, IAsyncValidationRule, 
    IClientValidationRule, IHasTextKey
```

## Public Members

| name | description |
| --- | --- |
| virtual [Rule](ValidationRuleAttribute/Rule.md) { get; } | Gets the type key of the class of the rule on the client side, the one given to the constructor, or else the one of the attribute by the convention of [`GetConventionalRule`](./ValidationRuleAttribute/GetConventionalRule.md). A rule that overrides it to give another key is not found by the server typings generator, so its class is loaded on demand, if it implements LazyLoadInclude. |
| virtual [RuleParams](ValidationRuleAttribute/RuleParams.md) { get; } |  |
| [Side](ValidationRuleAttribute/Side.md) { get; set; } |  |
| [TextKey](ValidationRuleAttribute/TextKey.md) { get; set; } |  |
| [IsValidAsync](ValidationRuleAttribute/IsValidAsync.md)(…) |  |
| static [GetConventionalRule](ValidationRuleAttribute/GetConventionalRule.md)(…) | Gets the type key of the client side rule class of a rule attribute by convention: its full name without the Validate prefix of its name and its Attribute suffix, with a ValidationRule suffix, e.g. `MyApp.EvenValidationRule` for `MyApp.ValidateEvenAttribute`. |

## Protected Members

| name | description |
| --- | --- |
| [ValidationRuleAttribute](ValidationRuleAttribute/ValidationRuleAttribute.md)() | Creates a rule whose client side class is found by the convention of [`GetConventionalRule`](./ValidationRuleAttribute/GetConventionalRule.md). |
| [ValidationRuleAttribute](ValidationRuleAttribute/ValidationRuleAttribute.md)(…) | Creates a rule with the type key of its client side class, e.g. a `Key` constant of the attribute. |
| virtual [DefaultTextKey](ValidationRuleAttribute/DefaultTextKey.md) { get; } | Gets the local text key of the message when neither a [`TextKey`](./ValidationRuleAttribute/TextKey.md) nor a ErrorMessage is given, by default `Validation.Invalid`. |
| virtual [GetMessageArgs](ValidationRuleAttribute/GetMessageArgs.md)() | Gets the parameters that are put in the message, e.g. `{0}`, by default none. |
| override [IsValid](ValidationRuleAttribute/IsValid.md)(…) |  |
| abstract [IsValidValue](ValidationRuleAttribute/IsValidValue.md)(…) | Gets whether a value is valid. An empty value, i.e. null or an empty text, is valid without calling it, as being required is [`RequiredAttribute`](./RequiredAttribute.md)'s concern. |
| virtual [IsValidValueAsync](ValidationRuleAttribute/IsValidValueAsync.md)(…) | Gets whether a value is valid asynchronously, by default by [`IsValidValue`](./ValidationRuleAttribute/IsValidValue.md). An empty value, i.e. null or an empty text, is valid without calling it. A rule that overrides it should still give [`IsValidValue`](./ValidationRuleAttribute/IsValidValue.md) a synchronous check, as the synchronous save handlers and other validators call that one. |

## Remarks

A rule can't be repeated on a property, like the Validate attributes, as the implied text key of its message, see [`GetTextKeySuffix`](./ValidationRules/GetTextKeySuffix.md), and its rule on the client side would be the same. A derived class that is used for several rules, e.g. by a rule name given to it, can have an AttributeUsage of its own allowing it to be repeated: the implied text keys of its messages then also have the rule, e.g. `Quantity_ValidateClient_even`, and two of them with the same rule need a [`TextKey`](./ValidationRuleAttribute/TextKey.md) each.

## Examples

```csharp
public class ValidateEvenAttribute() : ValidationRuleAttribute(Key)
{
    public const string Key = "MyApp.EvenValidationRule";
    protected override string DefaultTextKey => "Validation.Even";
    protected override bool IsValidValue(object? value, ValidationContext context) =>
        Convert.ToInt64(value, CultureInfo.InvariantCulture) % 2 == 0;
}
```

## See Also

* interface [IAsyncValidationRule](./IAsyncValidationRule.md)
* interface [IClientValidationRule](./IClientValidationRule.md)
* interface [IHasTextKey](../Serenity.Services/IHasTextKey.md)
* **Source:** *[ValidationRuleAttribute.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/core/ComponentModel/Validation/ValidationRuleAttribute.cs)*