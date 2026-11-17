# ListExecutionMode enumeration
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Specifies why a list request handler is being executed. Handlers and list behaviors can check it through [`ExecutionMode`](./IListRequestHandler/ExecutionMode.md) and act differently, or refuse, when they are not executed to return rows to a list request.

```csharp
public enum ListExecutionMode
```

## Values

| name | value | description |
| --- | --- | --- |
| Normal | `0` | The handler processes a list request and returns its rows. |
| QueryCapture | `1` | The handler is executed only to build its query, e.g. to use it as a source in another query like an entity query of a data source. Any filter the handler or its behaviors would apply after the query is executed (e.g. in ProcessEntity or OnReturn) will not take effect, so such logic should apply its filter to the query instead, or throw an exception. |

## See Also

* **Source:** *[ListExecutionMode.cs](https://github.com/serenity-is/Serenity/blob/4e590d6757037c1f1c7364d5531af4759c4e7606/src/services/RequestHandlers/List/ListExecutionMode.cs)*