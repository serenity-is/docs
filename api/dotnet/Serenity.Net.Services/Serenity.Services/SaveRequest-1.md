# SaveRequest&lt;TEntity&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The service model for a Save (Create / Update) service.

```csharp
public class SaveRequest<TEntity> : ServiceRequest, ISaveRequest
```

| parameter | description |
| --- | --- |
| TEntity |  |

## Public Members

| name | description |
| --- | --- |
| [SaveRequest](SaveRequest-1/SaveRequest.md)() | The default constructor. |
| [Entity](SaveRequest-1/Entity.md) { get; set; } | The entity containing only the fields that should be inserted / updated. Partial patch is only possible with Row types as only it provides assignment information from the originating JSON. |
| [EntityId](SaveRequest-1/EntityId.md) { get; set; } |  |
| [Localizations](SaveRequest-1/Localizations.md) { get; set; } | The set of localizations if translations are requested to be updated. |

## See Also

* class [ServiceRequest](ServiceRequest.md)
* interface [ISaveRequest](ISaveRequest.md)
* **Source:** *[SaveRequest.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Models/SaveRequest.cs)*