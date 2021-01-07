# TwoLevelCachedAttribute class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

This attribute marks a row so that when it is Inserted/Updated/Deleted through repository, its related cache, if any should be cleared. It doesn't turn on/off caching. A sample of related cached item to a row, might be its lookup if any.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class TwoLevelCachedAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [TwoLevelCachedAttribute](TwoLevelCachedAttribute/TwoLevelCachedAttribute.md)() | Initializes a new instance of the [`TwoLevelCachedAttribute`](TwoLevelCachedAttribute.md) class. |
| [TwoLevelCachedAttribute](TwoLevelCachedAttribute/TwoLevelCachedAttribute.md)(…) | Initializes a new instance of the [`TwoLevelCachedAttribute`](TwoLevelCachedAttribute.md) class. (2 constructors) |
| [GenerationKeys](TwoLevelCachedAttribute/GenerationKeys.md) { get; set; } | Gets the generation keys. |
| [LinkedRows](TwoLevelCachedAttribute/LinkedRows.md) { get; set; } | Gets the types of the linked rows. |

## See Also

* **Source:** *[TwoLevelCachedAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/TwoLevelCachedAttribute.cs)*