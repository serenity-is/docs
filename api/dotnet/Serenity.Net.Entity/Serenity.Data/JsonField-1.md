# JsonField&lt;TValue&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

```csharp
public class JsonField<TValue> : GenericClassField<TValue>
    where TValue : class
```

## Public Members

| name | description |
| --- | --- |
| [JsonField](JsonField-1/JsonField.md)(…) |  |
| static [Factory](JsonField-1/Factory.md)(…) |  |
| [Settings](JsonField-1/Settings.md) { get; set; } |  |
| override [AsSqlValue](JsonField-1/AsSqlValue.md)(…) |  |
| override [GetFromReader](JsonField-1/GetFromReader.md)(…) |  |
| override [IndexCompare](JsonField-1/IndexCompare.md)(…) |  |
| override [ValueFromJson](JsonField-1/ValueFromJson.md)(…) |  |
| override [ValueToJson](JsonField-1/ValueToJson.md)(…) |  |

## See Also

* class [GenericClassField&lt;TValue&gt;](GenericClassField-1.md)
* class [TValue](../Serenity.Net.Entity/JsonField-1.TValue.md)
* **Source:** *[JsonField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/JsonField.cs)*