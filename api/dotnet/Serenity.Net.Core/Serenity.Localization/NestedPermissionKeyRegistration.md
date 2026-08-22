# NestedPermissionKeyRegistration class
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains helper methods for registration of permission keys in nested static classes. These classes contain string constants containing permission keys. The display name for permission keys can be set by a DisplayNameAttribute. The display name for groups can be set by a DescriptionAttribute on the classes themselves. For the group display name to work, all constants in a class must start with the same group prefix.

```csharp
public static class NestedPermissionKeyRegistration
```

## Public Members

| name | description |
| --- | --- |
| static [AddNestedPermissions](NestedPermissionKeyRegistration/AddNestedPermissions.md)(…) | Gets permission keys and adds texts, if any, from static nested permission key classes marked with [`NestedPermissionKeysAttribute`](../Serenity.ComponentModel/NestedPermissionKeysAttribute.md). |

## See Also

* **Source:** *[NestedPermissionKeyRegistration.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Localization/NestedPermissionKeyRegistration.cs)*