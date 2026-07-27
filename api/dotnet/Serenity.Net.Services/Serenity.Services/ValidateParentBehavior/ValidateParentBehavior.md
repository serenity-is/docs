# ValidateParentBehavior constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Validation behavior for rows that have a parent record via [`IParentIdRow`](../../Serenity.Data/IParentIdRow.md) interface

```csharp
public ValidateParentBehavior(IRowTypeRegistry rowTypeRegistry, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| rowTypeRegistry | Row type registry |
| localizer | Text localizer |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | rowTypeRegistry or localizer is null |

## Remarks

Creates an instance of the class

## See Also

* interface [IRowTypeRegistry](../../Serenity.Data/IRowTypeRegistry.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [ValidateParentBehavior](../ValidateParentBehavior.md)