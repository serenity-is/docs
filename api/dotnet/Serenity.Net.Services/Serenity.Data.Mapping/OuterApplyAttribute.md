# OuterApplyAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Adds a OUTER APPLY to the row

```csharp
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class OuterApplyAttribute : Attribute, ISqlJoin
```

| parameter | description |
| --- | --- |
| alias | The alias. |
| innerQuery | The inner query. |

## Public Members

| name | description |
| --- | --- |
| [OuterApplyAttribute](OuterApplyAttribute/OuterApplyAttribute.md)(…) | Adds a OUTER APPLY to the row (2 constructors) |
| [Alias](OuterApplyAttribute/Alias.md) { get; } | Gets the alias. |
| [Dialect](OuterApplyAttribute/Dialect.md) { get; set; } | Gets or sets the dialect. |
| [InnerQuery](OuterApplyAttribute/InnerQuery.md) { get; } | Gets the inner query. |
| [NegateDialect](OuterApplyAttribute/NegateDialect.md) { get; set; } | Gets or sets the negating of the dialect. |
| [PropertyPrefix](OuterApplyAttribute/PropertyPrefix.md) { get; set; } | Gets the property prefix. |
| [RowType](OuterApplyAttribute/RowType.md) { get; set; } | Gets or sets the type of the row. |
| [TitlePrefix](OuterApplyAttribute/TitlePrefix.md) { get; set; } | Gets or sets the title prefix. |

## Remarks

Initializes a new instance of the [`OuterApplyAttribute`](OuterApplyAttribute.md) class.

## See Also

* interface [ISqlJoin](ISqlJoin.md)
* **Source:** *[OuterApplyAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Mapping/OuterApplyAttribute.cs)*