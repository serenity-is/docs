# InnerJoinAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

INNER JOIN type

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true)]
public class InnerJoinAttribute : Attribute, ISqlJoin
```

## Public Members

| name | description |
| --- | --- |
| [InnerJoinAttribute](InnerJoinAttribute/InnerJoinAttribute.md)(…) | Adds a inner join on foreign key. Use this version only on properties with ForeignKey attribute. (2 constructors) |
| [Alias](InnerJoinAttribute/Alias.md) { get; } | Gets the alias. |
| [OnCriteria](InnerJoinAttribute/OnCriteria.md) { get; } | Gets the ON criteria. |
| [PropertyPrefix](InnerJoinAttribute/PropertyPrefix.md) { get; set; } | Gets the property prefix. |
| [RowType](InnerJoinAttribute/RowType.md) { get; set; } | Gets or sets the type of the row. |
| [TitlePrefix](InnerJoinAttribute/TitlePrefix.md) { get; set; } | Gets or sets the title prefix. |
| [ToTable](InnerJoinAttribute/ToTable.md) { get; } | Gets the table. |

## See Also

* interface [ISqlJoin](ISqlJoin.md)
* **Source:** *[InnerJoinAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/InnerJoinAttribute.cs)*