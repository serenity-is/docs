# SqlQuery.Column class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Holds information about a column in SELECT clause.

```csharp
public class Column
```

| parameter | description |
| --- | --- |
| expression | The expression. |
| columnName | Name of the column. |
| intoRow | The select into row index. |
| intoField | The select into field. |

## Public Members

| name | description |
| --- | --- |
| [Column](SqlQuery.Column/Column.md)(…) | Holds information about a column in SELECT clause. (2 constructors) |
| readonly [ColumnName](SqlQuery.Column/ColumnName.md) | Column name |
| readonly [Expression](SqlQuery.Column/Expression.md) | Field or expression |
| readonly [IntoField](SqlQuery.Column/IntoField.md) | Used by entity system, to determine which field this column value will be read into |
| readonly [IntoRowIndex](SqlQuery.Column/IntoRowIndex.md) | Used by entity system when more than one entity is used as a target |

## Remarks

Initializes a new instance of the [`Column`](SqlQuery.Column.md) class.

## See Also

* class [SqlQuery](SqlQuery.md)