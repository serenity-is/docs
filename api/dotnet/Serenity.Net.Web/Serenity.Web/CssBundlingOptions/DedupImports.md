# CssBundlingOptions.DedupImports property

Gets or sets whether a CSS file that is imported multiple times within a bundle should only be embedded once. When `false` (the default, and matching browser behavior), the file is embedded at each import position. When `true`, the first occurrence is embedded and later ones are skipped.

```csharp
public bool? DedupImports { get; set; }
```

## See Also

* class [CssBundlingOptions](../CssBundlingOptions.md)