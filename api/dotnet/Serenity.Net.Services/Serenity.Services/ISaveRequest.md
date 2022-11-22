# ISaveRequest interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for a [`SaveRequest`](SaveRequest-1.md). As the SaveRequest itself is generic, this allows easier access to its members.

```csharp
public interface ISaveRequest
```

## Members

| name | description |
| --- | --- |
| [Entity](ISaveRequest/Entity.md) { get; set; } | Entity to insert / update |
| [EntityId](ISaveRequest/EntityId.md) { get; set; } | The entity ID to update, should only be passed for Update requests. |
| [Localizations](ISaveRequest/Localizations.md) { get; set; } | Dictionary of translations if required. |

## See Also

* **Source:** *[ISaveRequest.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Models/ISaveRequest.cs)*