# JsonServiceClient.Post&lt;TResponse&gt; method

Posts a request to a JSON service and returns the typed response.

```csharp
public virtual TResponse Post<TResponse>(string relativeUrl, object request)
    where TResponse : new()
```

| parameter | description |
| --- | --- |
| TResponse | The type of response expected |
| relativeUrl | Relative url |
| request | Request object |

## Return Value

The response returned from the service.

## See Also

* class [JsonServiceClient](../JsonServiceClient.md)