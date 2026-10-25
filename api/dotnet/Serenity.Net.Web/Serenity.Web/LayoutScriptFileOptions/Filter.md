# LayoutScriptFileOptions.Filter property

Gets or sets an optional filter that can be used to exclude some of the declared layout script files. Returning `false` skips the file.

```csharp
public Func<LayoutScriptFileAttribute, bool>? Filter { get; set; }
```

## See Also

* class [LayoutScriptFileAttribute](../LayoutScriptFileAttribute.md)
* class [LayoutScriptFileOptions](../LayoutScriptFileOptions.md)