# CssBundlingOptions.ProcessImports property

Gets or sets whether CSS `@import` statements in bundle source files should be processed and their contents embedded into the bundle. Only plain (non media qualified), relative imports at the start of a file are processed; external, absolute and conditional imports are left as is. Defaults to `true`. Set to `false` to disable import processing entirely.

```csharp
public bool? ProcessImports { get; set; }
```

## See Also

* class [CssBundlingOptions](../CssBundlingOptions.md)