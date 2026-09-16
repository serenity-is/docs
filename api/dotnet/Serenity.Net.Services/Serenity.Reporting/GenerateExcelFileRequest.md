# GenerateExcelFileRequest class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Request model for an Excel exporter.

```csharp
public class GenerateExcelFileRequest : ServiceRequest
```

## Public Members

| name | description |
| --- | --- |
| [GenerateExcelFileRequest](GenerateExcelFileRequest/GenerateExcelFileRequest.md)() | The default constructor. |
| [Captions](GenerateExcelFileRequest/Captions.md) { get; set; } | List of column captions. |
| [Data](GenerateExcelFileRequest/Data.md) { get; set; } | List of items, containing an array of field values in each item. |
| [DownloadName](GenerateExcelFileRequest/DownloadName.md) { get; set; } | The download name for the exported file. |

## See Also

* class [ServiceRequest](../Serenity.Services/ServiceRequest.md)
* **Source:** *[GenerateExcelFileRequest.cs](https://github.com/serenity-is/Serenity/blob/7d4534fc93adbd2968e8fbf317070a0cb6f67b1e/src/services/Reporting/Model/GenerateExcelFileRequest.cs)*