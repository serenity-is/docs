# ISaveRequest interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for a [`SaveRequest`](./SaveRequest-1.md). As the SaveRequest itself is generic, this allows easier access to its members.

```csharp
public interface ISaveRequest
```

## Members

| name | description |
| --- | --- |
| [Entity](ISaveRequest/Entity.md) { get; set; } | Entity to insert / update |
| [EntityId](ISaveRequest/EntityId.md) { get; set; } | The entity ID to update, should only be passed for Update requests. |
| [IgnoreConcurrencyVersion](ISaveRequest/IgnoreConcurrencyVersion.md) { get; set; } | Gets or sets a value indicating whether the concurrency version check should be skipped for this save request. This is a server side only option and is ignored in client JSON, intended for internal services that need to update a row regardless of its version. |
| [Localizations](ISaveRequest/Localizations.md) { get; set; } | Dictionary of translations if required. |

## See Also

* **Source:** *[ISaveRequest.cs](https://github.com/serenity-is/Serenity/blob/d947fc2cb1fa45d4549127cb6158b7af08071c3d/src/services/Models/ISaveRequest.cs)*