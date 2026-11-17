# ValidationRules.HasLocalizableMessage method

Gets whether a rule has a message of its own, which is registered with its implied text key, see [`GetTextKeySuffix`](./GetTextKeySuffix.md), i.e. it is a rule of Serenity with an ErrorMessage.

```csharp
public static bool HasLocalizableMessage(ValidationAttribute attribute)
```

| parameter | description |
| --- | --- |
| attribute | The attribute of the rule. |

## See Also

* class [ValidationRules](../ValidationRules.md)