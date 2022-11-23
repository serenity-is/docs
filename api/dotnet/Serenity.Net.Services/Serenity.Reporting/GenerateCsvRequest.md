# GenerateCsvRequest class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Request model for a CSV exporter.

```csharp
public class GenerateCsvRequest : ServiceRequest
```

## Public Members

| name | description |
| --- | --- |
| [GenerateCsvRequest](GenerateCsvRequest/GenerateCsvRequest.md)() | The default constructor. |
| [Captions](GenerateCsvRequest/Captions.md) { get; set; } | List of column captions, e.g. column names in CSV |
| [Data](GenerateCsvRequest/Data.md) { get; set; } | List of data containing column values in caption order. |
| [DownloadName](GenerateCsvRequest/DownloadName.md) { get; set; } | The download name for the exported file. |

## See Also

* class [ServiceRequest](../Serenity.Services/ServiceRequest.md)
* **Source:** *[GenerateCsvRequest.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Reporting/Model/GenerateCsvRequest.cs)*