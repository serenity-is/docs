# ConnectionKeyFallbackAttribute class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Declares a fallback connection key for a logical connection key. When a connection key is not present in configuration, the fallback connection key is used.

```csharp
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class ConnectionKeyFallbackAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [ConnectionKeyFallbackAttribute](ConnectionKeyFallbackAttribute/ConnectionKeyFallbackAttribute.md)(…) | Initializes a new instance of the [`ConnectionKeyFallbackAttribute`](./ConnectionKeyFallbackAttribute.md) class. |
| [ConnectionKey](ConnectionKeyFallbackAttribute/ConnectionKey.md) { get; } | Gets the logical connection key. |
| [FallbackConnectionKey](ConnectionKeyFallbackAttribute/FallbackConnectionKey.md) { get; } | Gets the fallback connection key used when [`ConnectionKey`](./ConnectionKeyFallbackAttribute/ConnectionKey.md) is not configured. |

## Remarks

This attribute can be applied at the assembly level, e.g. `[assembly: ConnectionKeyFallback("ProMeeting", "Default")]`. When multiple assemblies declare a fallback for the same connection key, the declaration in the assembly that appears later in the type source (typically the application assembly) wins, so applications can override framework defaults. The attribute is not sealed so that feature-specific derived attributes can be created, e.g. `ProSqlFileSystemFallbackAttribute : ConnectionKeyFallbackAttribute`.

## See Also

* **Source:** *[ConnectionKeyFallbackAttribute.cs](https://github.com/serenity-is/Serenity/blob/d7ef4960ed2723e5081d907f7610b7cabba6cf08/src/services/Data/Connections/ConnectionKeyFallbackAttribute.cs)*