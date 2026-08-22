# ConnectionStringOptions class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Connection string options.

```csharp
public class ConnectionStringOptions : Dictionary<string, ConnectionStringEntry>, 
    IOptions<ConnectionStringOptions>
```

## Public Members

| name | description |
| --- | --- |
| [ConnectionStringOptions](ConnectionStringOptions/ConnectionStringOptions.md)() | Creates a new instance. |
| [Value](ConnectionStringOptions/Value.md) { get; } | Returns this instance. |
| const [SectionKey](ConnectionStringOptions/SectionKey.md) | The default section key for [`ConnectionStringOptions`](ConnectionStringOptions.md). |

## See Also

* class [ConnectionStringEntry](ConnectionStringEntry.md)
* **Source:** *[ConnectionStringOptions.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/Connections/ConnectionStringOptions.cs)*