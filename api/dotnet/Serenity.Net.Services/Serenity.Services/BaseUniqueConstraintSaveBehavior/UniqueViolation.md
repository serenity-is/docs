# BaseUniqueConstraintSaveBehavior.UniqueViolation method

Creates the validation error that is thrown when a unique constraint is violated.

```csharp
protected static ValidationError UniqueViolation(IEnumerable<Field> fields, 
    ITextLocalizer localizer, string? errorMessage)
```

| parameter | description |
| --- | --- |
| fields | Fields that make up the unique constraint. |
| localizer | Text localizer. |
| errorMessage | Optional custom error message. |

## See Also

* class [ValidationError](../../../Serenity.Net.Core/Serenity.Services/ValidationError.md)
* class [Field](../../Serenity.Data/Field.md)
* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [BaseUniqueConstraintSaveBehavior](../BaseUniqueConstraintSaveBehavior.md)