# BasePermissionService.GetImplicitPermissions method
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Gets implicit permissions defined in the application.

```csharp
public static IDictionary<string, HashSet<string>> GetImplicitPermissions(IMemoryCache memoryCache, 
    ITypeSource typeSource)
```

| parameter | description |
| --- | --- |
| memoryCache | Memory cache |
| typeSource | Type source |

## See Also

* interface [ITypeSource](../Serenity.Net.Core/../../Serenity.Abstractions/ITypeSource.md)
* class [BasePermissionService](../BasePermissionService.md)