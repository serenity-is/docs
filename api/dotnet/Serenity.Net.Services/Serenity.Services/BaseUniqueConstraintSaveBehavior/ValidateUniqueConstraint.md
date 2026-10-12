# BaseUniqueConstraintSaveBehavior.ValidateUniqueConstraint method

Validates that no record violates the unique constraint defined by the passed fields.

```csharp
protected virtual void ValidateUniqueConstraint(ISaveRequestHandler handler, 
    IEnumerable<Field> fields, ITextLocalizer localizer, string? errorMessage = null, 
    BaseCriteria? groupCriteria = null)
```

| parameter | description |
| --- | --- |
| handler | Save request handler. |
| fields | Fields that make up the unique constraint. |
| localizer | Text localizer. |
| errorMessage | Optional custom error message. |
| groupCriteria | Optional additional criteria to scope the check. |

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | A record with the same unique values already exists. |

## See Also

* interface [ISaveRequestHandler](../ISaveRequestHandler.md)
* class [Field](../../Serenity.Data/Field.md)
* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [BaseCriteria](../../Serenity.Data/BaseCriteria.md)
* class [BaseUniqueConstraintSaveBehavior](../BaseUniqueConstraintSaveBehavior.md)