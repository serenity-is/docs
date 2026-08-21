# CaptureLogAttribute class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Enables capture logging for a row type.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class CaptureLogAttribute : Attribute
```

| parameter | description |
| --- | --- |
| logRow | The log row type used for this row type the attribute is placed on. |

## Public Members

| name | description |
| --- | --- |
| [CaptureLogAttribute](CaptureLogAttribute/CaptureLogAttribute.md)(…) | Enables capture logging for a row type. |
| [LogRow](CaptureLogAttribute/LogRow.md) { get; } | Gets the log row type. |
| [MappedIdField](CaptureLogAttribute/MappedIdField.md) { get; set; } | Gets or sets the mapped ID field. It is tried to be automatically determined if not specified. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *logRow* is `null`. |

## Remarks

Initializes a new instance of the attribute.

## See Also

* **Source:** *[CaptureLogAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/RequestHandlers/IntegratedFeatures/CaptureLog/CaptureLogAttribute.cs)*