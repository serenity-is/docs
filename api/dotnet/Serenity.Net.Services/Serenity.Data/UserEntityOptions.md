# UserEntityOptions class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Configures the user row type and identifier storage settings, including the user table and ID column names.

```csharp
public class UserEntityOptions : IOptions<UserEntityOptions>
```

## Public Members

| name | description |
| --- | --- |
| [UserEntityOptions](UserEntityOptions/UserEntityOptions.md)() | The default constructor. |
| [IdColumnName](UserEntityOptions/IdColumnName.md) { get; set; } | Gets or sets the name of the user ID column. Assigning [`RowType`](./UserEntityOptions/RowType.md) initializes this from the [IdProperty] property's [`ColumnAttribute`](../Serenity.Data.Mapping/ColumnAttribute.md), or its property name when no column attribute exists. If no name is available, it defaults to "UserId". |
| [IdColumnSize](UserEntityOptions/IdColumnSize.md) { get; set; } | Gets or sets the size of the ID column in the user row. Only meaningful for string columns. |
| [IdFieldType](UserEntityOptions/IdFieldType.md) { get; set; } | Gets or sets the type of the ID column in the user row. This is used to determine the data type of the unique identifier for users. |
| [RowType](UserEntityOptions/RowType.md) { get; set; } | Gets or sets the user row type. It must implement [`IRow`](./IRow.md) and have an [IdProperty] property. That property's type determines the user ID field type, while its [Column] and [Size] attributes provide the default ID column name and size. Its [TableName] attribute provides the default user table name. Set [`TableName`](./UserEntityOptions/TableName.md) or [`IdColumnName`](./UserEntityOptions/IdColumnName.md) to override those names. Other user column names are not configured by this option. |
| [TableName](UserEntityOptions/TableName.md) { get; set; } | Gets or sets the user table name. When not explicitly set, the name comes from the user row's [`TableNameAttribute`](../Serenity.Data.Mapping/TableNameAttribute.md); if no row type or attribute is available, it defaults to "Users". |
| [Value](UserEntityOptions/Value.md) { get; } |  |
| [AssignFrom](UserEntityOptions/AssignFrom.md)(…) | Assigns the values from another [`UserEntityOptions`](./UserEntityOptions.md) instance to this instance. This method is used to copy the configuration settings from one instance to another. |

## Remarks

Configure the identifier type before running the initial database migrations. Changing it after the database is created requires a custom migration and corresponding application changes.

## See Also

* **Source:** *[UserEntityOptions.cs](https://github.com/serenity-is/Serenity/blob/946b4765d8a337deec82c919259aeeb4b626bd6f/src/services/Data/Mapping/UserEntityOptions.cs)*