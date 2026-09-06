# ClamAVUploadScanner class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Implementation of IUploadAVScanner which connects to ClamAV service

```csharp
public class ClamAVUploadScanner : IUploadAVScanner
```

| parameter | description |
| --- | --- |
| options | Options |
| localizer | Text localizer |
| logger | Logger |

## Public Members

| name | description |
| --- | --- |
| [ClamAVUploadScanner](ClamAVUploadScanner/ClamAVUploadScanner.md)(…) | Implementation of IUploadAVScanner which connects to ClamAV service |
| [Scan](ClamAVUploadScanner/Scan.md)(…) | Processes a temporary upload stream, usually from the HTTP request files and returns false |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of arguments is null |

## Remarks

Creates a new instance of the class.

## See Also

* interface [IUploadAVScanner](../../Serenity.Net.Services/Serenity.Web/IUploadAVScanner.md)
* **Source:** *[ClamAVUploadScanner.cs](https://github.com/serenity-is/Serenity/blob/47a8f36cd87e4c2377c35f4a9f9c1c4ba0155f61/common-features/src/extensions/Modules/ClamAV/ClamAVUploadScanner.cs)*