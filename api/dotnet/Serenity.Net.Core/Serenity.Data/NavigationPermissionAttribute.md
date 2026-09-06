# NavigationPermissionAttribute class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets navigation permission for the row, which, if it exists, takes precedence over ReadPermissionAttribute to determine the permission for the row's page and navigation item.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class NavigationPermissionAttribute : PermissionAttributeBase
```

## Public Members

| name | description |
| --- | --- |
| [NavigationPermissionAttribute](NavigationPermissionAttribute/NavigationPermissionAttribute.md)(…) | Initializes a new instance of the [`NavigationPermissionAttribute`](./NavigationPermissionAttribute.md) class. (3 constructors) |

## See Also

* class [PermissionAttributeBase](./PermissionAttributeBase.md)
* **Source:** *[NavigationPermissionAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/Permission/NavigationPermissionAttribute.cs)*