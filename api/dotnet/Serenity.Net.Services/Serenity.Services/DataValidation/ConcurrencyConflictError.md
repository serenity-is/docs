# DataValidation.ConcurrencyConflictError method

Returns a concurrency conflict error, e.g. the record was modified by another user since the version value the client sent.

```csharp
public static ValidationError ConcurrencyConflictError(ITextLocalizer? localizer)
```

| parameter | description |
| --- | --- |
| localizer | Text localizer |

## Return Value

The concurrency conflict error.

## See Also

* class [ValidationError](../../../Serenity.Net.Core/Serenity.Services/ValidationError.md)
* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)