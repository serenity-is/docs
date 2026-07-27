# ValidateParentBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Validation behavior for rows that have a parent record via [`IParentIdRow`](../Serenity.Data/IParentIdRow.md) interface

```csharp
public class ValidateParentBehavior : BaseSaveBehavior
```

| parameter | description |
| --- | --- |
| rowTypeRegistry | Row type registry |
| localizer | Text localizer |

## Public Members

| name | description |
| --- | --- |
| [ValidateParentBehavior](ValidateParentBehavior/ValidateParentBehavior.md)(…) | Validation behavior for rows that have a parent record via [`IParentIdRow`](../Serenity.Data/IParentIdRow.md) interface |
| override [OnValidateRequest](ValidateParentBehavior/OnValidateRequest.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | rowTypeRegistry or localizer is null |

## Remarks

Creates an instance of the class

## See Also

* class [BaseSaveBehavior](BaseSaveBehavior.md)
* **Source:** *[ValidateParentAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/RequestHandlers/IntegratedFeatures/Validation/ValidateParentAttribute.cs)*