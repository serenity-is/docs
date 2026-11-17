# ValidationRules.GetClientRule method

Gets the rule the forms check for a validation attribute, or null when they don't check it, i.e. it is only checked on the server, or is not one they know.

```csharp
public static ClientValidationRule? GetClientRule(ValidationAttribute attribute)
```

| parameter | description |
| --- | --- |
| attribute | The attribute. |

## See Also

* class [ClientValidationRule](../ClientValidationRule.md)
* class [ValidationRules](../ValidationRules.md)