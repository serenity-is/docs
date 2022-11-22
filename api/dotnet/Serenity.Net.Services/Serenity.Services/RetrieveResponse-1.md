# RetrieveResponse&lt;T&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The service response model for a Retrieve service

```csharp
public class RetrieveResponse<T> : ServiceResponse, IRetrieveResponse
```

| parameter | description |
| --- | --- |
| T | Type of the entity |

## Public Members

| name | description |
| --- | --- |
| [RetrieveResponse](RetrieveResponse-1/RetrieveResponse.md)() | The default constructor. |
| [Entity](RetrieveResponse-1/Entity.md) { get; set; } | The returned entity |
| [Localizations](RetrieveResponse-1/Localizations.md) { get; set; } | Dictionary containing localizations if requested. |

## See Also

* class [ServiceResponse](ServiceResponse.md)
* interface [IRetrieveResponse](IRetrieveResponse.md)
* **Source:** *[RetrieveResponse.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Models/RetrieveResponse.cs)*