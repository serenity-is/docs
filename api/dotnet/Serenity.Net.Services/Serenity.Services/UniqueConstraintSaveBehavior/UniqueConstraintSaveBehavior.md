# UniqueConstraintSaveBehavior constructor

Behavior that handles [`UniqueConstraintAttribute`](../../Serenity.Data.Mapping/UniqueConstraintAttribute.md) on a row. It checks each unique constraint before save (unless [`CheckBeforeSave`](../../Serenity.Data.Mapping/UniqueConstraintAttribute/CheckBeforeSave.md) is disabled) by running an existence query. Override [`BuildUniqueConstraintQuery`](../BaseUniqueConstraintSaveBehavior/BuildUniqueConstraintQuery.md) in a derived behavior, or add your own behavior and set [`DisableDefaultBehavior`](../../Serenity.Data.Mapping/UniqueConstraintAttribute/DisableDefaultBehavior.md), to customize or replace the pre-check.

```csharp
public UniqueConstraintSaveBehavior(ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| localizer | Text localizer |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [UniqueConstraintSaveBehavior](../UniqueConstraintSaveBehavior.md)