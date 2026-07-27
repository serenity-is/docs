# RowJsonConverter class
**namespace:** *[Serenity.JsonConverters](../README.md#serenity.jsonconverters-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Serialize/deserialize a row

```csharp
public class RowJsonConverter : JsonConverter<IRow>
```

## Public Members

| name | description |
| --- | --- |
| [RowJsonConverter](RowJsonConverter/RowJsonConverter.md)() | The default constructor. |
| override [CanConvert](RowJsonConverter/CanConvert.md)(…) |  |
| override [Read](RowJsonConverter/Read.md)(…) |  |
| override [Write](RowJsonConverter/Write.md)(…) |  |
| static [ShouldDeserializeExtension](RowJsonConverter/ShouldDeserializeExtension.md) | Should deserialize extension |
| static [ShouldSerializeExtension](RowJsonConverter/ShouldSerializeExtension.md) | Should serialize extension |

## See Also

* interface [IRow](../Serenity.Data/IRow.md)
* **Source:** *[RowJsonConverter.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/Row/RowJsonConverter.cs)*