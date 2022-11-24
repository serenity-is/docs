# CaptureOperationType enumeration
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Contains capture logging operation types

```csharp
public enum CaptureOperationType
```

## Values

| name | value | description |
| --- | --- | --- |
| Before | `0` | The before record, only available for updates |
| Delete | `1` | Delete |
| Insert | `2` | Insert |
| Update | `3` | Update (update records have both Before and Update records) |

## See Also

* **Source:** *[CaptureOperationType.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/IntegratedFeatures/CaptureLog/CaptureOperationType.cs)*