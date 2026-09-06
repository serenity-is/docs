# FormScriptRegistration.RegisterFormScripts method

Creates and registers form scripts.

```csharp
public static IEnumerable<FormScript> RegisterFormScripts(IDynamicScriptManager scriptManager, 
    ITypeSource typeSource, IPropertyItemProvider propertyProvider, 
    IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| scriptManager | The dynamic script manager. |
| typeSource | The type source. |
| propertyProvider | The property item provider. |
| serviceProvider | The service provider. |

## Return Value

The list of registered form scripts.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Script manager, type source or service provider is `null`. |

## See Also

* class [FormScript](../../../Serenity.Net.Services/Serenity.Web/FormScript.md)
* interface [IDynamicScriptManager](../IDynamicScriptManager.md)
* interface [ITypeSource](../../../Serenity.Net.Core/Serenity.Abstractions/ITypeSource.md)
* interface [IPropertyItemProvider](../../../Serenity.Net.Services/Serenity.PropertyGrid/IPropertyItemProvider.md)
* class [FormScriptRegistration](../FormScriptRegistration.md)