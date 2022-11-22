# JsonServiceClient.InternalPost&lt;TResponse&gt; method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Posts to a JSON service, internal version

```csharp
protected TResponse InternalPost<TResponse>(string relativeUrl, object request)
    where TResponse : new()
```

| parameter | description |
| --- | --- |
| TResponse | Response type |
| relativeUrl | Relative url |
| request | The request object |

## Return Value

The response

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | Throws a validation error exception if the returned response contains a service error. |

## See Also

* class [TResponse](../Serenity.Net.Services/../JsonServiceClient.TResponse.md)
* class [JsonServiceClient](../JsonServiceClient.md)