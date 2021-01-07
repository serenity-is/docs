# SummaryType enumeration
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Enumeration of aggregate function types for a column

```csharp
public enum SummaryType
```

## Values

| name | value | description |
| --- | --- | --- |
| Disabled | `-1` | Summary popup is disabled for this column |
| None | `0` | No aggregate by default, but user might change |
| Sum | `1` | Use Sum aggregate by default |
| Avg | `2` | Use Avg aggregate by default |
| Min | `3` | Use Min aggregate by default |
| Max | `4` | Use Max aggregate by default |

## See Also

* **Source:** *[SummaryType.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Columns/SummaryType.cs)*