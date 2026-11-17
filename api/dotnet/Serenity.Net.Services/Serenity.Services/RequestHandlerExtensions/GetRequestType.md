# RequestHandlerExtensions.GetRequestType method

Gets the request type for the handler instance. For a sync / async list handler wrapper returned by the handler factory, it is the request type of the wrapped handler, which may be a subclass of [`ListRequest`](../ListRequest.md) the wrapped handler casts the request to.

```csharp
public static Type? GetRequestType(this IRequestHandler handler)
```

| parameter | description |
| --- | --- |
| handler | Handler instance |

## See Also

* interface [IRequestHandler](../../../Serenity.Net.Core/Serenity.Services/IRequestHandler.md)
* class [RequestHandlerExtensions](../RequestHandlerExtensions.md)