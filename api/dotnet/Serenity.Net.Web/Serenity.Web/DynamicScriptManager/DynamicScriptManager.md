# DynamicScriptManager constructor

Initializes a new instance of the [`DynamicScriptManager`](../DynamicScriptManager.md) class.

```csharp
public DynamicScriptManager(ITwoLevelCache cache, IPermissionService permissions, 
    ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| cache | The two level cache. |
| permissions | The permission service. |
| localizer | The text localizer. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *cache* or *permissions* is `null`. |

## See Also

* interface [ITwoLevelCache](../../../Serenity.Net.Core/Serenity.Abstractions/ITwoLevelCache.md)
* interface [IPermissionService](../../../Serenity.Net.Core/Serenity.Abstractions/IPermissionService.md)
* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [DynamicScriptManager](../DynamicScriptManager.md)