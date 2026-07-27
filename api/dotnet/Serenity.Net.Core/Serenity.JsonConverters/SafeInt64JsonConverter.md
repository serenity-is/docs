# SafeInt64JsonConverter class
**namespace:** *[Serenity.JsonConverters](../README.md#serenity.jsonconverters-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Serialize/deserialize a long value converting it to string if it is higher than precision double can handle

```csharp
public class SafeInt64JsonConverter : JsonConverter<long>
```

## Public Members

| name | description |
| --- | --- |
| [SafeInt64JsonConverter](SafeInt64JsonConverter/SafeInt64JsonConverter.md)() | The default constructor. |
| static readonly [Instance](SafeInt64JsonConverter/Instance.md) | The default instance |
| override [Read](SafeInt64JsonConverter/Read.md)(…) |  |
| override [Write](SafeInt64JsonConverter/Write.md)(…) |  |

## See Also

* **Source:** *[SafeInt64JsonConverter.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Json/SafeInt64JsonConverter.cs)*