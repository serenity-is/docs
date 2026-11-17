# ValidationRuleMessage.Format method

Gets the message of an attribute whose value is not valid.

```csharp
public static string Format(ValidationAttribute attribute, ITextLocalizer? localizer, 
    string? impliedTextKey, string defaultKey, params object?[] args)
```

| parameter | description |
| --- | --- |
| attribute | The attribute. |
| localizer | The localizer, or null to use the invariant texts. |
| impliedTextKey | The implied text key of the message, see [`GetImpliedTextKey`](./GetImpliedTextKey.md), or null. |
| defaultKey | The local text key of the default message of the rule. |
| args | The parameters of the rule, which are put in the message. |

## See Also

* interface [ITextLocalizer](../../Serenity/ITextLocalizer.md)
* class [ValidationRuleMessage](../ValidationRuleMessage.md)