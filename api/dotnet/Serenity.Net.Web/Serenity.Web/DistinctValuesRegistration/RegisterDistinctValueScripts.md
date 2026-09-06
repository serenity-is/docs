# DistinctValuesRegistration.RegisterDistinctValueScripts method

Creates and registers dynamic scripts for row properties with DistinctValuesEditorAttribute.

```csharp
public static void RegisterDistinctValueScripts(IDynamicScriptManager scriptManager, 
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
| Exception | The DistinctValuesEditorAttribute is placed on a non-row type. |

## See Also

* interface [IDynamicScriptManager](../IDynamicScriptManager.md)
* interface [ITypeSource](../../../Serenity.Net.Core/Serenity.Abstractions/ITypeSource.md)
* class [DistinctValuesRegistration](../DistinctValuesRegistration.md)