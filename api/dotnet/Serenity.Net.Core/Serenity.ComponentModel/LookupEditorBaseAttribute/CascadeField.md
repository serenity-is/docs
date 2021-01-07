# LookupEditorBaseAttribute.CascadeField property
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Cascade filtering field (items will be filtered on this key, e.g. CountryID) Make sure you have [LookupInclude] attribute on this field of lookup row, otherwise you'll have empty results as this field won't be available client side.

```csharp
public object CascadeField { get; set; }
```

## See Also

* class [LookupEditorBaseAttribute](../LookupEditorBaseAttribute.md)