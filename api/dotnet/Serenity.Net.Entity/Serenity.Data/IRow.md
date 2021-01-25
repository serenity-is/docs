# IRow interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Row interface

```csharp
public interface IRow : IEntityWithJoins
```

## Members

| name | description |
| --- | --- |
| [Fields](IRow/Fields.md) { get; } | Gets the fields. |
| [IdField](IRow/IdField.md) { get; } | Gets the identifier field. |
| [IsAnyFieldAssigned](IRow/IsAnyFieldAssigned.md) { get; } | Gets a value indicating whether this row instance has any field assigned. |
| [IsAnyFieldChanged](IRow/IsAnyFieldChanged.md) { get; } | Gets a value indicating whether this instance is any field changed. |
| [Item](IRow/Item.md) { get; set; } | Gets or sets a field value with specified name |
| [NameField](IRow/NameField.md) { get; } | Gets the name field. |
| [TrackAssignments](IRow/TrackAssignments.md) { get; set; } | Gets or sets a value indicating whether to track assignments to field values. |
| [TrackWithChecks](IRow/TrackWithChecks.md) { get; set; } | Gets or sets a value indicating whether track assignments to field values, and raise an exception if an unassigned field is tried to read. |
| [ClearAssignment](IRow/ClearAssignment.md)(…) | Clears the assignment. |
| [CloneRow](IRow/CloneRow.md)() | Clones the row. |
| [CreateNew](IRow/CreateNew.md)() | Creates a new instance of the row type. |
| [FieldAssignedValue](IRow/FieldAssignedValue.md)(…) | Called when field is assigned a value. |
| [GetDictionaryData](IRow/GetDictionaryData.md)(…) | Gets the dictionary data. |
| [GetDictionaryDataKeys](IRow/GetDictionaryDataKeys.md)() | Gets the dictionary data keys. |
| [GetIndexedData](IRow/GetIndexedData.md)(…) | Gets the indexed data. |
| [IsAssigned](IRow/IsAssigned.md)(…) | Determines whether the specified field is assigned. |
| [SetDictionaryData](IRow/SetDictionaryData.md)(…) | Sets the dictionary data. |
| [SetIndexedData](IRow/SetIndexedData.md)(…) | Sets the indexed data. |

## See Also

* interface [IEntityWithJoins](IEntityWithJoins.md)
* **Source:** *[IRow.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Row/IRow.cs)*