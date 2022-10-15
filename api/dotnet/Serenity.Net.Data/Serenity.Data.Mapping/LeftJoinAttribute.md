# LeftJoinAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

LEFT JOIN type

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true)]
public class LeftJoinAttribute : Attribute, ISqlJoin
```

## Public Members

| name | description |
| --- | --- |
| [LeftJoinAttribute](LeftJoinAttribute/LeftJoinAttribute.md)(…) | Adds a left join on foreign key. Use this version only on properties with ForeignKey attribute. (4 constructors) |
| [Alias](LeftJoinAttribute/Alias.md) { get; } | Gets the alias. |
| [Dialect](LeftJoinAttribute/Dialect.md) { get; set; } | Gets or sets the dialect. |
| [NegateDialect](LeftJoinAttribute/NegateDialect.md) { get; set; } | Gets or sets the negating of the dialect. |
| [OnCriteria](LeftJoinAttribute/OnCriteria.md) { get; } | Gets the ON criteria. |
| [PropertyPrefix](LeftJoinAttribute/PropertyPrefix.md) { get; set; } | Gets the property prefix. |
| [RowType](LeftJoinAttribute/RowType.md) { get; set; } | Gets or sets the type of the row. |
| [TitlePrefix](LeftJoinAttribute/TitlePrefix.md) { get; set; } | Gets or sets the title prefix. |
| [ToTable](LeftJoinAttribute/ToTable.md) { get; } | Gets the table joined to. |

## See Also

* interface [ISqlJoin](ISqlJoin.md)
* **Source:** *[LeftJoinAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/LeftJoinAttribute.cs)*