# Row&lt;TFields&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Base class for Serenity entities

```csharp
public abstract class Row<TFields> : IEditableObject, INotifyPropertyChanged, IRow<TFields>
    where TFields : RowFieldsBase
```

| parameter | description |
| --- | --- |
| TFields | The type of the fields. |

## Public Members

| name | description |
| --- | --- |
| [FieldCount](Row-1/FieldCount.md) { get; } | Gets the field count. |
| [HasErrors](Row-1/HasErrors.md) { get; } | Gets a value indicating whether this instance has errors. |
| [HasPostHandler](Row-1/HasPostHandler.md) { get; } | Gets a value indicating whether this instance has post handler. |
| [IdField](Row-1/IdField.md) { get; } | Gets the identifier field. |
| [IgnoreConstraints](Row-1/IgnoreConstraints.md) { get; set; } | Gets or sets a value indicating whether [ignore constraints]. |
| [IsAnyFieldAssigned](Row-1/IsAnyFieldAssigned.md) { get; } | Gets a value indicating whether this instance is any field assigned. |
| [IsAnyFieldChanged](Row-1/IsAnyFieldChanged.md) { get; } | Gets a value indicating whether this instance is any field changed. |
| [IsEditing](Row-1/IsEditing.md) { get; } | Gets a value indicating whether this instance is editing. |
| [Item](Row-1/Item.md) { get; set; } | Gets or sets the Object with the specified field name. |
| [NameField](Row-1/NameField.md) { get; } | Gets the name field. |
| [OriginalValues](Row-1/OriginalValues.md) { get; } | Gets the original values. |
| [PostHandler](Row-1/PostHandler.md) { get; set; } | Gets or sets the post handler. |
| [PreviousValues](Row-1/PreviousValues.md) { get; } | Gets the previous values. |
| [Table](Row-1/Table.md) { get; } | Table name |
| [TrackAssignments](Row-1/TrackAssignments.md) { get; set; } | Gets or sets a value indicating whether [track assignments]. |
| [TrackWithChecks](Row-1/TrackWithChecks.md) { get; set; } | Gets or sets a value indicating whether [track with checks]. |
| [ValidationErrors](Row-1/ValidationErrors.md) { get; } | Gets the validation errors. |
| [PostEnded](Row-1/PostEnded.md) | The post ended |
| event [PropertyChanged](Row-1/PropertyChanged.md) | Occurs when a property value changes. |
| [AddValidationError](Row-1/AddValidationError.md)(…) | Adds the validation error. |
| [BeginEdit](Row-1/BeginEdit.md)() | Begins an edit on an object. |
| [CancelEdit](Row-1/CancelEdit.md)() | Discards changes since the last BeginEdit call. |
| [ClearAssignment](Row-1/ClearAssignment.md)(…) | Clears the assignment. |
| [ClearValidationErrors](Row-1/ClearValidationErrors.md)() | Clears the validation errors. |
| [CloneInto](Row-1/CloneInto.md)(…) |  |
| virtual [CloneRow](Row-1/CloneRow.md)() | Clones the row. |
| virtual [CreateNew](Row-1/CreateNew.md)() | Creates the new. |
| [EndEdit](Row-1/EndEdit.md)() | Pushes changes since the last BeginEdit or AddNew call into the underlying object. |
| [FindField](Row-1/FindField.md)(…) | Finds the field. |
| [FindFieldByPropertyName](Row-1/FindFieldByPropertyName.md)(…) | Finds the name of the field by property. |
| [GetDictionaryData](Row-1/GetDictionaryData.md)(…) | Gets the dictionary data. |
| [GetDictionaryDataKeys](Row-1/GetDictionaryDataKeys.md)() | Gets the dictionary data keys. |
| [GetFields](Row-1/GetFields.md)() | Gets the fields. |
| [IsAssigned](Row-1/IsAssigned.md)(…) | Determines whether the specified field is assigned. |
| [IsFieldChanged](Row-1/IsFieldChanged.md)(…) | Determines whether [is field changed] [the specified field]. |
| [RemoveValidationError](Row-1/RemoveValidationError.md)(…) | Removes the validation error. |
| [SetDictionaryData](Row-1/SetDictionaryData.md)(…) | Sets the dictionary data. |
| static [Fields](Row-1/Fields.md) { get; } | Gets the fields. |

## Protected Members

| name | description |
| --- | --- |
| [Row](Row-1/Row.md)() | Initializes a new instance of the [`Row`](Row-1.md) class. |
| [Row](Row-1/Row.md)(…) | Initializes a new instance of the [`Row`](Row-1.md) class. |
| readonly [fields-](Row-1/fields-.md) | The fields |

## See Also

* interface [IRow](IRow.md)
* interface [IRow&lt;TFields&gt;](IRow-1.md)
* class [TFields](../Serenity.Net.Entity/Row-1.TFields.md)
* class [RowFieldsBase](RowFieldsBase.md)
* **Source:** *[Row.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Row/Row.cs)*