# JSON.ToJson method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Converts an object to its JSON representation (extension method for Stringify)

```csharp
public static string ToJson(this object value, bool includeNulls = false)
```

| parameter | description |
| --- | --- |
| value | Object |
| includeNulls | If true, serializes null values. |

## Return Value

JSON representation string.

## Remarks

null, Int32, Boolean, DateTime, Decimal, Double, Guid types handled automatically. If object has a ToJson method it is used, otherwise value.ToString() is used as last fallback.

## See Also

* class [JSON](../JSON.md)