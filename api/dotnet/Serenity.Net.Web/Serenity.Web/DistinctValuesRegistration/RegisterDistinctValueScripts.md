# DistinctValuesRegistration.RegisterDistinctValueScripts method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Creates and registers dynamic scripts for row properties with DistinctValuesEditorAttribute

```csharp
public static void RegisterDistinctValueScripts(IDynamicScriptManager scriptManager, 
    ITypeSource typeSource, IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| scriptManager | Dynamic script manager |
| typeSource | Type source |
| serviceProvider | Service provider |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Script manager, type source or service provider is null |
| Exception | DistinctValuesAttribute is placed on a non-row type |

## See Also

* interface [IDynamicScriptManager](../IDynamicScriptManager.md)
* interface [ITypeSource](../Serenity.Net.Core/../../Serenity.Abstractions/ITypeSource.md)
* class [DistinctValuesRegistration](../DistinctValuesRegistration.md)