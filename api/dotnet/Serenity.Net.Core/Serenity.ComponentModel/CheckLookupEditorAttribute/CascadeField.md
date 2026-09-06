# CheckLookupEditorAttribute.CascadeField property

Cascade filtering field (items will be filtered on this key, e.g. CountryID). Make sure you have the [LookupInclude] attribute on this field of the lookup row, otherwise you'll have empty results as this field won't be available on the client side.

```csharp
public object? CascadeField { get; set; }
```

## See Also

* class [CheckLookupEditorAttribute](../CheckLookupEditorAttribute.md)