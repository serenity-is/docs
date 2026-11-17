# ValidationRuleAttribute.GetConventionalRule method

Gets the type key of the client side rule class of a rule attribute by convention: its full name without the Validate prefix of its name and its Attribute suffix, with a ValidationRule suffix, e.g. `MyApp.EvenValidationRule` for `MyApp.ValidateEvenAttribute`.

```csharp
public static string GetConventionalRule(Type attributeType)
```

| parameter | description |
| --- | --- |
| attributeType | The type of the attribute. |

## See Also

* class [ValidationRuleAttribute](../ValidationRuleAttribute.md)