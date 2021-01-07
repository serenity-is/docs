# NestedPermissionKeyRegistration class
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains helper methods for registration of permission keys in nested static classes. These classes contains string contants containing permission keys. Display name for permission keys can be set by [DisplayName] attribute. Display name for groups can be set by [Description] attribute on classes themselves. For group display name to work, all constants in a class must start with same group prefix.

```csharp
public static class NestedPermissionKeyRegistration
```

## Public Members

| name | description |
| --- | --- |
| static [AddNestedPermissions](NestedPermissionKeyRegistration/AddNestedPermissions.md)(…) | Gets permission keys and adds texts if any from static nested permission key classes marked with NestedPermissionKeys attribute. |

## See Also

* **Source:** *[NestedPermissionKeyRegistration.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Localization/NestedPermissionKeyRegistration.cs)*