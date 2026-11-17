# DefaultLocalTextInitializer class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Default ILocalTextInitializer that registers base texts and JSON texts from the `App_Data/texts` folder, then the texts of the IDynamicLocalTextSource services, which are kept in the data of the application.

```csharp
public class DefaultLocalTextInitializer : ILocalTextInitializer
```

| parameter | description |
| --- | --- |
| typeSource | The type source used to discover text registrations. |
| rowTypeRegistry | The row type registry used to discover row texts. |
| webHostEnvironment | The web host environment used to locate the texts folder. |
| dynamicSources | The sources of the texts that are kept in data, if any. |

## Public Members

| name | description |
| --- | --- |
| [DefaultLocalTextInitializer](DefaultLocalTextInitializer/DefaultLocalTextInitializer.md)(…) | Default ILocalTextInitializer that registers base texts and JSON texts from the `App_Data/texts` folder, then the texts of the IDynamicLocalTextSource services, which are kept in the data of the application. |
| virtual [Initialize](DefaultLocalTextInitializer/Initialize.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| virtual [AddDynamicTexts](DefaultLocalTextInitializer/AddDynamicTexts.md)(…) | Adds the texts of the IDynamicLocalTextSource services, after the ones of the texts files, so that they only add what is missing. |
| virtual [AddJsonTexts](DefaultLocalTextInitializer/AddJsonTexts.md)(…) | Adds JSON texts to the local text registry. |

## See Also

* interface [ILocalTextInitializer](../../Serenity.Net.Core/Serenity.Abstractions/ILocalTextInitializer.md)
* **Source:** *[DefaultLocalTextInitializer.cs](https://github.com/serenity-is/Serenity/blob/c408b2557b683a0fb5b290cccdc6b5788b69e144/src/web/Common/DefaultLocalTextInitializer.cs)*