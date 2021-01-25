# IIsActiveRow interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Interface for an entity with active field

```csharp
public interface IIsActiveRow
```

## Members

| name | description |
| --- | --- |
| [IsActiveField](IIsActiveRow/IsActiveField.md) { get; } | Gets the is active field. 1 means active, 0 means inactive, if the row also has IIsActiveDeletedRow interface, then -1 means deleted. |

## See Also

* **Source:** *[IIsActiveRow.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Contracts/IIsActiveRow.cs)*