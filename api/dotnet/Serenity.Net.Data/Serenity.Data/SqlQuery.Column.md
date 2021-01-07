# SqlQuery.Column class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Holds information about a column in SELECT clause.

```csharp
public class Column
```

## Public Members

| name | description |
| --- | --- |
| [Column](SqlQuery.Column/Column.md)(…) | Initializes a new instance of the [`Column`](SqlQuery.Column.md) class. (2 constructors) |
| readonly [ColumnName](SqlQuery.Column/ColumnName.md) | Column name |
| readonly [Expression](SqlQuery.Column/Expression.md) | Field or expression |
| readonly [IntoField](SqlQuery.Column/IntoField.md) | Used by entity system, to determine which field this column value will be read into |
| readonly [IntoRowIndex](SqlQuery.Column/IntoRowIndex.md) | Used by entity system when more than one entity is used as a target |

## See Also

* class [SqlQuery](SqlQuery.md)