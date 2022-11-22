# ServiceResponse class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public class ServiceResponse
```

## Public Members

| name | description |
| --- | --- |
| [ServiceResponse](ServiceResponse/ServiceResponse.md)() | The default constructor. |
| [CustomData](ServiceResponse/CustomData.md) { get; set; } | A custom data dictionary. Please consider subclassing the service response before passing data via this property. This should be only used in limited cases where subclassing is not feasible. Another option could be to add a [JsonExtensionData] but that could open way to the side effect ignoring typos. |
| [Error](ServiceResponse/Error.md) { get; set; } |  |

## See Also

* **Source:** *[ServiceResponse.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Models/ServiceResponse.cs)*