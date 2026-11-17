# ValidationRuleMessage.GetImpliedTextKey method

Gets the implied text key of the message of a rule, which is the text key of the property being validated with the suffix of the rule, e.g. `Db.Northwind.Customer.Quantity_ValidateRange`, when the context has the text key of the property, see [`PropertyTextKeyItem`](./PropertyTextKeyItem.md), and the rule has one, see [`GetTextKeySuffix`](../ValidationRules/GetTextKeySuffix.md).

```csharp
public static string? GetImpliedTextKey(ValidationAttribute attribute, ValidationContext? context)
```

| parameter | description |
| --- | --- |
| attribute | The attribute of the rule. |
| context | The context. |

## See Also

* class [ValidationRuleMessage](../ValidationRuleMessage.md)