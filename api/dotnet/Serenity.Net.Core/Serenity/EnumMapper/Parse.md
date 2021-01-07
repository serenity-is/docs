# EnumMapper.Parse&lt;TEnum&gt; method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Parses the specified enum key.

```csharp
public static TEnum Parse<TEnum>(string key)
```

| parameter | description |
| --- | --- |
| TEnum | The type of the enum. |
| key | The enum key or numeric value. |

## Return Value

Parsed enum value

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentOutOfRangeException | Enum value is not valid. |

## See Also

* class [TEnum](../Serenity.Net.Core/../EnumMapper.TEnum.md)
* class [EnumMapper](../EnumMapper.md)