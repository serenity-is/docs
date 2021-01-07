# Row&lt;TFields&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

```csharp
public abstract class Row<TFields> : IEditableObject, INotifyPropertyChanged, IRow<TFields>
    where TFields : RowFieldsBase
```

## Public Members

| name | description |
| --- | --- |
| [FieldCount](Row-1/FieldCount.md) { get; } |  |
| [HasErrors](Row-1/HasErrors.md) { get; } |  |
| [HasPostHandler](Row-1/HasPostHandler.md) { get; } |  |
| [IdField](Row-1/IdField.md) { get; } |  |
| [IgnoreConstraints](Row-1/IgnoreConstraints.md) { get; set; } |  |
| [IsAnyFieldAssigned](Row-1/IsAnyFieldAssigned.md) { get; } |  |
| [IsAnyFieldChanged](Row-1/IsAnyFieldChanged.md) { get; } |  |
| [IsEditing](Row-1/IsEditing.md) { get; } |  |
| [Item](Row-1/Item.md) { get; set; } |  |
| [NameField](Row-1/NameField.md) { get; } |  |
| [OriginalValues](Row-1/OriginalValues.md) { get; } |  |
| [PostHandler](Row-1/PostHandler.md) { get; set; } |  |
| [PreviousValues](Row-1/PreviousValues.md) { get; } |  |
| [Table](Row-1/Table.md) { get; } |  |
| [TrackAssignments](Row-1/TrackAssignments.md) { get; set; } |  |
| [TrackWithChecks](Row-1/TrackWithChecks.md) { get; set; } |  |
| [ValidationErrors](Row-1/ValidationErrors.md) { get; } |  |
| [PostEnded](Row-1/PostEnded.md) |  |
| event [PropertyChanged](Row-1/PropertyChanged.md) |  |
| [AddValidationError](Row-1/AddValidationError.md)(…) |  |
| [BeginEdit](Row-1/BeginEdit.md)() |  |
| [CancelEdit](Row-1/CancelEdit.md)() |  |
| [ClearAssignment](Row-1/ClearAssignment.md)(…) |  |
| [ClearValidationErrors](Row-1/ClearValidationErrors.md)() |  |
| [CloneInto](Row-1/CloneInto.md)(…) |  |
| virtual [CloneRow](Row-1/CloneRow.md)() |  |
| virtual [CreateNew](Row-1/CreateNew.md)() |  |
| [EndEdit](Row-1/EndEdit.md)() |  |
| [FindField](Row-1/FindField.md)(…) |  |
| [FindFieldByPropertyName](Row-1/FindFieldByPropertyName.md)(…) |  |
| [GetDictionaryData](Row-1/GetDictionaryData.md)(…) |  |
| [GetDictionaryDataKeys](Row-1/GetDictionaryDataKeys.md)() |  |
| [GetFields](Row-1/GetFields.md)() |  |
| [IsAssigned](Row-1/IsAssigned.md)(…) |  |
| [IsFieldChanged](Row-1/IsFieldChanged.md)(…) |  |
| [RemoveValidationError](Row-1/RemoveValidationError.md)(…) |  |
| [SetDictionaryData](Row-1/SetDictionaryData.md)(…) |  |
| static [Fields](Row-1/Fields.md) { get; } |  |

## Protected Members

| name | description |
| --- | --- |
| [Row](Row-1/Row.md)() | The default constructor. |
| [Row](Row-1/Row.md)(…) |  |
| readonly [fields-](Row-1/fields-.md) |  |

## See Also

* interface [IRow&lt;TFields&gt;](IRow-1.md)
* class [TFields](../Serenity.Net.Entity/Row-1.TFields.md)
* class [RowFieldsBase](RowFieldsBase.md)
* **Source:** *[Row.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Row/Row.cs)*