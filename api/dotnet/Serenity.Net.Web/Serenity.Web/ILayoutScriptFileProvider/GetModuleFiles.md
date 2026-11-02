# ILayoutScriptFileProvider.GetModuleFiles method

Gets the list of app relative (`~/`) urls of the ES modules to include in the layout, in the order they should be included, with duplicates removed.

```csharp
public IReadOnlyList<string> GetModuleFiles()
```

## Return Value

The list of ES module urls.

## See Also

* interface [ILayoutScriptFileProvider](../ILayoutScriptFileProvider.md)