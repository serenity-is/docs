# FieldReadPermissionAttribute class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets the default read permission for fields of a row that don't have a ReadPermission themselves.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class FieldReadPermissionAttribute : PermissionAttributeBase
```

## Public Members

| name | description |
| --- | --- |
| [FieldReadPermissionAttribute](FieldReadPermissionAttribute/FieldReadPermissionAttribute.md)(…) | Initializes a new instance of the [`FieldReadPermissionAttribute`](./FieldReadPermissionAttribute.md) class. (3 constructors) |
| [ApplyToLookups](FieldReadPermissionAttribute/ApplyToLookups.md) { get; set; } | Determines whether this permission is also applied to row fields with [LookupInclude] attribute, ID and Name fields. Defaults to true. |

## See Also

* class [PermissionAttributeBase](./PermissionAttributeBase.md)
* **Source:** *[FieldReadPermissionAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/Permission/FieldReadPermissionAttribute.cs)*