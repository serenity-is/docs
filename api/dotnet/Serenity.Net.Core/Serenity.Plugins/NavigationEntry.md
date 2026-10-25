# NavigationEntry class
**namespace:** *[Serenity.Plugins](../README.md#serenity.plugins-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A plugin navigation entry abstraction.

```csharp
public class NavigationEntry
```

## Public Members

| name | description |
| --- | --- |
| [NavigationEntry](NavigationEntry/NavigationEntry.md)() | The default constructor. |
| [Action](NavigationEntry/Action.md) { get; set; } | Gets or sets the action name. |
| [Category](NavigationEntry/Category.md) { get; set; } | Gets or sets the category. |
| [Controller](NavigationEntry/Controller.md) { get; set; } | Gets or sets the controller type. |
| [FullPath](NavigationEntry/FullPath.md) { get; set; } | Gets or sets the full path. |
| [IconClass](NavigationEntry/IconClass.md) { get; set; } | Gets or sets the icon class. |
| [ItemClass](NavigationEntry/ItemClass.md) { get; set; } | Gets or sets the item class. |
| [Order](NavigationEntry/Order.md) { get; set; } | Gets or sets the order. |
| [Permission](NavigationEntry/Permission.md) { get; set; } | Gets or sets the permission. |
| [Target](NavigationEntry/Target.md) { get; set; } | Gets or sets the target window. |
| [Title](NavigationEntry/Title.md) { get; set; } | Gets or sets the title. |
| [Url](NavigationEntry/Url.md) { get; set; } | Gets or sets the URL. |

## Remarks

This type is part of a legacy plugin system design and is no longer used by the framework. Use the `NavigationLink` / `NavigationMenu` assembly attributes instead to declare navigation items.

## See Also

* **Source:** *[NavigationEntry.cs](https://github.com/serenity-is/Serenity/blob/42921a2cabf9c9256331037e2f6cd60672b97071/src/core/Plugins/NavigationEntry.cs)*