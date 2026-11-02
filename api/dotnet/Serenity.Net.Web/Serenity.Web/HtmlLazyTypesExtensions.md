# HtmlLazyTypesExtensions class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Contains extensions for the client side types that are loaded when they are first requested.

```csharp
public static class HtmlLazyTypesExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [LazyTypes](HtmlLazyTypesExtensions/LazyTypes.md)(…) | Renders the types declared with [`LazyLoadTypesAttribute`](./LazyLoadTypesAttribute.md) as a JSON block that maps the content hashed module urls to their type keys, which the default `Config.lazyTypeLoader` reads when a type is not found in a type registry. Should be included in the layout head, like the `ScriptCulture` block. Returns an empty string if there are no such types. |

## See Also

* **Source:** *[HtmlLazyTypesExtensions.cs](https://github.com/serenity-is/Serenity/blob/3ee4ed336eca3c73bc3d291124715a793a825afd/src/web/Mvc/Html/HtmlLazyTypesExtensions.cs)*