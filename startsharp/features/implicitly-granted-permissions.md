# Implicitly (Automatically) Granted Permissions

If a user / role has a write permission to some entity, it is natural to think that the read permission, should also be automatically granted. 

Otherwise, How could a user modify an entity if he can't see the record itself in the first place?

StartSharp provides you the ability to auto assign a permission to a user/role, if user has another permission. 

It is pretty simple to define such relations between permissions using attributes:

```ts
[NestedPermissionKeys]
[DisplayName("Northwind")]
public class PermissionKeys
{
    [DisplayName("Customers")]
    public class Customer
    {
        [ImplicitPermission(General), ImplicitPermission(View)]
        public const string Delete = "Northwind:Customer:Delete";
        [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
        public const string Modify = "Northwind:Customer:Modify";
        public const string View = "Northwind:Customer:View";
    }

    [Description("[General]")]
    public const string General = "Northwind:General";
}
```

Here we define that, if a user/role has "Northwind:Customer:Delete" or "Northwind:Customer:Modify" permission, 
they should automatically have "Northwind:General" and "Northwind:Customer:View" permissions.

These relations saves you from having to memorize and check all required permissions manually to grant access to a specific resource in permissions dialog.

It also greatly simplifies access control by letting you use shared permission keys.