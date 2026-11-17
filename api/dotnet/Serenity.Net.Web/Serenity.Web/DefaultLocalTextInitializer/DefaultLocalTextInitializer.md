# DefaultLocalTextInitializer constructor

Default ILocalTextInitializer that registers base texts and JSON texts from the `App_Data/texts` folder, then the texts of the IDynamicLocalTextSource services, which are kept in the data of the application.

```csharp
public DefaultLocalTextInitializer(ITypeSource typeSource, 
    IRowTypeRegistry? rowTypeRegistry = null, IWebHostEnvironment? webHostEnvironment = null, 
    IEnumerable<IDynamicLocalTextSource>? dynamicSources = null)
```

| parameter | description |
| --- | --- |
| typeSource | The type source used to discover text registrations. |
| rowTypeRegistry | The row type registry used to discover row texts. |
| webHostEnvironment | The web host environment used to locate the texts folder. |
| dynamicSources | The sources of the texts that are kept in data, if any. |

## See Also

* interface [ITypeSource](../../../Serenity.Net.Core/Serenity.Abstractions/ITypeSource.md)
* interface [IRowTypeRegistry](../../../Serenity.Net.Services/Serenity.Data/IRowTypeRegistry.md)
* interface [IDynamicLocalTextSource](../../../Serenity.Net.Core/Serenity.Abstractions/IDynamicLocalTextSource.md)
* class [DefaultLocalTextInitializer](../DefaultLocalTextInitializer.md)