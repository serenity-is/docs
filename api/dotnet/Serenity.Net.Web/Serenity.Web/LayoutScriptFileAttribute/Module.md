# LayoutScriptFileAttribute.Module property

Gets or sets a value indicating whether the file is an ES module, which is rendered with its own `type="module"` script tag and never concatenated to a bundle, as its imports are relative to its own URL. Defaults to `true` for files under an `esm` folder and `.mjs` files.

```csharp
public bool Module { get; set; }
```

## See Also

* class [LayoutScriptFileAttribute](../LayoutScriptFileAttribute.md)