# ISaveRequestProcessor interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for save request handlers with a Process method.

```csharp
public interface ISaveRequestProcessor : ISaveRequestHandler
```

## Members

| name | description |
| --- | --- |
| [Process](ISaveRequestProcessor/Process.md)(…) | Processes the [`ISaveRequest`](ISaveRequest.md) and returns a [`SaveResponse`](SaveResponse.md). |

## See Also

* interface [ISaveRequestHandler](ISaveRequestHandler.md)
* **Source:** *[ISaveRequestProcessor.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/RequestHandlers/Save/ISaveRequestProcessor.cs)*