# PermissionAttributeBase class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

An abstract base attribute that all permission-related attributes derive from.

```csharp
[AttributeUsage(AttributeTargets.All)]
public abstract class PermissionAttributeBase : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [PermissionAttributeBase](PermissionAttributeBase/PermissionAttributeBase.md)(…) | Initializes a new instance of the [`PermissionAttributeBase`](./PermissionAttributeBase.md) class. (3 constructors) |
| [Permission](PermissionAttributeBase/Permission.md) { get; } | Gets the permission key. Never null or empty; use [`SpecialPermissionKeys`](../Serenity/SpecialPermissionKeys.md) for the special keys. |

## Remarks

Permissions defined by these attributes are checked per row type, not per record. Having a permission grants access to every record of that type that can be targeted by its id, so they should not be used to restrict access to individual records (e.g. records owned by the current user or a specific tenant). For record level authorization, implement a request handler behavior that adds the required filter to the query (e.g. via its `OnPrepareQuery` method), or override the relevant handler method. See the multitenancy tutorial in Serenity docs for a sample.

## See Also

* **Source:** *[PermissionAttributeBase.cs](https://github.com/serenity-is/Serenity/blob/5d57a31a12f284644fefd8952ba4744a7f5c0592/src/core/ComponentModel/Permission/PermissionAttributeBase.cs)*