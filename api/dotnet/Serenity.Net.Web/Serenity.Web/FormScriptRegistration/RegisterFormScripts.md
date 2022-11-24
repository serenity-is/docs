# FormScriptRegistration.RegisterFormScripts method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Creates and form scripts

```csharp
public static void RegisterFormScripts(IDynamicScriptManager scriptManager, ITypeSource typeSource, 
    IPropertyItemProvider propertyProvider, IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| scriptManager | Dynamic script manager |
| typeSource | Type source |
| propertyProvider | Property item provider |
| serviceProvider | Service provider |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Script manager or type source is null |

## See Also

* interface [IDynamicScriptManager](../IDynamicScriptManager.md)
* interface [ITypeSource](../Serenity.Net.Core/../../Serenity.Abstractions/ITypeSource.md)
* interface [IPropertyItemProvider](../Serenity.Net.Entity/../../Serenity.PropertyGrid/IPropertyItemProvider.md)
* class [FormScriptRegistration](../FormScriptRegistration.md)