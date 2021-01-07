# NestedPermissionKeyRegistration.AddNestedPermissions method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets permission keys and adds texts if any from static nested permission key classes marked with NestedPermissionKeys attribute.

```csharp
public static HashSet<string> AddNestedPermissions(this ILocalTextRegistry registry, 
    ITypeSource typeSource)
```

## See Also

* interface [ILocalTextRegistry](../../Serenity.Abstractions/ILocalTextRegistry.md)
* interface [ITypeSource](../../Serenity.Abstractions/ITypeSource.md)
* class [NestedPermissionKeyRegistration](../NestedPermissionKeyRegistration.md)