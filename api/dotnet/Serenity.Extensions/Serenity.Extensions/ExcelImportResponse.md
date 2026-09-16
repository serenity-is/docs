# ExcelImportResponse class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

The response model for an Excel import service.

```csharp
public class ExcelImportResponse : ServiceResponse
```

## Public Members

| name | description |
| --- | --- |
| [ExcelImportResponse](ExcelImportResponse/ExcelImportResponse.md)() | The default constructor. |
| [ErrorList](ExcelImportResponse/ErrorList.md) { get; set; } | The list of errors encountered during import, if any. |
| [Inserted](ExcelImportResponse/Inserted.md) { get; set; } | The number of records inserted. |
| [Updated](ExcelImportResponse/Updated.md) { get; set; } | The number of records updated. |

## See Also

* class [ServiceResponse](../../Serenity.Net.Services/Serenity.Services/ServiceResponse.md)
* **Source:** *[ExcelImportRequest.cs](https://github.com/serenity-is/Serenity/blob/f681c4775d515f42ae248938da92305df66f5c02/common-features/src/extensions/Modules/ExportImport/ExcelImportRequest.cs)*