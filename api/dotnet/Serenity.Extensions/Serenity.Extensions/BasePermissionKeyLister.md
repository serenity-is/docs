# BasePermissionKeyLister class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Base class for permission key listers that enumerate permission keys from a type source, including nested, assembly, and type-level permissions.

```csharp
public abstract class BasePermissionKeyLister : IPermissionKeyLister
```

## Public Members

| name | description |
| --- | --- |
| virtual [ListPermissionKeys](BasePermissionKeyLister/ListPermissionKeys.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [BasePermissionKeyLister](BasePermissionKeyLister/BasePermissionKeyLister.md)(…) | Base class for permission key listers that enumerate permission keys from a type source, including nested, assembly, and type-level permissions. |
| readonly [cache-](BasePermissionKeyLister/cache-.md) | The two level cache used to cache permission keys. |
| readonly [typeSource-](BasePermissionKeyLister/typeSource-.md) | The type source used to enumerate permission keys. |
| virtual [GetAssemblyPermissions](BasePermissionKeyLister/GetAssemblyPermissions.md)(…) | Gets permissions from assemblies in a type source. |
| virtual [GetAttributePermissions&lt;TAttr&gt;](BasePermissionKeyLister/GetAttributePermissions.md)(…) | Gets permissions from a member attribute. (2 methods) |
| virtual [GetCachedPermissionKeys](BasePermissionKeyLister/GetCachedPermissionKeys.md)(…) | Gets permission keys from cache or source. |
| virtual [GetCacheDuration](BasePermissionKeyLister/GetCacheDuration.md)() | Gets cache duration for permission keys. Default is zero, e.g. never expires unless the cache is cleared by using the group key. |
| abstract [GetCacheGroupKey](BasePermissionKeyLister/GetCacheGroupKey.md)() | Gets cache group key used to invalidate items. |
| virtual [GetCacheKey](BasePermissionKeyLister/GetCacheKey.md)(…) | Gets cache key for permission keys. |
| virtual [GetExternalPermissions](BasePermissionKeyLister/GetExternalPermissions.md)() | Gets a list of permissions that are external and should be listed. Common use case is to list permissions from database tables. |
| virtual [GetMarkerPermissions](BasePermissionKeyLister/GetMarkerPermissions.md)() | Gets a list of permissions that are used as markers and should not be listed. Default implementation returns ["*", "?", "DENY"] |
| virtual [GetNestedPermissions](BasePermissionKeyLister/GetNestedPermissions.md)(…) | Gets nested permissions from a type source. |
| virtual [GetPermissionKeys](BasePermissionKeyLister/GetPermissionKeys.md)(…) | Gets all permission keys. |
| virtual [GetPermissionsFromMethod](BasePermissionKeyLister/GetPermissionsFromMethod.md)(…) | Gets permissions from a method. Default implementation returns permissions from PermissionAttributeBase, PageAuthorizeAttribute and ServiceAuthorizeAttribute. |
| virtual [GetPermissionsFromMethods](BasePermissionKeyLister/GetPermissionsFromMethods.md)(…) | Gets permissions from methods of a type. |
| virtual [GetPermissionsFromProperties](BasePermissionKeyLister/GetPermissionsFromProperties.md)(…) | Gets permissions from properties of a type. |
| virtual [GetPermissionsFromProperty](BasePermissionKeyLister/GetPermissionsFromProperty.md)(…) | Gets permissions from a property attributes. Default implementation returns permissions from PermissionAttributeBase. |
| virtual [GetPermissionsFromType](BasePermissionKeyLister/GetPermissionsFromType.md)(…) | Gets permissions from a type. |
| virtual [GetPermissionsFromTypeAttributes](BasePermissionKeyLister/GetPermissionsFromTypeAttributes.md)(…) | Gets permissions from type attributes. |
| virtual [GetPrivatePermissions](BasePermissionKeyLister/GetPrivatePermissions.md)() | Gets a list of permissions that are private and should not be listed. Default implementation returns ["ImpersonateAs"] |
| virtual [GetRoleKeys](BasePermissionKeyLister/GetRoleKeys.md)() | Gets a list of role keys. |
| virtual [IsRolePermission](BasePermissionKeyLister/IsRolePermission.md)(…) | Checks if a permission key is a role permission key, e.g. starts with Role: |
| virtual [SplitPermissions](BasePermissionKeyLister/SplitPermissions.md)(…) | Splits permission string into multiple permissions. |
| static readonly [SplitChars](BasePermissionKeyLister/SplitChars.md) | Set of characters used to split permissions. |

## See Also

* interface [IPermissionKeyLister](../Serenity.Net.Core/../Serenity.Abstractions/IPermissionKeyLister.md)
* **Source:** *[BasePermissionKeyLister.cs](https://github.com/serenity-is/Serenity/blob/47a8f36cd87e4c2377c35f4a9f9c1c4ba0155f61/common-features/src/extensions/Modules/Authorization/BasePermissionKeyLister.cs)*