# ValidationRules.ValidateAsync method

Checks a value by a validation rule on the server asynchronously, unless it is only checked by the forms. A rule that implements [`IAsyncValidationRule`](../IAsyncValidationRule.md) is awaited, and any other is checked synchronously, see [`Validate`](./Validate.md).

```csharp
public static ValueTask<string?> ValidateAsync(ValidationAttribute attribute, object? value, 
    ValidationContext context, CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| attribute | The attribute of the rule. |
| value | The value. |
| context | The context, whose localizer localizes the message. |
| cancellationToken | The cancellation token. |

## Return Value

The message, or null when the value is valid.

## See Also

* class [ValidationRules](../ValidationRules.md)