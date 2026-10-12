# SaveRequest&lt;TEntity&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The service model for a Save (Create / Update) service.

```csharp
public class SaveRequest<TEntity> : ServiceRequest, ISaveRequest
```

| parameter | description |
| --- | --- |
| TEntity | The type of the entity. |

## Public Members

| name | description |
| --- | --- |
| [SaveRequest](SaveRequest-1/SaveRequest.md)() | The default constructor. |
| [Entity](SaveRequest-1/Entity.md) { get; set; } | The entity containing only the fields that should be inserted / updated. Partial patch is only possible with Row types as only it provides assignment information from the originating JSON. |
| [EntityId](SaveRequest-1/EntityId.md) { get; set; } |  |
| [IgnoreConcurrencyVersion](SaveRequest-1/IgnoreConcurrencyVersion.md) { get; set; } | Gets or sets a value indicating whether the concurrency version check should be skipped for this save request. This is a server side only option and is ignored in client JSON, intended for internal services that need to update a row regardless of its version. |
| [Localizations](SaveRequest-1/Localizations.md) { get; set; } | The set of localizations if translations are requested to be updated. |

## See Also

* class [ServiceRequest](./ServiceRequest.md)
* interface [ISaveRequest](./ISaveRequest.md)
* **Source:** *[SaveRequest.cs](https://github.com/serenity-is/Serenity/blob/d947fc2cb1fa45d4549127cb6158b7af08071c3d/src/services/Models/SaveRequest.cs)*