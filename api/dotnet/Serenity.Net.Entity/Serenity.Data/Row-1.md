# Row&lt;TFields&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

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
| [FindField](Row-1/FindField.md)(…) | Finds the field. |
| [FindFieldByPropertyName](Row-1/FindFieldByPropertyName.md)(…) | Finds the name of the field by property. |
| [GetFields](Row-1/GetFields.md)() | Gets the fields. |
| [IsAssigned](Row-1/IsAssigned.md)(…) | Determines whether the specified field is assigned. |
| static [Fields](Row-1/Fields.md) { get; } | Gets the fields. |

## Protected Members

| name | description |
| --- | --- |
| [Row](Row-1/Row.md)() | Initializes a new instance of the [`Row`](Row-1.md) class. |
| [Row](Row-1/Row.md)(…) | Initializes a new instance of the [`Row`](Row-1.md) class. |
| readonly [fields-](Row-1/fields-.md) | The fields |
| virtual [CloneInto](Row-1/CloneInto.md)(…) |  |
| virtual [CloneRow](Row-1/CloneRow.md)() | Clones the row. |
| virtual [CreateNew](Row-1/CreateNew.md)() | Creates the new. |

## See Also

* interface [IRow](IRow.md)
* interface [IRow&lt;TFields&gt;](IRow-1.md)
* interface [IEditableRow](IEditableRow.md)
* class [TFields](../Serenity.Net.Entity/Row-1.TFields.md)
* class [RowFieldsBase](RowFieldsBase.md)
* **Source:** *[Row.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Row/Row.cs)*