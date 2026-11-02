# HtmlLazyTypesExtensions.LazyTypes method

Renders the types declared with [`LazyLoadTypesAttribute`](../LazyLoadTypesAttribute.md) as a JSON block that maps the content hashed module urls to their type keys, which the default `Config.lazyTypeLoader` reads when a type is not found in a type registry. Should be included in the layout head, like the `ScriptCulture` block. Returns an empty string if there are no such types.

```csharp
public static HtmlString LazyTypes(this IHtmlHelper helper)
```

| parameter | description |
| --- | --- |
| helper | The HTML helper. |

## Return Value

The rendered script element.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *helper* is `null`. |

## See Also

* class [HtmlLazyTypesExtensions](../HtmlLazyTypesExtensions.md)