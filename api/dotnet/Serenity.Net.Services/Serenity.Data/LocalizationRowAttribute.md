# LocalizationRowAttribute class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Maps a row to its localization row

```csharp
[AttributeUsage(AttributeTargets.All)]
public class LocalizationRowAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [LocalizationRowAttribute](LocalizationRowAttribute/LocalizationRowAttribute.md)(…) | Creates a new instance of the attribute |
| [LocalizationRow](LocalizationRowAttribute/LocalizationRow.md) { get; } | Localization row type |
| [MappedIdField](LocalizationRowAttribute/MappedIdField.md) { get; set; } | ID field corresponding to this tables ID field. Can be automatically determined if not specified. |

## See Also

* **Source:** *[LocalizationRowAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/IntegratedFeatures/Localization/LocalizationRowAttribute.cs)*