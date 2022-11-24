# ServiceRequestExtensions.IncludeField&lt;TRequest&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Adds the field to the request.IncludeColumns

```csharp
public static TRequest IncludeField<TRequest>(this TRequest request, Field field)
    where TRequest : ServiceRequest, IIncludeExcludeColumns
```

| parameter | description |
| --- | --- |
| TRequest | Request type |
| request | Request |
| field | Field |

## See Also

* class [TRequest](../Serenity.Net.Services/../ServiceRequestExtensions.TRequest.md)
* class [Field](../Serenity.Net.Entity/../Field.md)
* class [ServiceRequest](../../Serenity.Services/ServiceRequest.md)
* interface [IIncludeExcludeColumns](../../Serenity.Services/IIncludeExcludeColumns.md)
* class [ServiceRequestExtensions](../ServiceRequestExtensions.md)