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

A `NavigationItem` has `Title`, `FullPath`, `IconClass`, `ItemClass`, `Url`, `Target`, `Parent`, `Children`, `IsSection`, and `Order`.

## Custom Navigation Item Sources

If you need to add navigation items dynamically (e.g. from a database), implement [INavigationItemSource](../api/dotnet/Serenity.Net.Core/Serenity.Navigation/INavigationItemSource.md) and return the attributes from `GetItems()`. Serenity discovers `INavigationItemSource` implementations through the type source and merges their items with the assembly-level attributes.

## Feature-Gated Navigation Items

Every [NavigationItemAttribute](../api/dotnet/Serenity.Net.Core/Serenity.Navigation/NavigationItemAttribute.md) has two feature-toggle members:

- `RequireFeatures` — the set of feature names the item depends on.
- `RequireAnyFeature` — when `true`, only *any one* of the features needs to be enabled; when `false` (the default), *all* of them must be enabled.

When `NavigationHelper` collects the attributes, it checks these against the registered [IFeatureToggles](../api/dotnet/Serenity.Net.Core/Serenity.Abstractions/IFeatureToggles.md) service and skips items whose features are not enabled. If no `IFeatureToggles` is registered, the check passes.

You can set these directly on an attribute:

```cs
[assembly: NavigationLink(9100, "Administration/Data Audit Log",
    typeof(Serenity.Pro.DataAuditLog.DataAuditLogPage), icon: "fa-history",
    RequireFeatures = new[] { "DataAuditLog" })]
```

When you use the `typeof(controller)` overload, the features are read automatically from a `[FeatureBarrier]` attribute on the controller or its action (see [Feature Toggles](feature-toggles.md)).

## How the Controller Overload Resolves URL & Permission

The `typeof(controller)` overloads of [NavigationLinkAttribute](../api/dotnet/Serenity.Net.Web/Serenity.Navigation/NavigationLinkAttribute.md) (and the other navigation attributes) resolve the URL and permission from the controller instead of requiring you to pass them:

- `GetUrlFromController(controller, action)` — finds the action method, reads the `[Route]` attributes on the controller and action, combines them, and replaces the `[controller]` / `[action]` tokens. The result is rooted as `~/...`.
- `GetPermissionFromController(controller, action)` — reads the `[PageAuthorize]` attribute from the action method (falling back to the controller) and returns its permission key.
- `GetFeaturesFromController(controller, action)` — reads a `[FeatureBarrier]` attribute from the action (falling back to the controller) and returns its required features.

So this single declaration:

```cs
[assembly: NavigationLink(9800, "Administration/User Management",
    typeof(Administration.UserPage), icon: "fa-users")]
```

resolves the URL from the page's `[Route]` attribute, the permission from its `[PageAuthorize]`, and the features from its `[FeatureBarrier]` — you don't repeat any of them in the navigation declaration.

## NavigationHelper in Detail

[NavigationHelper](../api/dotnet/Serenity.Net.Web/Serenity.Navigation/NavigationHelper.md) is the static helper that turns the declared attributes into the navigation tree. Its main methods:

- `GetNavigationItems(permissions, typeSource, serviceProvider, resolveUrl, filter)` — collects the attributes (assembly-level plus `INavigationItemSource` implementations), filters them by feature toggles and the optional `filter` callback, and converts them to a tree of [NavigationItem](../api/dotnet/Serenity.Net.Core/Serenity.Navigation/NavigationItem.md) objects.
- `ConvertToNavigationItems(permissions, attrByCategory, resolveUrl)` — builds the tree. An item is included if it has children or if it has a URL and the user has its permission (or it has no permission).
- `ByCategory(list)` — groups attributes by their category path. It **auto-creates missing parent menus**: if an item declares `A/B/C` but no `A/B` menu exists, a `NavigationMenu` is synthesized for it. It also applies `[NavigationGroup]` `Include` / `Default` rules to move items into groups.
- `HealOrders(orders, parentOrder, sentinel, step)` — resolves duplicate order values among siblings into unique decimals, so colliding `int` orders (and the code generator's default `int.MaxValue` sentinel) get distinct sort keys without you having to manage exact gaps.

## See Also

- [Initialization and Startup](initialization.md) — how the type source discovers navigation attributes
- [Authorization](authorization.md) — permission filtering
- [Localization](localization.md) — navigation item titles as local texts
- [Feature Toggles](feature-toggles.md) — `RequireFeatures` / `[FeatureBarrier]` gating