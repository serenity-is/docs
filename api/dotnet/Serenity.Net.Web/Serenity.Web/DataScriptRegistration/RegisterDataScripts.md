# DataScriptRegistration.RegisterDataScripts method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Creates and registers dynamic scripts for types with DataScriptAttribute

```csharp
public static void RegisterDataScripts(IDynamicScriptManager scriptManager, ITypeSource typeSource, 
    IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| scriptManager | Dynamic script manager |
| typeSource | Type source |
| serviceProvider | Service provider |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Script manager, type source or , service provider is null |

## See Also

* interface [IDynamicScriptManager](../IDynamicScriptManager.md)
* interface [ITypeSource](../Serenity.Net.Core/../../Serenity.Abstractions/ITypeSource.md)
* class [DataScriptRegistration](../DataScriptRegistration.md)