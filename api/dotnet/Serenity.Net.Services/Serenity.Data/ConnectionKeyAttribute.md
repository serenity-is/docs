# ConnectionKeyAttribute class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Determines the connection key used for a class.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class ConnectionKeyAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [ConnectionKeyAttribute](ConnectionKeyAttribute/ConnectionKeyAttribute.md)(…) | Initializes a new instance of the [`ConnectionKeyAttribute`](ConnectionKeyAttribute.md) class. (2 constructors) |
| [SourceType](ConnectionKeyAttribute/SourceType.md) { get; } | Gets the source type with connection key attribute if any. |
| [Value](ConnectionKeyAttribute/Value.md) { get; } | Gets the connection key. |

## See Also

* **Source:** *[ConnectionKeyAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/Mapping/ConnectionKeyAttribute.cs)*