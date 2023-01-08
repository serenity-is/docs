# IEditableRow interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Methods and properties of a row to support desktop app grid etc. editing

```csharp
public interface IEditableRow : IEditableObject, INotifyPropertyChanged, IRow
```

## Members

| name | description |
| --- | --- |
| [HasErrors](IEditableRow/HasErrors.md) { get; } | Gets a value indicating whether this instance has errors. |
| [HasPostHandler](IEditableRow/HasPostHandler.md) { get; } | Gets a value indicating whether this instance has post handler. |
| [IsAnyFieldChanged](IEditableRow/IsAnyFieldChanged.md) { get; } | Gets a value indicating whether this instance is any field changed. |
| [IsEditing](IEditableRow/IsEditing.md) { get; } | Gets a value indicating whether this instance is editing. |
| [OriginalValues](IEditableRow/OriginalValues.md) { get; } | Gets the original values. |
| [PostHandler](IEditableRow/PostHandler.md) { get; set; } | Gets or sets the post handler. |
| [PreviousValues](IEditableRow/PreviousValues.md) { get; } | Gets the previous values. |
| [ValidationErrors](IEditableRow/ValidationErrors.md) { get; } | Gets the validation errors. |
| event [PostEnded](IEditableRow/PostEnded.md) | The post ended event |
| [AddValidationError](IEditableRow/AddValidationError.md)(…) | Adds the validation error. |
| [ClearValidationErrors](IEditableRow/ClearValidationErrors.md)() | Clears the validation errors. |
| [IsFieldChanged](IEditableRow/IsFieldChanged.md)(…) | Determines whether [is field changed] [the specified field]. |
| [RemoveValidationError](IEditableRow/RemoveValidationError.md)(…) | Removes the validation error. |

## See Also

* interface [IRow](IRow.md)
* **Source:** *[IEditableRow.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Row/IEditableRow.cs)*