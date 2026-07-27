# PermissionAttributeBase class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

An abstract base attribute that all permission related attributes derive from.

```csharp
[AttributeUsage(AttributeTargets.All)]
public abstract class PermissionAttributeBase : Attribute
```

| parameter | description |
| --- | --- |
| permission | The permission. |

## Public Members

| name | description |
| --- | --- |
| [PermissionAttributeBase](PermissionAttributeBase/PermissionAttributeBase.md)(…) | Initializes a new instance of the [`PermissionAttributeBase`](PermissionAttributeBase.md) class. A colon is inserted between module and permission to generate permission key. (2 constructors) |
| [Permission](PermissionAttributeBase/Permission.md) { get; } | Gets the permission. |

## Protected Members

| name | description |
| --- | --- |
| [PermissionAttributeBase](PermissionAttributeBase/PermissionAttributeBase.md)(…) | An abstract base attribute that all permission related attributes derive from. |

## Remarks

Initializes a new instance of the [`PermissionAttributeBase`](PermissionAttributeBase.md) class.

## See Also

* **Source:** *[PermissionAttributeBase.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/Permission/PermissionAttributeBase.cs)*