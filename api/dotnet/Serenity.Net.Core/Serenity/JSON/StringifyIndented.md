# JSON.StringifyIndented method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Converts object to its JSON representation

```csharp
public static string StringifyIndented(object value, int indentation = 4, bool includeNulls = false)
```

| parameter | description |
| --- | --- |
| value | Value to convert to JSON |
| indentation | Indentation (default 4) |
| includeNulls | If true, serializes null values. |

## Return Value

Serialized JSON string

## See Also

* class [JSON](../JSON.md)