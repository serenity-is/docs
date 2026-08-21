# DefaultLocalTextInitializer class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Default ILocalTextInitializer that registers base texts and JSON texts from the `App_Data/texts` folder.

```csharp
public class DefaultLocalTextInitializer : ILocalTextInitializer
```

| parameter | description |
| --- | --- |
| typeSource | The type source used to discover text registrations. |
| rowTypeRegistry | The row type registry used to discover row texts. |
| webHostEnvironment | The web host environment used to locate the texts folder. |

## Public Members

| name | description |
| --- | --- |
| [DefaultLocalTextInitializer](DefaultLocalTextInitializer/DefaultLocalTextInitializer.md)(…) | Default ILocalTextInitializer that registers base texts and JSON texts from the `App_Data/texts` folder. |
| virtual [Initialize](DefaultLocalTextInitializer/Initialize.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| virtual [AddJsonTexts](DefaultLocalTextInitializer/AddJsonTexts.md)(…) | Adds JSON texts to the local text registry. |

## See Also

* interface [ILocalTextInitializer](../Serenity.Net.Core/../Serenity.Abstractions/ILocalTextInitializer.md)
* **Source:** *[DefaultLocalTextInitializer.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Common/DefaultLocalTextInitializer.cs)*