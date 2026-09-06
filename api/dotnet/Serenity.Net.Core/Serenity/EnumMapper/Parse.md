# EnumMapper.Parse&lt;TEnum&gt; method

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

* class [EnumMapper](../EnumMapper.md)