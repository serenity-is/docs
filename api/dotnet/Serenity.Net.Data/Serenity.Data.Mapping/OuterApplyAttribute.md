# OuterApplyAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Adds a OUTER APPLY to the row

```csharp
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class OuterApplyAttribute : Attribute, ISqlJoin
```

## Public Members

| name | description |
| --- | --- |
| [OuterApplyAttribute](OuterApplyAttribute/OuterApplyAttribute.md)(…) | Initializes a new instance of the [`OuterApplyAttribute`](OuterApplyAttribute.md) class. (2 constructors) |
| [Alias](OuterApplyAttribute/Alias.md) { get; } | Gets the alias. |
| [Dialect](OuterApplyAttribute/Dialect.md) { get; set; } | Gets or sets the dialect. |
| [InnerQuery](OuterApplyAttribute/InnerQuery.md) { get; } | Gets the inner query. |
| [NegateDialect](OuterApplyAttribute/NegateDialect.md) { get; set; } | Gets or sets the negating of the dialect. |
| [PropertyPrefix](OuterApplyAttribute/PropertyPrefix.md) { get; set; } | Gets the property prefix. |
| [RowType](OuterApplyAttribute/RowType.md) { get; set; } | Gets or sets the type of the row. |
| [TitlePrefix](OuterApplyAttribute/TitlePrefix.md) { get; set; } | Gets or sets the title prefix. |

## See Also

* interface [ISqlJoin](ISqlJoin.md)
* **Source:** *[OuterApplyAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/OuterApplyAttribute.cs)*