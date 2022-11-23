# ICustomFileName interface
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface to customize the output file name, e.g. name of the XLSX or PDF file outputted by reports. By default, reports has output file name of format "{ReportKey}_yyyyMMdd_HHmmss.ext".

```csharp
public interface ICustomFileName
```

## Members

| name | description |
| --- | --- |
| [GetFileName](ICustomFileName/GetFileName.md)() | Returns the custom output file name. |

## See Also

* **Source:** *[ICustomFileName.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Reporting/ICustomFileName.cs)*