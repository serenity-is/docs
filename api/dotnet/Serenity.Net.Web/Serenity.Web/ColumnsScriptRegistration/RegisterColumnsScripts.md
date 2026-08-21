# ColumnsScriptRegistration.RegisterColumnsScripts method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Creates and registers column scripts.

```csharp
public static IEnumerable<ColumnsScript> RegisterColumnsScripts(
    IDynamicScriptManager scriptManager, ITypeSource typeSource, 
    IPropertyItemProvider propertyProvider, IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| scriptManager | The dynamic script manager. |
| typeSource | The type source. |
| propertyProvider | The property item provider. |
| serviceProvider | The service provider. |

## Return Value

The list of registered column scripts.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Script manager, type source or service provider is `null`. |

## See Also

* class [ColumnsScript](../Serenity.Net.Services/../ColumnsScript.md)
* interface [IDynamicScriptManager](../IDynamicScriptManager.md)
* interface [ITypeSource](../Serenity.Net.Core/../../Serenity.Abstractions/ITypeSource.md)
* interface [IPropertyItemProvider](../Serenity.Net.Services/../../Serenity.PropertyGrid/IPropertyItemProvider.md)
* class [ColumnsScriptRegistration](../ColumnsScriptRegistration.md)