# ObjectJsonConverter class
**namespace:** *[Serenity.JsonConverters](../README.md#serenity.jsonconverters-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Provides deserialization for the Object type, inferring the concrete type from the JSON value, similar to Newtonsoft. See https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/converters-how-to?pivots=dotnet-8-0#deserialize-inferred-types-to-object-properties

```csharp
public class ObjectJsonConverter : JsonConverter<object>
```

## Public Members

| name | description |
| --- | --- |
| [ObjectJsonConverter](ObjectJsonConverter/ObjectJsonConverter.md)() | The default constructor. |
| static readonly [Instance](ObjectJsonConverter/Instance.md) | The default instance of the [`ObjectJsonConverter`](ObjectJsonConverter.md). |
| override [Read](ObjectJsonConverter/Read.md)(…) |  |
| override [Write](ObjectJsonConverter/Write.md)(…) |  |

## See Also

* **Source:** *[ObjectJsonConverter.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Json/ObjectJsonConverter.cs)*