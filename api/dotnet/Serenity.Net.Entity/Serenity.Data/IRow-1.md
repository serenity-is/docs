# IRow&lt;TFields&gt; interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Base interface for Rows with a known Fields type

```csharp
public interface IRow<TFields> : IRow
```

| parameter | description |
| --- | --- |
| TFields | The type of the fields. |

## Members

| name | description |
| --- | --- |
| [Fields](IRow-1/Fields.md) { get; } | Gets the fields. |
| [CloneRow](IRow-1/CloneRow.md)() | Clones the row. |
| [CreateNew](IRow-1/CreateNew.md)() | Creates a new instance of the row. |

## See Also

* interface [IEntityWithJoins](IEntityWithJoins.md)
* interface [IRow](IRow.md)
* **Source:** *[IRow.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Row/IRow.cs)*