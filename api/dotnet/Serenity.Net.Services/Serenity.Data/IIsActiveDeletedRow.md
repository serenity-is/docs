# IIsActiveDeletedRow interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Marks an [`IIsActiveRow`](./IIsActiveRow.md) where -1 is used as the deleted value.

```csharp
public interface IIsActiveDeletedRow : IIsActiveRow
```

## Remarks

Because the deleted value (`-1`) is stored in the same column as the active (`1`) and inactive (`0`) values, the state a row had before deletion is lost. Undelete always restores `1`, so a row that was inactive before being deleted becomes active afterwards. Preserving it would require storing the prior state separately at delete time.

## See Also

* interface [IIsActiveRow](./IIsActiveRow.md)
* **Source:** *[IIsActiveDeletedRow.cs](https://github.com/serenity-is/Serenity/blob/199b7985edf2a6725f2b409095cec74fcb9cb0a8/src/services/Entity/Contracts/IIsActiveDeletedRow.cs)*