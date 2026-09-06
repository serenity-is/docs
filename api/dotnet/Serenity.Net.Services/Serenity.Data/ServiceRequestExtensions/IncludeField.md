# ServiceRequestExtensions.IncludeField&lt;TRequest&gt; method

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

* class [Field](../Field.md)
* class [ServiceRequest](../../Serenity.Services/ServiceRequest.md)
* interface [IIncludeExcludeColumns](../../Serenity.Services/IIncludeExcludeColumns.md)
* class [ServiceRequestExtensions](../ServiceRequestExtensions.md)