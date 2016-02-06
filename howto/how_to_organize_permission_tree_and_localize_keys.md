# How To: Organize Permission Tree and Localize Keys

To create permissions in tree hierarchy, use colon (:) as a separator in your permission keys:

- MyModule:SubModule:General
- MyModule:SubModule:Permission1
- MyModule:SubModule:Permission2

These keys will be shown under MyModule / SubModule category. Thus their category keys will be:

- MyModule:SubModule:

> Category keys ends with colon

Please don't use permission keys that clashes with category keys. If you use such keys, for example *MyModule:SubModule* it won't be shown under *MyModule / SubModule* category but next to it at same level.

If you need a generic permission for such a category, use something like *MyModule:SubModule:General*.

> *General* has no special meaning, you can use Common, Module, View, whatever you like.

## Handling Category Display Texts

As categories are automatically determined from permission keys, they don't have a user friendly display text form them.

You need to add display texts for them using localization system.

> If you don't need localization, just add texts to site.texts.invariant.json

For example in site.texts.invariant.json file, there is such keys:

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