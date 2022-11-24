# DefaultHandlerFactoryExtensions.CreateHandler&lt;THandler&gt; method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates an instance of the default handler for the requested handler interface type.

```csharp
public static THandler CreateHandler<THandler>(this IDefaultHandlerFactory handlerFactory, 
    Type rowType)
```

| parameter | description |
| --- | --- |
| THandler | Handler interface type |
| handlerFactory | Default handler factory |
| rowType | Row type |

## See Also

* class [THandler](../Serenity.Net.Services/../DefaultHandlerFactoryExtensions.THandler.md)
* interface [IDefaultHandlerFactory](../IDefaultHandlerFactory.md)
* class [DefaultHandlerFactoryExtensions](../DefaultHandlerFactoryExtensions.md)