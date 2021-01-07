# LookupEditorBaseAttribute.MinimumResultsForSearch property
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

The minimum number of results that must be initially (after opening the dropdown for the first time) populated in order to keep the search field. This is useful for cases where local data is used with just a few results, in which case the search box is not very useful and wastes screen space. The option can be set to a negative value to permanently hide the search field.

```csharp
public int MinimumResultsForSearch { get; set; }
```

## See Also

* class [LookupEditorBaseAttribute](../LookupEditorBaseAttribute.md)