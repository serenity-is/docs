# IRow interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Row interface

```csharp
public interface IRow : IEntityWithJoins
```

## Members

| name | description |
| --- | --- |
| [Fields](IRow/Fields.md) { get; } | Gets the fields. |
| [IdField](IRow/IdField.md) { get; } | Gets the identifier field. |
| [IgnoreConstraints](IRow/IgnoreConstraints.md) { get; set; } | Gets or sets a value indicating whether [ignore constraints]. |
| [IsAnyFieldAssigned](IRow/IsAnyFieldAssigned.md) { get; } | Gets a value indicating whether this row instance has any field assigned. |
| [Item](IRow/Item.md) { get; set; } | Gets or sets a field value with specified name |
| [NameField](IRow/NameField.md) { get; } | Gets the name field. |
| [TrackAssignments](IRow/TrackAssignments.md) { get; set; } | Gets or sets a flag indicating whether to track assignments to field values. |
| [TrackWithChecks](IRow/TrackWithChecks.md) { get; set; } | Gets or sets a flag indicating whether to track assignments to field values in addition to throwing an exception on read if an unassigned field with null value is accessed. Setting this to true implicitly sets TrackAssignments to true, and setting it to false does not change TrackAssignments value. This flag is useful when loading a partial row from a database query and you want to ensure that only assigned fields are read. Connection extensions like List, ById, etc. automatically set this flag to true for rows they load. |
| [ClearAssignment](IRow/ClearAssignment.md)(…) | Clears the assignment. |
| [CloneRow](IRow/CloneRow.md)() | Clones the row. |
| [CreateNew](IRow/CreateNew.md)() | Creates a new instance of the row type. |
| [GetDictionaryData](IRow/GetDictionaryData.md)(…) | Gets the dictionary data. |
| [GetDictionaryDataKeys](IRow/GetDictionaryDataKeys.md)() | Gets the dictionary data keys. |
| [GetIndexedData](IRow/GetIndexedData.md)(…) | Gets the indexed data. |
| [IsAssigned](IRow/IsAssigned.md)(…) | Determines whether the specified field is assigned. |
| [OnFieldGet](IRow/OnFieldGet.md)(…) | Called to check if a field is read without being assigned a value when tracking with checks. |
| [OnFieldSet](IRow/OnFieldSet.md)(…) | Called when a field is assigned a value. |
| [SetDictionaryData](IRow/SetDictionaryData.md)(…) | Sets the dictionary data. |
| [SetIndexedData](IRow/SetIndexedData.md)(…) | Sets the indexed data. |

## See Also

* interface [IEntityWithJoins](IEntityWithJoins.md)
* **Source:** *[IRow.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/Row/IRow.cs)*