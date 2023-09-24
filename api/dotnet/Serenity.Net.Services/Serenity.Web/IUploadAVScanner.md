# IUploadAVScanner interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for an upload antivirus scanner, which scans temporary uploads before getting processed

```csharp
public interface IUploadAVScanner
```

## Members

| name | description |
| --- | --- |
| [Scan](IUploadAVScanner/Scan.md)(…) | Processes a temporary upload stream, usually from the HTTP request files and raises an exception if any issues found or an error occured during scan |

## See Also

* **Source:** *[IUploadAVScanner.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Upload/IUploadAVScanner.cs)*