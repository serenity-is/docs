# How To: Register Permissions in Serene

Serene shows a list of permissions in user and role permission dialogs. To show your own permissions there, you need to use these permissions with one of the attributes below:

- Attributes that derive from PermissionAttributeBase:
    - *ReadPermission*
    - *ModifyPermission*
    - *InsertPermission* 
    - *UpdatePermission*
    - *DeletePermission*


- Page and Endpoint Access Control Attributes:
    - *PageAuthorize*
    - *ServiceAuthorize*

These attributes can be used with and located from one of these types:

- On top of *XYZRow* (Read, Write, Insert, Update, Delete permissions)
- On top of *XYZPage* and in action methods (PageAuthorize)
- On top of *XYZEndpoint* and in service actions (ServiceAuthorize)

When you use a permission key with one of such attributes, Serene will automatically discover them using reflection at application start.

If you don't use a permission key with any of them but still want to show it in permission dialogs, you can use *RegisterPermission* attribute on assembly (write this anywhere in YourProject.Web):

```cs
[assembly: Serenity.ComponentModel.RegisterPermissionKey("MySpecialPermissionKey")]
```

## PermissionKeys Class

There are PermissionKeys classes for every module in Serene in files like AdministrationPermissionKeys.cs, NorthwindPermissionKeys.cs etc:

```cs
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

The [NestedPermissionKeys] attribute ensures that permission keys defined here are also registered and shown in permission dialog.

> [ImplicitPermission] in this sample currently only works in Start# and controls what permissions a user will automatically have a user has that permission. 

> For example, if a user has "Northwind:Customer:Delete" permission checked, he is also considered to have "Northwind:Customer:View" and "Northwind:General" permissions, even when he is not explictly granted those permissions.

## Organizing Permission Tree

To create permissions in tree hierarchy, use colon (:) as a separator in your permission keys:

- MyModule:SubModule:General
- MyModule:SubModule:Permission1
- MyModule:SubModule:Permission2

These keys will be shown under MyModule / SubModule category. Thus their category keys will be:

- MyModule:SubModule:

> Category keys ends with colon. Don't use permission keys that ends with colon.

Please don't use permission keys that matches category keys. If you use such keys, for example *MyModule:SubModule* it won't be shown under *MyModule / SubModule* category but next to it at same level.

If you need a generic permission for such a category, use something like *MyModule:SubModule:General*.

> *General* has no special meaning, you can use Common, Module, View, whatever you like.

## Handling Category Display Texts

As categories are automatically determined from permission keys, they don't have a user friendly display text for them.

You need to add display texts for them using localization system.

> If you don't need localization, just add texts to site.texts.invariant.json

For example in site.texts.invariant.json file, there are such keys:

```json
    "Permission.Administration:": "Administration",
    "Permission.Administration:Security": "User, Role Management and Permissions",
    "Permission.Administration:Translation": "Languages and Translations",
    "Permission.Northwind:Customer:": "Customers",
    "Permission.Northwind:Customer:View": "View",
    "Permission.Northwind:Customer:Delete": "Delete",
    "Permission.Northwind:Customer:Modify": "Create/Update",
    "Permission.Northwind:General": "[General]"
```

The keys ending with colon (:), like *Administration:* and *Customer:* corresponds to categories and these are their display texts.

You need to add texts for categories to invariant language at minimum. You may also add to other languages, if you want localization.