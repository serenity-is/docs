# LocalizationRowAttribute class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Maps a row to its localization row

```csharp
[AttributeUsage(AttributeTargets.All)]
public class LocalizationRowAttribute : Attribute
```

| parameter | description |
| --- | --- |
| localizationRow | Localization row type |

## Public Members

| name | description |
| --- | --- |
| [LocalizationRowAttribute](LocalizationRowAttribute/LocalizationRowAttribute.md)(…) | Maps a row to its localization row |
| [LocalizationRow](LocalizationRowAttribute/LocalizationRow.md) { get; } | Localization row type |
| [LocalizeListByDefault](LocalizationRowAttribute/LocalizeListByDefault.md) { get; set; } | If set to true returns translated values by default for the list handler (available in Pro.Extensions package) when ListRequest.Localize is not set, e.g. it is null. Note that if this is enabled, Request.Localize parameter must be specified as empty string to get original values. |
| [MappedIdField](LocalizationRowAttribute/MappedIdField.md) { get; set; } | ID field corresponding to this tables ID field. Can be automatically determined if not specified. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | localizationRow is null |

## Remarks

Creates a new instance of the attribute

## See Also

* **Source:** *[LocalizationRowAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/RequestHandlers/IntegratedFeatures/Localization/LocalizationRowAttribute.cs)*