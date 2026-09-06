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

* class [BaseSaveBehaviorAsync](BaseSaveBehaviorAsync.md)
* interface [ISaveBehaviorSync](ISaveBehaviorSync.md)
* **Source:** *[ValidateParentAttribute.cs](https://github.com/serenity-is/Serenity/blob/147065ea49a71f84f10ea1a8b68fc4a9bb4179f0/src/services/RequestHandlers/IntegratedFeatures/Validation/ValidateParentAttribute.cs)*