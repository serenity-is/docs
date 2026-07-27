# ConcatenatedScript constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

A dynamic script that is formed from concatenation of other scripts

```csharp
public ConcatenatedScript(IEnumerable<Func<string>> scriptParts, string separator = "\r\n;\r\n", 
    Action<IPermissionService, ITextLocalizer> checkRights = null)
```

| parameter | description |
| --- | --- |
| scriptParts | Script parts |
| separator | Separator |
| checkRights | Callback to check permissions for individual scripts |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Script parts is null |

## Remarks

Creates a new instance of the class

## See Also

* interface [IPermissionService](../Serenity.Net.Core/../../Serenity.Abstractions/IPermissionService.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [ConcatenatedScript](../ConcatenatedScript.md)