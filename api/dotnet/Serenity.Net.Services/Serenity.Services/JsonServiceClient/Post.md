# JsonServiceClient.Post&lt;TResponse&gt; method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Post to JSON service

```csharp
public virtual TResponse Post<TResponse>(string relativeUrl, object request)
    where TResponse : new()
```

| parameter | description |
| --- | --- |
| TResponse | The type of response expected |
| relativeUrl | Relative url |
| request | Request object |

## See Also

* class [TResponse](../Serenity.Net.Services/../JsonServiceClient.TResponse.md)
* class [JsonServiceClient](../JsonServiceClient.md)