# ServiceRequest class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public class ServiceRequest
```

## Public Members

| name | description |
| --- | --- |
| [ServiceRequest](ServiceRequest/ServiceRequest.md)() | The default constructor. |
| [CustomData](ServiceRequest/CustomData.md) { get; set; } | A custom data dictionary. Please consider subclassing the service request before passing data via this property. This should be only used in limited cases where subclassing is not feasible. Another option could be to add a [JsonExtensionData] but that could open way to the side effect ignoring typos. |

## See Also

* **Source:** *[ServiceRequest.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Models/ServiceRequest.cs)*