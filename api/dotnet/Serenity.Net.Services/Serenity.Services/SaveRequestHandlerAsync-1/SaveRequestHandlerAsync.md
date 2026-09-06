# SaveRequestHandlerAsync&lt;TRow&gt; constructor

Base generic class for async save request handlers that use [`SaveRequest`](../SaveRequest-1.md) as the request type, and [`SaveResponse`](../SaveResponse.md) as the response type.

```csharp
public SaveRequestHandlerAsync(IRequestContext context)
```

| parameter | description |
| --- | --- |
| TRow | The entity type |
| context | Request context |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IRequestContext](../IRequestContext.md)
* class [SaveRequestHandlerAsync&lt;TRow&gt;](../SaveRequestHandlerAsync-1.md)