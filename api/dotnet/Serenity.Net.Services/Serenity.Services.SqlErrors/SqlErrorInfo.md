# SqlErrorInfo class
**namespace:** *[Serenity.Services.SqlErrors](../README.md#serenity.services.sqlerrors-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Information extracted from a database constraint violation.

```csharp
public class SqlErrorInfo
```

## Public Members

| name | description |
| --- | --- |
| [SqlErrorInfo](SqlErrorInfo/SqlErrorInfo.md)() | The default constructor. |
| [ColumnName](SqlErrorInfo/ColumnName.md) { get; } | Gets the first column name involved in the violation, if any. |
| [ColumnNames](SqlErrorInfo/ColumnNames.md) { get; set; } | Gets or sets the names of the columns involved in the violation, if they could be determined. |
| [ConstraintName](SqlErrorInfo/ConstraintName.md) { get; set; } | Gets or sets the name of the constraint or index involved, if it could be determined. |
| [ErrorNumber](SqlErrorInfo/ErrorNumber.md) { get; set; } | Gets or sets the provider error number, if available. |
| [KeyValue](SqlErrorInfo/KeyValue.md) { get; set; } | Gets or sets the key value that caused the violation, if it could be determined. |
| [Message](SqlErrorInfo/Message.md) { get; set; } | Gets or sets the original exception message. |
| [ReferencedTableName](SqlErrorInfo/ReferencedTableName.md) { get; set; } | Gets or sets the name of the referenced (foreign) table for a foreign key violation, if it could be determined. |
| [ServerType](SqlErrorInfo/ServerType.md) { get; set; } | Gets or sets the server type the exception came from, if it could be determined. |
| [SqlState](SqlErrorInfo/SqlState.md) { get; set; } | Gets or sets the SQL state code, if available. |
| [TableName](SqlErrorInfo/TableName.md) { get; set; } | Gets or sets the name of the table involved in the violation, if it could be determined. |
| [Type](SqlErrorInfo/Type.md) { get; set; } | Gets or sets the type of the constraint violation. |
| [ToString](SqlErrorInfo/ToString.md)(…) | Formats this error info as a localized validation message. |

## See Also

* **Source:** *[SqlErrorInfo.cs](https://github.com/serenity-is/Serenity/blob/129785379640a01aa65d383053b7eb95a1f6890d/src/services/RequestHandlers/IntegratedFeatures/SqlErrors/SqlErrorInfo.cs)*