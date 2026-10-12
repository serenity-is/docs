# ValidateParentBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Validation behavior for rows that have a parent record via [`IParentIdRow`](../Serenity.Data/IParentIdRow.md) interface.

```csharp
public class ValidateParentBehavior : BaseSaveBehaviorAsync, ISaveBehaviorSync
```

| parameter | description |
| --- | --- |
| rowTypeRegistry | Row type registry |
| localizer | Text localizer |

## Public Members

| name | description |
| --- | --- |
| [ValidateParentBehavior](ValidateParentBehavior/ValidateParentBehavior.md)(…) | Validation behavior for rows that have a parent record via [`IParentIdRow`](../Serenity.Data/IParentIdRow.md) interface. |
| virtual [OnValidateRequest](ValidateParentBehavior/OnValidateRequest.md)(…) |  |
| override [OnValidateRequestAsync](ValidateParentBehavior/OnValidateRequestAsync.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *rowTypeRegistry* or *localizer* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* class [BaseSaveBehaviorAsync](./BaseSaveBehaviorAsync.md)
* interface [ISaveBehaviorSync](./ISaveBehaviorSync.md)
* **Source:** *[ValidateParentBehavior.cs](https://github.com/serenity-is/Serenity/blob/ff6184910771617302f78aac48321402ee254e78/src/services/RequestHandlers/IntegratedFeatures/Validation/ValidateParentBehavior.cs)*