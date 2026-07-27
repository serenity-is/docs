# ListRequestHandler&lt;TRow,TListRequest&gt; constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Base generic class for list request handlers that use a custom list request as the request type, and [`ListResponse`](../ListResponse-1.md) as the response type.

```csharp
public ListRequestHandler(IRequestContext context)
```

| parameter | description |
| --- | --- |
| TRow | The entity type |
| TListRequest | List request type |
| context | Request context |

## Remarks

Creates a new instance of the class

## See Also

* interface [IRequestContext](../IRequestContext.md)
* class [ListRequestHandler&lt;TRow,TListRequest&gt;](../ListRequestHandler-2.md)