# CaptureLogAttribute class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Enables capture logging for a row type

```csharp
[AttributeUsage(AttributeTargets.All)]
public class CaptureLogAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [CaptureLogAttribute](CaptureLogAttribute/CaptureLogAttribute.md)(…) | Creates an instance of the attribute |
| [LogRow](CaptureLogAttribute/LogRow.md) { get; } | Log row type |
| [MappedIdField](CaptureLogAttribute/MappedIdField.md) { get; set; } | Gets / sets mapped ID field. It is tried to be automatically determined if not specified. |

## See Also

* **Source:** *[CaptureLogAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/IntegratedFeatures/CaptureLog/CaptureLogAttribute.cs)*