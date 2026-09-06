# NestedPermissionKeyRegistration.AddNestedPermissions method

Gets permission keys and adds texts, if any, from static nested permission key classes marked with [`NestedPermissionKeysAttribute`](../../Serenity.ComponentModel/NestedPermissionKeysAttribute.md).

```csharp
public static HashSet<string> AddNestedPermissions(this ILocalTextRegistry? registry, 
    ITypeSource typeSource)
```

| parameter | description |
| --- | --- |
| registry | The registry to add texts to, or `null`. |
| typeSource | The type source to search for nested permission key classes in. |

## Return Value

A set of the permission keys found.

## See Also

* interface [ILocalTextRegistry](../../Serenity.Abstractions/ILocalTextRegistry.md)
* interface [ITypeSource](../../Serenity.Abstractions/ITypeSource.md)
* class [NestedPermissionKeyRegistration](../NestedPermissionKeyRegistration.md)