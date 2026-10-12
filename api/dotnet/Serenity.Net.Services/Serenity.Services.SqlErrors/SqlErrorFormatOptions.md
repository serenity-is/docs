# SqlErrorFormatOptions class
**namespace:** *[Serenity.Services.SqlErrors](../README.md#serenity.services.sqlerrors-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Options that customize how a [`SqlErrorInfo`](./SqlErrorInfo.md) is formatted as text.

```csharp
public class SqlErrorFormatOptions
```

## Public Members

| name | description |
| --- | --- |
| [SqlErrorFormatOptions](SqlErrorFormatOptions/SqlErrorFormatOptions.md)() | The default constructor. |
| [ErrorMessage](SqlErrorFormatOptions/ErrorMessage.md) { get; set; } | Gets or sets a custom local text key or literal error message. When it contains format placeholders, the table name and field name are passed as the arguments. |
| [FieldName](SqlErrorFormatOptions/FieldName.md) { get; set; } | Gets or sets the display name / title of the field involved, if known. |
| [IsDelete](SqlErrorFormatOptions/IsDelete.md) { get; } | Gets a value indicating whether the operation is a delete or undelete. |
| [Operation](SqlErrorFormatOptions/Operation.md) { get; set; } | Gets or sets the operation that caused the error. |
| [RowType](SqlErrorFormatOptions/RowType.md) { get; set; } | Gets or sets the row type involved, if any. |
| [TableName](SqlErrorFormatOptions/TableName.md) { get; set; } | Gets or sets the name of the table of the row involved, if known. |

## See Also

* **Source:** *[SqlErrorFormatOptions.cs](https://github.com/serenity-is/Serenity/blob/129785379640a01aa65d383053b7eb95a1f6890d/src/services/RequestHandlers/IntegratedFeatures/SqlErrors/SqlErrorFormatOptions.cs)*