# LayoutCssFileOptions.Filter property

Gets or sets an optional filter that can be used to exclude some of the declared layout CSS files. Returning `false` skips the file.

```csharp
public Func<LayoutCssFileAttribute, bool>? Filter { get; set; }
```

## See Also

* class [LayoutCssFileAttribute](../LayoutCssFileAttribute.md)
* class [LayoutCssFileOptions](../LayoutCssFileOptions.md)