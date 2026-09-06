# Row&lt;TFields&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base class for Serenity entities

```csharp
public abstract class Row<TFields> : IEditableRow, IRow<TFields>
    where TFields : RowFieldsBase
```

| parameter | description |
| --- | --- |
| TFields | The type of the fields. |

## Public Members

| name | description |
| --- | --- |
| [ClearAssignment](Row-1/ClearAssignment.md)(…) | Clears the assignment flag of the field. |
| [FindField](Row-1/FindField.md)(…) | Finds the field with the specified name. |
| [FindFieldByPropertyName](Row-1/FindFieldByPropertyName.md)(…) | Finds the field with the specified property name. |
| [GetFields](Row-1/GetFields.md)() | Gets the fields instance for this row type. |
| [IsAssigned](Row-1/IsAssigned.md)(…) | Determines whether the specified field is assigned. |
| [OnFieldGet](Row-1/OnFieldGet.md)(…) |  |
| [OnFieldSet](Row-1/OnFieldSet.md)(…) |  |
| static [Fields](Row-1/Fields.md) { get; } | Gets the fields. |

## Protected Members

| name | description |
| --- | --- |
| [Row](Row-1/Row.md)() | Initializes a new instance of the [`Row`](./Row-1.md) class. |
| [Row](Row-1/Row.md)(…) | Initializes a new instance of the [`Row`](./Row-1.md) class. |
| readonly [fields](Row-1/fields.md) | The fields |
| virtual [CloneInto](Row-1/CloneInto.md)(…) |  |
| virtual [CloneRow](Row-1/CloneRow.md)() | Clones the row. |
| virtual [CreateNew](Row-1/CreateNew.md)() | Creates the new. |

## See Also

* interface [IRow](./IRow.md)
* interface [IRow&lt;TFields&gt;](./IRow-1.md)
* interface [IEditableRow](./IEditableRow.md)
* class [RowFieldsBase](./RowFieldsBase.md)
* **Source:** *[Row.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Entity/Row/Row.cs)*