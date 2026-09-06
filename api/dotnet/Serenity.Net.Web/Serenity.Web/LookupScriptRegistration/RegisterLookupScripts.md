# LookupScriptRegistration.RegisterLookupScripts method

Creates and registers dynamic [`LookupScript`](../LookupScript.md) objects for classes with LookupScriptAttribute.

```csharp
public static void RegisterLookupScripts(IDynamicScriptManager scriptManager, 
    ITypeSource typeSource, IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| scriptManager | The dynamic script manager. |
| typeSource | The type source. |
| serviceProvider | The service provider. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Script manager, type source or service provider is `null`. |
| InvalidOperationException | A custom type has LookupScriptAttribute but does not derive from the [`LookupScript`](../LookupScript.md) class. |

## See Also

* interface [IDynamicScriptManager](../IDynamicScriptManager.md)
* interface [ITypeSource](../../../Serenity.Net.Core/Serenity.Abstractions/ITypeSource.md)
* class [LookupScriptRegistration](../LookupScriptRegistration.md)