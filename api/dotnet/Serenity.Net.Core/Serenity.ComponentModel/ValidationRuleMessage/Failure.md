# ValidationRuleMessage.Failure method

Gets the result for an attribute whose value is not valid, with its message, see [`Format`](./Format.md), for the member being validated.

```csharp
public static ValidationResult Failure(ValidationAttribute attribute, ValidationContext? context, 
    string defaultKey, params object?[] args)
```

| parameter | description |
| --- | --- |
| attribute | The attribute. |
| context | The context, whose localizer is used, see [`GetLocalizer`](../../Serenity/ValidationContextExtensions/GetLocalizer.md), and the text key of whose property the implied text key of the message starts with, see [`PropertyTextKeyItem`](./PropertyTextKeyItem.md). |
| defaultKey | The local text key of the default message of the rule. |
| args | The parameters of the rule. |

## See Also

* class [ValidationRuleMessage](../ValidationRuleMessage.md)