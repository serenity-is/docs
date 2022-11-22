# NavigationGroupAttribute.Include property
**namespace:** *[Serenity.Navigation](../../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

This is a list used to move items that are not normally under this item based on path (to create groups). For example, if this item is named A, and want to move all menus under B/.. or C/.. to A, the list should be ["B/", "C/"]. To move B and C themselves under A, list should be ["B", "C"].

```csharp
public string[] Include { get; set; }
```

## See Also

* class [NavigationGroupAttribute](../NavigationGroupAttribute.md)