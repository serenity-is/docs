# IAsyncValidationRule.IsValidAsync method

Checks a value asynchronously.

```csharp
public ValueTask<ValidationResult?> IsValidAsync(object? value, ValidationContext context, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| value | The value. |
| context | The context, e.g. for its services, like the connection of a save handler. |
| cancellationToken | The cancellation token. |

## Return Value

Success, i.e. null, when the value is valid, or the result with the message.

## See Also

* interface [IAsyncValidationRule](../IAsyncValidationRule.md)