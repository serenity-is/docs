# LookupScriptRegistration.RegisterLookupScripts method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Creates and registers dynamic [`LookupScript`](../LookupScript.md) objects for classes with LookupScriptAttribute

```csharp
public static void RegisterLookupScripts(IDynamicScriptManager scriptManager, 
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
| InvalidOperationException | A custom type has LookupScriptAttribute but it does not derive from the [`LookupScript`](../LookupScript.md) class. |

## See Also

* interface [IDynamicScriptManager](../IDynamicScriptManager.md)
* interface [ITypeSource](../Serenity.Net.Core/../../Serenity.Abstractions/ITypeSource.md)
* class [LookupScriptRegistration](../LookupScriptRegistration.md)