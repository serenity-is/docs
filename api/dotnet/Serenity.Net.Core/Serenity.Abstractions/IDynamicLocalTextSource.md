# IDynamicLocalTextSource interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Adds local texts that are kept in the data of the application, e.g. the translations of the titles of its dashboards in the menu, to the registry when the texts are initialized, which is when the application starts and after the texts are reset, e.g. when translations are saved. It is called after the base texts and the texts files are added, so what is there can be told apart, and the source only adds what is missing.

```csharp
public interface IDynamicLocalTextSource
```

## Members

| name | description |
| --- | --- |
| [AddTexts](IDynamicLocalTextSource/AddTexts.md)(…) | Adds the texts to the registry. |

## Remarks

The initializer is a singleton, so the sources must be too. A source that reads a database should not fail when it is not ready yet, as the texts are initialized when the application starts.

## See Also

* **Source:** *[IDynamicLocalTextSource.cs](https://github.com/serenity-is/Serenity/blob/c408b2557b683a0fb5b290cccdc6b5788b69e144/src/core/Localization/IDynamicLocalTextSource.cs)*