# ISaveRequestProcessorAsync interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for save request handlers with an async Process method.

```csharp
public interface ISaveRequestProcessorAsync : ISaveRequestHandler
```

## Members

| name | description |
| --- | --- |
| [ProcessAsync](ISaveRequestProcessorAsync/ProcessAsync.md)(…) | Processes the [`ISaveRequest`](./ISaveRequest.md) asynchronously and returns a [`SaveResponse`](./SaveResponse.md). |

## See Also

* interface [ISaveRequestHandler](./ISaveRequestHandler.md)
* **Source:** *[ISaveRequestProcessorAsync.cs](https://github.com/serenity-is/Serenity/blob/04ac3ea58a41048bed911555c87969edcf6ea031/src/services/RequestHandlers/Save/ISaveRequestProcessorAsync.cs)*