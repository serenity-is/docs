# ValidationRules class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Finds the validation rules of a property, the forms' form of them, and checks them on the server. The rules are the ValidationAttributes of the property and the ones its other attributes imply, see [`IImpliesValidation`](./IImpliesValidation.md). The Validate attributes, like [`ValidateRangeAttribute`](./ValidateRangeAttribute.md), are also checked by the forms, and so are the DataAnnotations attributes they derive from, which have the default messages of Serenity when they are not given one, while any other ValidationAttribute is only checked on the server.

```csharp
public static class ValidationRules
```

## Public Members

| name | description |
| --- | --- |
| static [GetClientRule](ValidationRules/GetClientRule.md)(…) | Gets the rule the forms check for a validation attribute, or null when they don't check it, i.e. it is only checked on the server, or is not one they know. |
| static [GetRules](ValidationRules/GetRules.md)(…) | Gets the validation rules among the attributes of a property, and the ones its other attributes imply. |
| static [GetTextKeySuffix](ValidationRules/GetTextKeySuffix.md)(…) | Gets the suffix of the implied text key of the message of a rule, which follows the text key of its property, e.g. `_ValidateRange` for `Db.Northwind.Customer.Quantity_ValidateRange`, by the name of its attribute without Attribute, so a property can't have two rules with the same key, as an attribute of a rule can't be repeated. An attribute that allows being repeated, e.g. one rule class for several rules, also has the name of the rule, e.g. `_ValidateClient_even`, and two of them with the same rule need a [`TextKey`](../Serenity.Services/IHasTextKey/TextKey.md) each. Only the rules of Serenity have one, i.e. the ones that implement [`IClientValidationRule`](./IClientValidationRule.md), as the messages of the DataAnnotations attributes are texts with the name of the field as `{0}`, not localizable texts. |
| static [HasLocalizableMessage](ValidationRules/HasLocalizableMessage.md)(…) | Gets whether a rule has a message of its own, which is registered with its implied text key, see [`GetTextKeySuffix`](./ValidationRules/GetTextKeySuffix.md), i.e. it is a rule of Serenity with an ErrorMessage. |
| static [Validate](ValidationRules/Validate.md)(…) | Checks a value by a validation rule on the server, unless it is only checked by the forms. |
| static [ValidateAsync](ValidationRules/ValidateAsync.md)(…) | Checks a value by a validation rule on the server asynchronously, unless it is only checked by the forms. A rule that implements [`IAsyncValidationRule`](./IAsyncValidationRule.md) is awaited, and any other is checked synchronously, see [`Validate`](./ValidationRules/Validate.md). |
| static [ValidateObject](ValidationRules/ValidateObject.md)(…) | Validates the properties of an object by what the properties of its type, or of the [`RulesType`](./ObjectValidationOptions/RulesType.md), e.g. a form, declare: [`RequiredAttribute`](./RequiredAttribute.md), [`RequiredWhenAttribute`](./RequiredWhenAttribute.md) and the validation rules, like [`ValidateRangeAttribute`](./ValidateRangeAttribute.md). As in the browser, a property that is hidden, by [`VisibleAttribute`](./VisibleAttribute.md), on insert or update, or by its [`VisibleWhenAttribute`](./VisibleWhenAttribute.md)s, or is read only, by ReadOnlyAttribute or its [`ReadOnlyWhenAttribute`](./ReadOnlyWhenAttribute.md)s, is not checked, and neither is a rule only checked by the forms. |
| static [ValidateObjectAsync](ValidationRules/ValidateObjectAsync.md)(…) | Validates the properties of an object like [`ValidateObject`](./ValidationRules/ValidateObject.md), awaiting the rules that can be checked asynchronously, see [`IAsyncValidationRule`](./IAsyncValidationRule.md). |

## See Also

* **Source:** *[ValidationRules.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/core/ComponentModel/Validation/ValidationRules.cs)*