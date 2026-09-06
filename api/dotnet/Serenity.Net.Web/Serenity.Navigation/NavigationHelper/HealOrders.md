# NavigationHelper.HealOrders method

Resolves duplicate order values among a set of siblings into unique decimal values, e.g. so that statically declared navigation items (whose Int32 order may collide, as it is only guaranteed unique by developer convention, not enforced) get distinct sort keys that a consumer (e.g. a CMS module) can also use to compute a midpoint when inserting new items between them. This only changes orders for items that actually collide with another sibling; non-colliding orders (other than *sentinel*, see below) are returned unchanged, and within a group of colliding siblings, the first one (in the order it was given) also keeps its original value, minimizing the number of altered orders. Any order equal to *sentinel* (the code generator's default, meaning "not explicitly set") is never left as-is: it is always resolved to *parentOrder* (or the largest real sibling order, if there is one) plus a multiple of *step*, so a forgotten order ends up near its siblings instead of near MaxValue.

```csharp
public static IReadOnlyList<decimal> HealOrders(IReadOnlyList<decimal> orders, 
    decimal? parentOrder = null, decimal sentinel = 2147483647, decimal step = 100)
```

| parameter | description |
| --- | --- |
| orders | Sibling order values, already sorted ascending. Ties should be in a stable, deterministic order (e.g. as produced by a stable sort), as that relative order is preserved. |
| parentOrder | The parent item's own resolved order, used as the fallback baseline for *sentinel* orders when there is no real sibling order to anchor to. Null (the default) for a top level item, or if the parent's order isn't known/relevant. |
| sentinel | The order value that means "not explicitly set". Defaults to MaxValue, matching the code generator's navigation link template and the string-only `NavigationLinkAttribute`/`NavigationMenuAttribute` constructors. |
| step | The spacing used both between resolved *sentinel* orders, and as the fallback gap for a trailing duplicate group that has no following distinct order. |

## See Also

* class [NavigationHelper](../NavigationHelper.md)