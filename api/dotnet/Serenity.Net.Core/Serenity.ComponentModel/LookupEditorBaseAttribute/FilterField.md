# LookupEditorBaseAttribute.FilterField property
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Optional filtering field (items will be filtered on this key, e.g. GroupID) Make sure you have [LookupInclude] attribute on this field of lookup row, otherwise you'll have empty results as this field won't be available client side.

```csharp
public object FilterField { get; set; }
```

## See Also

* class [LookupEditorBaseAttribute](../LookupEditorBaseAttribute.md)