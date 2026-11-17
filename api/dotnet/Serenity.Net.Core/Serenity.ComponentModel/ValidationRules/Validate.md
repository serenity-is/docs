# ValidationRules.Validate method

Checks a value by a validation rule on the server, unless it is only checked by the forms.

```csharp
public static string? Validate(ValidationAttribute attribute, object? value, 
    ValidationContext context)
```

| parameter | description |
| --- | --- |
| attribute | The attribute of the rule. |
| value | The value. |
| context | The context, whose localizer localizes the message, see [`GetLocalizer`](../../Serenity/ValidationContextExtensions/GetLocalizer.md). |

## Return Value

The message, or null when the value is valid.

## See Also

* class [ValidationRules](../ValidationRules.md)