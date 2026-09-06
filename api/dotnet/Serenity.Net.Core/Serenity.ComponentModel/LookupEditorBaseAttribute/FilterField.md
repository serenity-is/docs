# LookupEditorBaseAttribute.FilterField property

Optional filtering field (items will be filtered on this key, e.g. GroupID). Make sure you have the [LookupInclude] attribute on this field of the lookup row, otherwise you'll have empty results as this field won't be available on the client side.

```csharp
public string? FilterField { get; set; }
```

## See Also

* class [LookupEditorBaseAttribute](../LookupEditorBaseAttribute.md)