# Join class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Corresponds to an SQL JOIN (INNER, OUTER, CROSS etc.)

```csharp
public abstract class Join : Alias
```

## Public Members

| name | description |
| --- | --- |
| [Joins](Join/Joins.md) { get; } | Gets the joins. |
| [OnCriteria](Join/OnCriteria.md) { get; } | Gets the ON criteria. |
| [ReferencedAliases](Join/ReferencedAliases.md) { get; } | Gets the referenced aliases. |
| [RowType](Join/RowType.md) { get; set; } | Gets or sets the type of the row. |
| abstract [GetKeyword](Join/GetKeyword.md)() | Gets the keyword. |

## Protected Members

| name | description |
| --- | --- |
| [Join](Join/Join.md)(…) | Initializes a new instance of the [`Join`](Join.md) class. |

## See Also

* class [Alias](Alias.md)
* **Source:** *[Join.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Join/Join.cs)*