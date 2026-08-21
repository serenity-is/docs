# SafeInt64JsonConverter class
**namespace:** *[Serenity.JsonConverters](../README.md#serenity.jsonconverters-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Serializes and deserializes a Int64 value, converting it to a string when it is larger than the precision a double can safely handle.

```csharp
public class SafeInt64JsonConverter : JsonConverter<long>
```

## Public Members

| name | description |
| --- | --- |
| [SafeInt64JsonConverter](SafeInt64JsonConverter/SafeInt64JsonConverter.md)() | The default constructor. |
| static readonly [Instance](SafeInt64JsonConverter/Instance.md) | The default instance of the [`SafeInt64JsonConverter`](SafeInt64JsonConverter.md). |
| override [Read](SafeInt64JsonConverter/Read.md)(…) |  |
| override [Write](SafeInt64JsonConverter/Write.md)(…) |  |

## See Also

* **Source:** *[SafeInt64JsonConverter.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Json/SafeInt64JsonConverter.cs)*