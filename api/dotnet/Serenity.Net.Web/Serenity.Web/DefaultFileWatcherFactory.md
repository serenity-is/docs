# DefaultFileWatcherFactory class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Default implementation of [`IFileWatcherFactory`](./IFileWatcherFactory.md) that keeps created watchers alive for the lifetime of the factory.

```csharp
public class DefaultFileWatcherFactory : IFileWatcherFactory
```

## Public Members

| name | description |
| --- | --- |
| [DefaultFileWatcherFactory](DefaultFileWatcherFactory/DefaultFileWatcherFactory.md)() | Initializes a new instance of the [`DefaultFileWatcherFactory`](./DefaultFileWatcherFactory.md) class. |
| [Watchers](DefaultFileWatcherFactory/Watchers.md) { get; } |  |
| [Create](DefaultFileWatcherFactory/Create.md)(…) |  |
| [KeepAlive](DefaultFileWatcherFactory/KeepAlive.md)(…) |  |

## See Also

* interface [IFileWatcherFactory](./IFileWatcherFactory.md)
* **Source:** *[DefaultFileWatcherFactory.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/Common/DefaultFileWatcherFactory.cs)*