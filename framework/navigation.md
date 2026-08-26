# Navigation

The navigation menu in a Serenity application is defined **declaratively** with assembly-level attributes. You don't build the menu in code — you declare the items, and Serenity builds the tree, filters it by permissions, and renders it.

## Navigation Attributes

Navigation is declared with assembly-level attributes placed in a `Navigation.cs` file (or similar) in your project. All of them derive from [NavigationItemAttribute](../api/dotnet/Serenity.Net.Core/Serenity.Navigation/NavigationItemAttribute.md).

### `[NavigationLink]`

[NavigationLinkAttribute](../api/dotnet/Serenity.Net.Web/Serenity.Navigation/NavigationLinkAttribute.md) declares a navigation item with a link. It's the most common one:

```cs
[assembly: NavigationLink(9800, "Administration/User Management",
    typeof(Administration.UserPage), icon: "fa-users")]
```

The path `"Administration/User Management"` creates a hierarchy: `Administration` is the parent menu, `User Management` is the item. The `typeof(...)` overload resolves the URL and permission from the controller/page automatically.

You can also specify the URL and permission explicitly:

```cs
[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]
```

### `[NavigationMenu]`

[NavigationMenuAttribute](../api/dotnet/Serenity.Net.Core/Serenity.Navigation/NavigationMenuAttribute.md) declares a menu without a link — a parent for other items:

```cs
[assembly: NavigationMenu(9000, "Administration", icon: "fa-tools")]
```

### `[NavigationSection]`

[NavigationSectionAttribute](../api/dotnet/Serenity.Net.Core/Serenity.Navigation/NavigationSectionAttribute.md) declares a section — a group within a menu that visually separates items:

```cs
[assembly: NavigationSection("Administration/Security", icon: "fa-lock")]
```

### `[NavigationGroup]`

[NavigationGroupAttribute](../api/dotnet/Serenity.Net.Core/Serenity.Navigation/NavigationGroupAttribute.md) declares a top-level group (usually the icons on the sidebar band):

```cs
[assembly: NavigationGroup("StartSharp", "fa-home", Default = true)]
```

- `Include` — moves items under other paths into this group.
- `Default` — this group automatically includes siblings that don't match any other group.

## How the Path Works

The path in a navigation attribute defines the hierarchy, using `/` as the separator:

- `"Administration"` — a top-level menu.
- `"Administration/User Management"` — an item under the `Administration` menu.
- `"Administration/Security/Roles"` — an item nested two levels deep.

The title is the part after the last slash, and the category is everything before it. The full path also generates the local text key for the item (`Navigation.Administration/User Management`), so titles can be localized.

## Ordering

The `order` argument controls the position among siblings. Items with the same order are resolved to unique values by the navigation helper, so you don't have to worry about exact gaps.

## Permissions

Each navigation item can have a `permission`. When the current user doesn't have that permission, the item (and its children) are hidden from the menu:

```cs
[assembly: NavigationLink(9100, "Administration/Data Audit Log",
    typeof(Serenity.Pro.DataAuditLog.DataAuditLogPage), icon: "fa-history")]
```

When you use the `typeof(controller)` overload, the permission is read from the controller's `[PageAuthorize]` / `[Authorize]` attributes automatically.

## The Navigation Model

The declared attributes are turned into a navigation tree at runtime:

- [INavigationItemSource](../api/dotnet/Serenity.Net.Core/Serenity.Navigation/INavigationItemSource.md) — provides the list of `NavigationItemAttribute`s. The default implementation collects them from the type source (assembly attributes plus any `INavigationItemSource` implementations).
- [NavigationHelper](../api/dotnet/Serenity.Net.Web/Serenity.Navigation/NavigationHelper.md) — converts the attributes into a tree of [NavigationItem](../api/dotnet/Serenity.Net.Core/Serenity.Navigation/NavigationItem.md) objects, filtering by permission.
- [INavigationModel](../api/dotnet/Serenity.Net.Core/Serenity.Navigation/INavigationModel.md) — the resulting model for the current user: the items tree, the active item, and the active path.
- [INavigationModelFactory](../api/dotnet/Serenity.Net.Core/Serenity.Navigation/INavigationModelFactory.md) — creates an `INavigationModel` for the current user.

A `NavigationItem` has `Title`, `FullPath`, `IconClass`, `Url`, `Target`, `Parent`, `Children`, `IsSection`, and `Order`.

## Custom Navigation Item Sources

If you need to add navigation items dynamically (e.g. from a database), implement [INavigationItemSource](../api/dotnet/Serenity.Net.Core/Serenity.Navigation/INavigationItemSource.md) and return the attributes from `GetItems()`. Serenity discovers `INavigationItemSource` implementations through the type source and merges their items with the assembly-level attributes.

## See Also

- [Initialization and Startup](initialization.md) — how the type source discovers navigation attributes
- [Authorization](authorization.md) — permission filtering
- [Localization](localization.md) — navigation item titles as local texts