# ClamAVUploadScanner constructor
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Implementation of IUploadAVScanner which connects to ClamAV service

```csharp
public ClamAVUploadScanner(IOptionsMonitor<ClamAVSettings> options, 
    ITextLocalizer localizer = null, ILogger<ClamAVUploadScanner> logger = null)
```

| parameter | description |
| --- | --- |
| options | Options |
| localizer | Text localizer |
| logger | Logger |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of arguments is null |

## Remarks

Creates a new instance of the class.

## See Also

* class [ClamAVSettings](../ClamAVSettings.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [ClamAVUploadScanner](../ClamAVUploadScanner.md)