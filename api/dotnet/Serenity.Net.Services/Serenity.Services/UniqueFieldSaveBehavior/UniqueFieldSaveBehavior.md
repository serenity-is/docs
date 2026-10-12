# UniqueFieldSaveBehavior constructor

Behavior that handles [`UniqueAttribute`](../../Serenity.Data.Mapping/UniqueAttribute.md) on a single field. It checks the unique constraint before save (unless [`CheckBeforeSave`](../../Serenity.Data.Mapping/UniqueAttribute/CheckBeforeSave.md) is disabled) by running an existence query. Override [`BuildUniqueConstraintQuery`](../BaseUniqueConstraintSaveBehavior/BuildUniqueConstraintQuery.md) in a derived behavior, or add your own behavior and set [`DisableDefaultBehavior`](../../Serenity.Data.Mapping/UniqueAttribute/DisableDefaultBehavior.md) on the field, to customize or replace the pre-check.

```csharp
public UniqueFieldSaveBehavior(ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| localizer | Text localizer |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [UniqueFieldSaveBehavior](../UniqueFieldSaveBehavior.md)