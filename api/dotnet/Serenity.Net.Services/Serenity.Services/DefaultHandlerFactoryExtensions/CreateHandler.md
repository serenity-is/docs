# DefaultHandlerFactoryExtensions.CreateHandler&lt;THandler&gt; method

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

## Return Value

The created handler instance.

## See Also

* interface [IDefaultHandlerFactory](../IDefaultHandlerFactory.md)
* class [DefaultHandlerFactoryExtensions](../DefaultHandlerFactoryExtensions.md)