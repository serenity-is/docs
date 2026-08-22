# ILocalizationRow interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for rows with a CultureId field

```csharp
public interface ILocalizationRow : IIdRow
```

## Members

| name | description |
| --- | --- |
| [CultureIdField](ILocalizationRow/CultureIdField.md) { get; } | Language ID field (must be a two or four letter culture code, e.g. en-GB) |

## See Also

* interface [IIdRow](IIdRow.md)
* **Source:** *[ILocalizationRow.cs](https://github.com/serenity-is/Serenity/blob/fa206546471018db1a28b90b807e2a73904efdfa/src/services/RequestHandlers/IntegratedFeatures/Localization/ILocalizationRow.cs)*