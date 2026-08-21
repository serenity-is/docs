# NavigationItem.Order property
**namespace:** *[Serenity.Navigation](../../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Effective order among siblings. Unlike the declared `Order` on [`NavigationItemAttribute`](../NavigationItemAttribute.md) (which may be assigned from an Int32 in an assembly attribute), this is a Decimal so that duplicate declared orders can be resolved to unique values (see `NavigationHelper.HealOrders`), and so consumers (e.g. a CMS inserting dynamic pages into the menu) can compute a midpoint between two siblings.

```csharp
public decimal Order { get; set; }
```

## See Also

* class [NavigationItem](../NavigationItem.md)