# ValidationRules.GetTextKeySuffix method

Gets the suffix of the implied text key of the message of a rule, which follows the text key of its property, e.g. `_ValidateRange` for `Db.Northwind.Customer.Quantity_ValidateRange`, by the name of its attribute without Attribute, so a property can't have two rules with the same key, as an attribute of a rule can't be repeated. An attribute that allows being repeated, e.g. one rule class for several rules, also has the name of the rule, e.g. `_ValidateClient_even`, and two of them with the same rule need a [`TextKey`](../../Serenity.Services/IHasTextKey/TextKey.md) each. Only the rules of Serenity have one, i.e. the ones that implement [`IClientValidationRule`](../IClientValidationRule.md), as the messages of the DataAnnotations attributes are texts with the name of the field as `{0}`, not localizable texts.

```csharp
public static string? GetTextKeySuffix(ValidationAttribute attribute)
```

| parameter | description |
| --- | --- |
| attribute | The attribute of the rule. |

## Return Value

The suffix, or null when the rule has none.

## See Also

* class [ValidationRules](../ValidationRules.md)