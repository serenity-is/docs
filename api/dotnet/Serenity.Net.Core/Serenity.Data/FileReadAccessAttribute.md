# FileReadAccessAttribute class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Base attribute to specify file read access control on a property.

```csharp
[AttributeUsage(AttributeTargets.Property)]
public class FileReadAccessAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [FileReadAccessAttribute](FileReadAccessAttribute/FileReadAccessAttribute.md)() | The default constructor. |
| [AllowBypass](FileReadAccessAttribute/AllowBypass.md) { get; set; } | Gets or sets a value indicating whether bypass is allowed for this operation. The Bypass permission is usually given to administrators and set in FileReadAccessSettings. Default is true, meaning that users with the bypass permission are allowed to read the file. |
| [Permission](FileReadAccessAttribute/Permission.md) { get; protected internal set; } | Permission to check for file read access. Use "*" for public/unrestricted, "?" for any logged in user, or a specific permission key. If using LogicOperatorPermissionService, permission can also be a logical expression like A&#x7C;B&amp;!C. |
| [PermissionOnly](FileReadAccessAttribute/PermissionOnly.md) { get; set; } | Gets or sets a value indicating whether to skip entity-level access control and use only permission-based access. If this attribute specifies a permission, that permission is used. Otherwise, the default permission is used. |

## See Also

* **Source:** *[FileReadAccessAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/FileAccess/FileReadAccessAttribute.cs)*