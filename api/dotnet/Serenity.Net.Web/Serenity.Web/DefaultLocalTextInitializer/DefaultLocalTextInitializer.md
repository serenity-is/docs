# DefaultLocalTextInitializer constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Default ILocalTextInitializer that registers base texts and JSON texts from the `App_Data/texts` folder.

```csharp
public DefaultLocalTextInitializer(ITypeSource typeSource, IRowTypeRegistry rowTypeRegistry = null, 
    IWebHostEnvironment webHostEnvironment = null)
```

| parameter | description |
| --- | --- |
| typeSource | The type source used to discover text registrations. |
| rowTypeRegistry | The row type registry used to discover row texts. |
| webHostEnvironment | The web host environment used to locate the texts folder. |

## See Also

* interface [ITypeSource](../Serenity.Net.Core/../../Serenity.Abstractions/ITypeSource.md)
* interface [IRowTypeRegistry](../Serenity.Net.Services/../../Serenity.Data/IRowTypeRegistry.md)
* class [DefaultLocalTextInitializer](../DefaultLocalTextInitializer.md)