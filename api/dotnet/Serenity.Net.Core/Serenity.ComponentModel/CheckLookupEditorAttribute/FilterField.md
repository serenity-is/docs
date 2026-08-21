# CheckLookupEditorAttribute.FilterField property
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Optional filtering field (items will be filtered on this key, e.g. GroupID). Make sure you have the [LookupInclude] attribute on this field of the lookup row, otherwise you'll have empty results as this field won't be available on the client side.

```csharp
public object FilterField { get; set; }
```

## See Also

* class [CheckLookupEditorAttribute](../CheckLookupEditorAttribute.md)