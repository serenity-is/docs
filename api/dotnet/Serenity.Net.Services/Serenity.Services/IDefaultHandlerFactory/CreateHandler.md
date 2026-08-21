# IDefaultHandlerFactory.CreateHandler method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates a new instance of a default request handler for the specified row type and the handler interface.

```csharp
public object CreateHandler(Type rowType, Type handlerInterface)
```

| parameter | description |
| --- | --- |
| rowType | The row type. |
| handlerInterface | The handler interface type. |

## Return Value

The created handler instance.

## See Also

* interface [IDefaultHandlerFactory](../IDefaultHandlerFactory.md)