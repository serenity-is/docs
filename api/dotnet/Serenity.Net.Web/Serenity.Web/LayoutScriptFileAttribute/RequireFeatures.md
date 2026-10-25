# LayoutScriptFileAttribute.RequireFeatures property

Gets or sets the set of feature toggles this file depends on. When set, the file is only included if all (or any, see [`RequireAnyFeature`](./RequireAnyFeature.md)) of the features are enabled.

```csharp
public string[]? RequireFeatures { get; set; }
```

## See Also

* class [LayoutScriptFileAttribute](../LayoutScriptFileAttribute.md)