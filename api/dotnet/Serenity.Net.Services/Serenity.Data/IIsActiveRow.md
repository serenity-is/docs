# IIsActiveRow interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for an entity with an active field.

```csharp
public interface IIsActiveRow
```

## Members

| name | description |
| --- | --- |
| [IsActiveField](IIsActiveRow/IsActiveField.md) { get; } | Gets the is active field. 1 means active, 0 means inactive, and if the row also has the [`IIsActiveDeletedRow`](./IIsActiveDeletedRow.md) interface, then -1 means deleted. |

## See Also

* **Source:** *[IIsActiveRow.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Entity/Contracts/IIsActiveRow.cs)*