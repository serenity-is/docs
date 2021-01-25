# EntityLocalTexts.AddRowTexts method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Adds the row texts.

```csharp
public static void AddRowTexts(this ILocalTextRegistry registry, IEnumerable<IRow> rowInstances, 
    string languageID = "")
```

| parameter | description |
| --- | --- |
| registry | The registry. |
| rowInstances | The row instances. |
| languageID | The language identifier. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | registry or rowInstances |

## See Also

* interface [ILocalTextRegistry](../Serenity.Net.Core/../../Serenity.Abstractions/ILocalTextRegistry.md)
* interface [IRow](../../Serenity.Data/IRow.md)
* class [EntityLocalTexts](../EntityLocalTexts.md)